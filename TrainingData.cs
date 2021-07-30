using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MVTrainer
{
    public partial class TrainingData : Form
    {
        public DataGridView DataGrid { set; get; }
        public decimal[] AccuracyData { set; get; }

        public TrainingData()
        {
            InitializeComponent();
        }

        private void TrainingData_Load(object sender, EventArgs e)
        {
            int i = 1;
            foreach (decimal number in AccuracyData)
            {
                Grid_TrainingResults.Rows.Add("Iteration: "+i, number);
                i++;
            }


            
        }
    }
}
