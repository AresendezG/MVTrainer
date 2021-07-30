using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.ML;
using static Microsoft.ML.DataOperationsCatalog;
using Microsoft.ML.Vision;

namespace MVTrainer
{
    class MLStuff
    {


        public string ModelOutputPath;
        public string AssetsFolderPath;
        public bool ModelIsTrained;
        

        public decimal[] AccuracyData;

        private MLContext contexto;
        private ITransformer trainedModel;
        

        private IEnumerable<ImageData> images;
        private IDataView imageData;
        private IDataView shuffledData;

        public MLStuff(string AssetsPath) // ML Constructor
        {
            
            AssetsFolderPath = AssetsPath;
            contexto = new MLContext();

            images = LoadImagesFromDirectory(folder: AssetsFolderPath, useFolderNameAsLabel: true);
            imageData = contexto.Data.LoadFromEnumerable(images);
            shuffledData = contexto.Data.ShuffleRows(imageData);

        }

        public bool TrainModel()
        {
            try
            {
                var preprocessingPipeline = contexto.Transforms.Conversion.MapValueToKey(
                                        inputColumnName: "Label",
                                        outputColumnName: "LabelAsKey")
                                        .Append(contexto.Transforms.LoadRawImageBytes(
                                        outputColumnName: "Image",
                                        imageFolder: AssetsFolderPath,
                                        inputColumnName: "ImagePath"));

                IDataView preProcessedData = preprocessingPipeline
                        .Fit(shuffledData)
                        .Transform(shuffledData);


                TrainTestData trainSplit = contexto.Data.TrainTestSplit(data: preProcessedData, testFraction: 0.3);
                TrainTestData validationTestSplit = contexto.Data.TrainTestSplit(trainSplit.TestSet);

                IDataView trainSet = trainSplit.TrainSet;
                IDataView validationSet = validationTestSplit.TrainSet;
                IDataView testSet = validationTestSplit.TestSet;

                var classifierOptions = new ImageClassificationTrainer.Options()
                {
                    FeatureColumnName = "Image",
                    LabelColumnName = "LabelAsKey",
                    ValidationSet = validationSet,
                    Arch = ImageClassificationTrainer.Architecture.ResnetV2101,
                    MetricsCallback = (metrics) => MetricsFunction(metrics), //Console.WriteLine(metrics),
                    TestOnTrainSet = false,
                    ReuseTrainSetBottleneckCachedValues = true,
                    ReuseValidationSetBottleneckCachedValues = true
                };

                var trainingPipeline = contexto.MulticlassClassification.Trainers.ImageClassification(classifierOptions).Append(contexto.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

                trainedModel = trainingPipeline.Fit(trainSet);

                ModelIsTrained = true;
                return true;
            }
            catch
            {
                ModelIsTrained = false;
                return false;
            }
        }


        // Save Trained Model
        public bool SaveModel(string Path)
        {
            if(File.Exists(Path)){               
                try
                {
                    Random rand = new Random();
                    string newPath = Path.Substring(0, Path.IndexOf('.')) +"_"+rand.Next(1500)+ "bckup.zip";
                    File.Copy(Path, newPath);
                    File.Delete(Path);
                }
                catch
                {
                    return false;
                }
            }

            contexto.Model.Save(trainedModel, shuffledData.Schema, Path);
            return true;

        }


        public static IEnumerable<ImageData> LoadImagesFromDirectory(string folder, bool useFolderNameAsLabel = true)
        {
            var files = Directory.GetFiles(folder, "*", searchOption: SearchOption.AllDirectories);

            foreach (var file in files)
            {
                if ((Path.GetExtension(file) != ".jpeg") && (Path.GetExtension(file) != ".png"))
                    continue;
                var label = Path.GetFileName(file);

                if (useFolderNameAsLabel)
                    label = Directory.GetParent(file).Name;
                else
                {
                    for (int index = 0; index < label.Length; index++)
                    {
                        if (!char.IsLetter(label[index]))
                        {
                            label = label.Substring(0, index);
                            break;
                        }
                    }
                }

                yield return new ImageData()
                {
                    ImagePath = file,
                    Label = label
                };

            }

        }

        private void MetricsFunction(ImageClassificationTrainer.ImageClassificationMetrics metrics)
        {
            //Console.WriteLine("Metric");

            decimal AccNumber;
            try
            {
                if (metrics.Train != null)
                {

                    if (metrics.Train.DatasetUsed.ToString() == "Validation") // Log the accuracy data somewhere...
                    {
                        AccNumber = Convert.ToDecimal(metrics.Train.Accuracy.ToString());
                        AccuracyData = Extensions.Append(AccuracyData, AccNumber);

                    }
                }
            }
            catch
            {
                return;
            }

        }






    }
}
