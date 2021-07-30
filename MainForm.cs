using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MVTrainer
{
    public partial class MainForm : Form
    {
        private MLStuff ML;
        private bool ModelTrained;
        private decimal[] AccuracyData;
        public MainForm()
        {
            InitializeComponent();
        }
        // Main Form Load Function
        private void MainForm_Load(object sender, EventArgs e)
        {
            // No model has been trained yet:
            ModelTrained = false;
        }

        private void PickAssets_Click(object sender, EventArgs e)
        {
            folderBrowserDiag.ShowDialog();
            AssetsPathText.Text = folderBrowserDiag.SelectedPath;

        }

        private void PickModelOutput_Click(object sender, EventArgs e)
        {
            folderBrowserDiag.ShowDialog();
            ModelOutTextBox.Text = folderBrowserDiag.SelectedPath + "\\trainedModel.zip";
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(AssetsPathText.Text)){

                string TrainingLabels = "";
                

                foreach (string subdir in Directory.GetDirectories(AssetsPathText.Text))
                {
                    TrainingLabels += "\n*"+subdir.Substring(subdir.LastIndexOf('\\')+1);
                }
                if (Directory.GetDirectories(AssetsPathText.Text).Length >= 2)
                {
                    DialogResult UserConfirmAssets = MessageBox.Show("The following Categories in the Assets: " + TrainingLabels + "\nDo you want to continue?",
                        "Continue",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (UserConfirmAssets == DialogResult.Yes)
                    {
                        ML = new MLStuff(AssetsPathText.Text);
                        StatusLabel.Text += "Data Loaded to ML Context. Click Train to compile model.";
                    }
                }
                else
                {
                    MessageBox.Show("Error, This Assets Folder has no Categories", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    StatusLabel.Text = "Error. Assets Path has no Categories";
                }
            }
            else
            {
                MessageBox.Show("Error, Assets Folder Path not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StatusLabel.Text = "Error. Assets Path not Found";
            }
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            bool ModelTraining;

            MessageBox.Show("Model Training will take a while. Do not close this execution", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Cursor.Current = Cursors.WaitCursor;
            StatusLabel.Text = "Model Training Started...";
            
            ModelTraining = ML.TrainModel();
            if (ModelTraining)
            {
                StatusLabel.Text = "Model Training Completed Successfully. Click Save to Save Model";
                AccuracyData = ML.AccuracyData;
                ShowTData_Btn.Enabled = true;
                ShowTData_Btn.Visible = true;
                ModelTrained = true;
            }
            else
            {
                MessageBox.Show("Error during Model Training. Check the Output Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StatusLabel.Text = "Error During Training";
                ModelTrained = false;
            }

            Cursor.Current = Cursors.Default;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ModelTrained)
            {
                DialogResult SaveConfirm = MessageBox.Show("Training Completed. Save Model?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (SaveConfirm == DialogResult.Yes)
                {
                    StatusLabel.Text = "Saving Model Data... Wait";
                    if (ML.SaveModel(ModelOutTextBox.Text))
                    {
                        StatusLabel.Text += "Model Saved to: " + ModelOutTextBox.Text;

                    }
                    else
                    {
                        MessageBox.Show("Error. Model Cannot be saved. Check Path", "Error Saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        StatusLabel.Text = "Error. Model was not saved. Check Path";
                    }
                }
            }
            else
            {
                MessageBox.Show("Error. Model has not been trained yet", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowTData_Btn_Click(object sender, EventArgs e)
        {
            if (ModelTrained)
            {
                TrainingData TDForm = new TrainingData
                {
                    AccuracyData = AccuracyData
                };
                TDForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error. Model has not been trained yet", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
