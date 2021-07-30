
namespace MVTrainer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AssetsPathText = new System.Windows.Forms.TextBox();
            this.PickAssets = new System.Windows.Forms.Button();
            this.PickModelOutput = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ModelOutTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ShowTData_Btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LoadButton = new System.Windows.Forms.Button();
            this.TrainButton = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.folderBrowserDiag = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.73591F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.264095F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.01299F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.98701F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 308);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.86944F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.13056F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.PickAssets, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PickModelOutput, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(320, 262);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AssetsPathText);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(40, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 44);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assets Path";
            // 
            // AssetsPathText
            // 
            this.AssetsPathText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssetsPathText.Location = new System.Drawing.Point(3, 19);
            this.AssetsPathText.Name = "AssetsPathText";
            this.AssetsPathText.Size = new System.Drawing.Size(271, 23);
            this.AssetsPathText.TabIndex = 0;
            // 
            // PickAssets
            // 
            this.PickAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PickAssets.Location = new System.Drawing.Point(3, 3);
            this.PickAssets.Name = "PickAssets";
            this.PickAssets.Size = new System.Drawing.Size(31, 44);
            this.PickAssets.TabIndex = 0;
            this.PickAssets.Text = "...";
            this.PickAssets.UseVisualStyleBackColor = true;
            this.PickAssets.Click += new System.EventHandler(this.PickAssets_Click);
            // 
            // PickModelOutput
            // 
            this.PickModelOutput.Location = new System.Drawing.Point(3, 53);
            this.PickModelOutput.Name = "PickModelOutput";
            this.PickModelOutput.Size = new System.Drawing.Size(31, 44);
            this.PickModelOutput.TabIndex = 2;
            this.PickModelOutput.Text = "...";
            this.PickModelOutput.UseVisualStyleBackColor = true;
            this.PickModelOutput.Click += new System.EventHandler(this.PickModelOutput_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ModelOutTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(40, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 44);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Model Output Path";
            // 
            // ModelOutTextBox
            // 
            this.ModelOutTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelOutTextBox.Location = new System.Drawing.Point(3, 19);
            this.ModelOutTextBox.Name = "ModelOutTextBox";
            this.ModelOutTextBox.Size = new System.Drawing.Size(271, 23);
            this.ModelOutTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StatusLabel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(40, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 74);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(6, 19);
            this.StatusLabel.MaximumSize = new System.Drawing.Size(220, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(10, 15);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = " ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ShowTData_Btn);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(40, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 76);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Display Training Results";
            // 
            // ShowTData_Btn
            // 
            this.ShowTData_Btn.Enabled = false;
            this.ShowTData_Btn.Location = new System.Drawing.Point(3, 22);
            this.ShowTData_Btn.Name = "ShowTData_Btn";
            this.ShowTData_Btn.Size = new System.Drawing.Size(75, 28);
            this.ShowTData_Btn.TabIndex = 0;
            this.ShowTData_Btn.Text = "Show";
            this.ShowTData_Btn.UseVisualStyleBackColor = true;
            this.ShowTData_Btn.Visible = false;
            this.ShowTData_Btn.Click += new System.EventHandler(this.ShowTData_Btn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.LoadButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TrainButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.saveBtn, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(46, 271);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(277, 34);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // LoadButton
            // 
            this.LoadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadButton.Location = new System.Drawing.Point(3, 3);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(85, 28);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // TrainButton
            // 
            this.TrainButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrainButton.Location = new System.Drawing.Point(94, 3);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(85, 28);
            this.TrainButton.TabIndex = 1;
            this.TrainButton.Text = "Train Model";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveBtn.Location = new System.Drawing.Point(185, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(89, 28);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save Model";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 308);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MotoVision Model Training";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PickAssets;
        private System.Windows.Forms.Button PickModelOutput;
        private System.Windows.Forms.TextBox AssetsPathText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ModelOutTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDiag;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ShowTData_Btn;
    }
}

