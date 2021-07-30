
namespace MVTrainer
{
    partial class TrainingData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grid_TrainingResults = new System.Windows.Forms.DataGridView();
            this.Iteration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TrainingResults)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_TrainingResults
            // 
            this.Grid_TrainingResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_TrainingResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteration,
            this.Accuracy});
            this.Grid_TrainingResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_TrainingResults.Location = new System.Drawing.Point(0, 0);
            this.Grid_TrainingResults.Name = "Grid_TrainingResults";
            this.Grid_TrainingResults.RowTemplate.Height = 25;
            this.Grid_TrainingResults.Size = new System.Drawing.Size(246, 188);
            this.Grid_TrainingResults.TabIndex = 0;
            // 
            // Iteration
            // 
            this.Iteration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Iteration.HeaderText = "Iteration";
            this.Iteration.Name = "Iteration";
            // 
            // Accuracy
            // 
            this.Accuracy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Accuracy.HeaderText = "Accuracy";
            this.Accuracy.Name = "Accuracy";
            // 
            // TrainingData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 188);
            this.Controls.Add(this.Grid_TrainingResults);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainingData";
            this.Text = "TrainingData";
            this.Load += new System.EventHandler(this.TrainingData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_TrainingResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView Grid_TrainingResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accuracy;
    }
}