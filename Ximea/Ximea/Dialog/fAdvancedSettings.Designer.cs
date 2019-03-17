namespace Camera.Dialog
{
    partial class fAdvancedSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdvancedSettings));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.pMain = new System.Windows.Forms.Panel();
            this.gGainAdjusment = new System.Windows.Forms.GroupBox();
            this.lblGainValue4 = new System.Windows.Forms.Label();
            this.lblGain4 = new System.Windows.Forms.Label();
            this.Gain4 = new System.Windows.Forms.TrackBar();
            this.lblBand4 = new System.Windows.Forms.Label();
            this.lblGainValue3 = new System.Windows.Forms.Label();
            this.lblGain3 = new System.Windows.Forms.Label();
            this.Gain3 = new System.Windows.Forms.TrackBar();
            this.lblBand3 = new System.Windows.Forms.Label();
            this.lblGainValue2 = new System.Windows.Forms.Label();
            this.lblGain2 = new System.Windows.Forms.Label();
            this.Gain2 = new System.Windows.Forms.TrackBar();
            this.lblBand2 = new System.Windows.Forms.Label();
            this.lblGainValue1 = new System.Windows.Forms.Label();
            this.lblGain1 = new System.Windows.Forms.Label();
            this.Gain1 = new System.Windows.Forms.TrackBar();
            this.lblBand1 = new System.Windows.Forms.Label();
            this.gDefectCorrection = new System.Windows.Forms.GroupBox();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.CorrectionImageDirectory = new System.Windows.Forms.TextBox();
            this.lblCorrectionImageDirectory = new System.Windows.Forms.Label();
            this.pFlatFieldCorrection = new System.Windows.Forms.Panel();
            this.rbFlatFieldCorrectionOff = new System.Windows.Forms.RadioButton();
            this.FlatFieldCorrection = new System.Windows.Forms.RadioButton();
            this.lblFlatFieldCorrection = new System.Windows.Forms.Label();
            this.pAutoExposure = new System.Windows.Forms.Panel();
            this.rbSenorPixelCorrectionOff = new System.Windows.Forms.RadioButton();
            this.SenorPixelCorrection = new System.Windows.Forms.RadioButton();
            this.lblSenorPixelCorrection = new System.Windows.Forms.Label();
            this.pMain.SuspendLayout();
            this.gGainAdjusment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gain4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gain3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gain2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gain1)).BeginInit();
            this.gDefectCorrection.SuspendLayout();
            this.pFlatFieldCorrection.SuspendLayout();
            this.pAutoExposure.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.Location = new System.Drawing.Point(12, 532);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOk.Location = new System.Drawing.Point(265, 532);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.Location = new System.Drawing.Point(346, 532);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApply.Location = new System.Drawing.Point(427, 532);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.Window;
            this.pMain.Controls.Add(this.gGainAdjusment);
            this.pMain.Controls.Add(this.gDefectCorrection);
            this.pMain.Location = new System.Drawing.Point(12, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(490, 502);
            this.pMain.TabIndex = 4;
            // 
            // gGainAdjusment
            // 
            this.gGainAdjusment.Controls.Add(this.lblGainValue4);
            this.gGainAdjusment.Controls.Add(this.lblGain4);
            this.gGainAdjusment.Controls.Add(this.Gain4);
            this.gGainAdjusment.Controls.Add(this.lblBand4);
            this.gGainAdjusment.Controls.Add(this.lblGainValue3);
            this.gGainAdjusment.Controls.Add(this.lblGain3);
            this.gGainAdjusment.Controls.Add(this.Gain3);
            this.gGainAdjusment.Controls.Add(this.lblBand3);
            this.gGainAdjusment.Controls.Add(this.lblGainValue2);
            this.gGainAdjusment.Controls.Add(this.lblGain2);
            this.gGainAdjusment.Controls.Add(this.Gain2);
            this.gGainAdjusment.Controls.Add(this.lblBand2);
            this.gGainAdjusment.Controls.Add(this.lblGainValue1);
            this.gGainAdjusment.Controls.Add(this.lblGain1);
            this.gGainAdjusment.Controls.Add(this.Gain1);
            this.gGainAdjusment.Controls.Add(this.lblBand1);
            this.gGainAdjusment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gGainAdjusment.Location = new System.Drawing.Point(16, 251);
            this.gGainAdjusment.Name = "gGainAdjusment";
            this.gGainAdjusment.Size = new System.Drawing.Size(459, 234);
            this.gGainAdjusment.TabIndex = 1;
            this.gGainAdjusment.TabStop = false;
            this.gGainAdjusment.Text = "Gain Adjustment";
            // 
            // lblGainValue4
            // 
            this.lblGainValue4.AutoSize = true;
            this.lblGainValue4.Location = new System.Drawing.Point(379, 183);
            this.lblGainValue4.Name = "lblGainValue4";
            this.lblGainValue4.Size = new System.Drawing.Size(30, 15);
            this.lblGainValue4.TabIndex = 15;
            this.lblGainValue4.Text = "0 dB";
            // 
            // lblGain4
            // 
            this.lblGain4.AutoSize = true;
            this.lblGain4.Location = new System.Drawing.Point(97, 183);
            this.lblGain4.Name = "lblGain4";
            this.lblGain4.Size = new System.Drawing.Size(31, 15);
            this.lblGain4.TabIndex = 14;
            this.lblGain4.Text = "Gain";
            // 
            // Gain4
            // 
            this.Gain4.Location = new System.Drawing.Point(132, 183);
            this.Gain4.Maximum = 18;
            this.Gain4.Name = "Gain4";
            this.Gain4.Size = new System.Drawing.Size(244, 45);
            this.Gain4.TabIndex = 13;
            this.Gain4.Scroll += new System.EventHandler(this.Gain4_Scroll);
            // 
            // lblBand4
            // 
            this.lblBand4.AutoSize = true;
            this.lblBand4.Location = new System.Drawing.Point(47, 183);
            this.lblBand4.Name = "lblBand4";
            this.lblBand4.Size = new System.Drawing.Size(46, 15);
            this.lblBand4.TabIndex = 12;
            this.lblBand4.Text = "Band 4:";
            // 
            // lblGainValue3
            // 
            this.lblGainValue3.AutoSize = true;
            this.lblGainValue3.Location = new System.Drawing.Point(379, 132);
            this.lblGainValue3.Name = "lblGainValue3";
            this.lblGainValue3.Size = new System.Drawing.Size(30, 15);
            this.lblGainValue3.TabIndex = 11;
            this.lblGainValue3.Text = "0 dB";
            // 
            // lblGain3
            // 
            this.lblGain3.AutoSize = true;
            this.lblGain3.Location = new System.Drawing.Point(97, 132);
            this.lblGain3.Name = "lblGain3";
            this.lblGain3.Size = new System.Drawing.Size(31, 15);
            this.lblGain3.TabIndex = 10;
            this.lblGain3.Text = "Gain";
            // 
            // Gain3
            // 
            this.Gain3.Location = new System.Drawing.Point(132, 132);
            this.Gain3.Maximum = 18;
            this.Gain3.Name = "Gain3";
            this.Gain3.Size = new System.Drawing.Size(244, 45);
            this.Gain3.TabIndex = 9;
            this.Gain3.Scroll += new System.EventHandler(this.Gain3_Scroll);
            // 
            // lblBand3
            // 
            this.lblBand3.AutoSize = true;
            this.lblBand3.Location = new System.Drawing.Point(47, 132);
            this.lblBand3.Name = "lblBand3";
            this.lblBand3.Size = new System.Drawing.Size(46, 15);
            this.lblBand3.TabIndex = 8;
            this.lblBand3.Text = "Band 3:";
            // 
            // lblGainValue2
            // 
            this.lblGainValue2.AutoSize = true;
            this.lblGainValue2.Location = new System.Drawing.Point(379, 81);
            this.lblGainValue2.Name = "lblGainValue2";
            this.lblGainValue2.Size = new System.Drawing.Size(30, 15);
            this.lblGainValue2.TabIndex = 7;
            this.lblGainValue2.Text = "0 dB";
            // 
            // lblGain2
            // 
            this.lblGain2.AutoSize = true;
            this.lblGain2.Location = new System.Drawing.Point(97, 81);
            this.lblGain2.Name = "lblGain2";
            this.lblGain2.Size = new System.Drawing.Size(31, 15);
            this.lblGain2.TabIndex = 6;
            this.lblGain2.Text = "Gain";
            // 
            // Gain2
            // 
            this.Gain2.Location = new System.Drawing.Point(132, 81);
            this.Gain2.Maximum = 18;
            this.Gain2.Name = "Gain2";
            this.Gain2.Size = new System.Drawing.Size(244, 45);
            this.Gain2.TabIndex = 5;
            this.Gain2.Scroll += new System.EventHandler(this.Gain2_Scroll);
            // 
            // lblBand2
            // 
            this.lblBand2.AutoSize = true;
            this.lblBand2.Location = new System.Drawing.Point(47, 81);
            this.lblBand2.Name = "lblBand2";
            this.lblBand2.Size = new System.Drawing.Size(46, 15);
            this.lblBand2.TabIndex = 4;
            this.lblBand2.Text = "Band 2:";
            // 
            // lblGainValue1
            // 
            this.lblGainValue1.AutoSize = true;
            this.lblGainValue1.Location = new System.Drawing.Point(379, 30);
            this.lblGainValue1.Name = "lblGainValue1";
            this.lblGainValue1.Size = new System.Drawing.Size(30, 15);
            this.lblGainValue1.TabIndex = 3;
            this.lblGainValue1.Text = "0 dB";
            // 
            // lblGain1
            // 
            this.lblGain1.AutoSize = true;
            this.lblGain1.Location = new System.Drawing.Point(97, 30);
            this.lblGain1.Name = "lblGain1";
            this.lblGain1.Size = new System.Drawing.Size(31, 15);
            this.lblGain1.TabIndex = 2;
            this.lblGain1.Text = "Gain";
            // 
            // Gain1
            // 
            this.Gain1.Location = new System.Drawing.Point(132, 30);
            this.Gain1.Maximum = 18;
            this.Gain1.Name = "Gain1";
            this.Gain1.Size = new System.Drawing.Size(244, 45);
            this.Gain1.TabIndex = 1;
            this.Gain1.Scroll += new System.EventHandler(this.Gain1_Scroll);
            // 
            // lblBand1
            // 
            this.lblBand1.AutoSize = true;
            this.lblBand1.Location = new System.Drawing.Point(47, 30);
            this.lblBand1.Name = "lblBand1";
            this.lblBand1.Size = new System.Drawing.Size(46, 15);
            this.lblBand1.TabIndex = 0;
            this.lblBand1.Text = "Band 1:";
            // 
            // gDefectCorrection
            // 
            this.gDefectCorrection.Controls.Add(this.btnFilePath);
            this.gDefectCorrection.Controls.Add(this.CorrectionImageDirectory);
            this.gDefectCorrection.Controls.Add(this.lblCorrectionImageDirectory);
            this.gDefectCorrection.Controls.Add(this.pFlatFieldCorrection);
            this.gDefectCorrection.Controls.Add(this.pAutoExposure);
            this.gDefectCorrection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gDefectCorrection.Location = new System.Drawing.Point(15, 15);
            this.gDefectCorrection.Name = "gDefectCorrection";
            this.gDefectCorrection.Size = new System.Drawing.Size(460, 230);
            this.gDefectCorrection.TabIndex = 0;
            this.gDefectCorrection.TabStop = false;
            this.gDefectCorrection.Text = "Defect Correction";
            // 
            // btnFilePath
            // 
            this.btnFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilePath.Location = new System.Drawing.Point(327, 180);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(83, 25);
            this.btnFilePath.TabIndex = 9;
            this.btnFilePath.Text = "&Browse...";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // CorrectionImageDirectory
            // 
            this.CorrectionImageDirectory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CorrectionImageDirectory.Location = new System.Drawing.Point(51, 181);
            this.CorrectionImageDirectory.Name = "CorrectionImageDirectory";
            this.CorrectionImageDirectory.Size = new System.Drawing.Size(270, 23);
            this.CorrectionImageDirectory.TabIndex = 8;
            this.CorrectionImageDirectory.TextChanged += new System.EventHandler(this.CorrectionImageDirectory_TextChanged);
            // 
            // lblCorrectionImageDirectory
            // 
            this.lblCorrectionImageDirectory.AutoSize = true;
            this.lblCorrectionImageDirectory.Location = new System.Drawing.Point(48, 157);
            this.lblCorrectionImageDirectory.Name = "lblCorrectionImageDirectory";
            this.lblCorrectionImageDirectory.Size = new System.Drawing.Size(153, 15);
            this.lblCorrectionImageDirectory.TabIndex = 7;
            this.lblCorrectionImageDirectory.Text = "Correction Image Directory:";
            // 
            // pFlatFieldCorrection
            // 
            this.pFlatFieldCorrection.Controls.Add(this.rbFlatFieldCorrectionOff);
            this.pFlatFieldCorrection.Controls.Add(this.FlatFieldCorrection);
            this.pFlatFieldCorrection.Controls.Add(this.lblFlatFieldCorrection);
            this.pFlatFieldCorrection.Location = new System.Drawing.Point(51, 89);
            this.pFlatFieldCorrection.Name = "pFlatFieldCorrection";
            this.pFlatFieldCorrection.Size = new System.Drawing.Size(270, 61);
            this.pFlatFieldCorrection.TabIndex = 6;
            // 
            // rbFlatFieldCorrectionOff
            // 
            this.rbFlatFieldCorrectionOff.AutoSize = true;
            this.rbFlatFieldCorrectionOff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbFlatFieldCorrectionOff.Location = new System.Drawing.Point(167, 28);
            this.rbFlatFieldCorrectionOff.Name = "rbFlatFieldCorrectionOff";
            this.rbFlatFieldCorrectionOff.Size = new System.Drawing.Size(42, 19);
            this.rbFlatFieldCorrectionOff.TabIndex = 5;
            this.rbFlatFieldCorrectionOff.TabStop = true;
            this.rbFlatFieldCorrectionOff.Text = "Off";
            this.rbFlatFieldCorrectionOff.UseVisualStyleBackColor = true;
            this.rbFlatFieldCorrectionOff.CheckedChanged += new System.EventHandler(this.rbFlatFieldCorrectionOff_CheckedChanged);
            // 
            // FlatFieldCorrection
            // 
            this.FlatFieldCorrection.AutoSize = true;
            this.FlatFieldCorrection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FlatFieldCorrection.Location = new System.Drawing.Point(167, 3);
            this.FlatFieldCorrection.Name = "FlatFieldCorrection";
            this.FlatFieldCorrection.Size = new System.Drawing.Size(41, 19);
            this.FlatFieldCorrection.TabIndex = 4;
            this.FlatFieldCorrection.TabStop = true;
            this.FlatFieldCorrection.Text = "On";
            this.FlatFieldCorrection.UseVisualStyleBackColor = true;
            this.FlatFieldCorrection.CheckedChanged += new System.EventHandler(this.FlatFieldCorrection_CheckedChanged);
            // 
            // lblFlatFieldCorrection
            // 
            this.lblFlatFieldCorrection.AutoSize = true;
            this.lblFlatFieldCorrection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFlatFieldCorrection.Location = new System.Drawing.Point(5, 5);
            this.lblFlatFieldCorrection.Name = "lblFlatFieldCorrection";
            this.lblFlatFieldCorrection.Size = new System.Drawing.Size(116, 15);
            this.lblFlatFieldCorrection.TabIndex = 3;
            this.lblFlatFieldCorrection.Text = "Flat Field Correction:";
            // 
            // pAutoExposure
            // 
            this.pAutoExposure.Controls.Add(this.rbSenorPixelCorrectionOff);
            this.pAutoExposure.Controls.Add(this.SenorPixelCorrection);
            this.pAutoExposure.Controls.Add(this.lblSenorPixelCorrection);
            this.pAutoExposure.Location = new System.Drawing.Point(51, 22);
            this.pAutoExposure.Name = "pAutoExposure";
            this.pAutoExposure.Size = new System.Drawing.Size(270, 61);
            this.pAutoExposure.TabIndex = 4;
            // 
            // rbSenorPixelCorrectionOff
            // 
            this.rbSenorPixelCorrectionOff.AutoSize = true;
            this.rbSenorPixelCorrectionOff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbSenorPixelCorrectionOff.Location = new System.Drawing.Point(167, 28);
            this.rbSenorPixelCorrectionOff.Name = "rbSenorPixelCorrectionOff";
            this.rbSenorPixelCorrectionOff.Size = new System.Drawing.Size(42, 19);
            this.rbSenorPixelCorrectionOff.TabIndex = 5;
            this.rbSenorPixelCorrectionOff.TabStop = true;
            this.rbSenorPixelCorrectionOff.Text = "Off";
            this.rbSenorPixelCorrectionOff.UseVisualStyleBackColor = true;
            this.rbSenorPixelCorrectionOff.CheckedChanged += new System.EventHandler(this.rbSenorPixelCorrectionOff_CheckedChanged);
            // 
            // SenorPixelCorrection
            // 
            this.SenorPixelCorrection.AutoSize = true;
            this.SenorPixelCorrection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SenorPixelCorrection.Location = new System.Drawing.Point(167, 3);
            this.SenorPixelCorrection.Name = "SenorPixelCorrection";
            this.SenorPixelCorrection.Size = new System.Drawing.Size(41, 19);
            this.SenorPixelCorrection.TabIndex = 4;
            this.SenorPixelCorrection.TabStop = true;
            this.SenorPixelCorrection.Text = "On";
            this.SenorPixelCorrection.UseVisualStyleBackColor = true;
            this.SenorPixelCorrection.CheckedChanged += new System.EventHandler(this.SenorPixelCorrection_CheckedChanged);
            // 
            // lblSenorPixelCorrection
            // 
            this.lblSenorPixelCorrection.AutoSize = true;
            this.lblSenorPixelCorrection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSenorPixelCorrection.Location = new System.Drawing.Point(5, 5);
            this.lblSenorPixelCorrection.Name = "lblSenorPixelCorrection";
            this.lblSenorPixelCorrection.Size = new System.Drawing.Size(93, 15);
            this.lblSenorPixelCorrection.TabIndex = 3;
            this.lblSenorPixelCorrection.Text = "Pixel Correction:";
            this.lblSenorPixelCorrection.Click += new System.EventHandler(this.lblSenorPixelCorrection_Click);
            // 
            // fAdvancedSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 567);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fAdvancedSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Advanced Settings";
            this.pMain.ResumeLayout(false);
            this.gGainAdjusment.ResumeLayout(false);
            this.gGainAdjusment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gain4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gain3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gain2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gain1)).EndInit();
            this.gDefectCorrection.ResumeLayout(false);
            this.gDefectCorrection.PerformLayout();
            this.pFlatFieldCorrection.ResumeLayout(false);
            this.pFlatFieldCorrection.PerformLayout();
            this.pAutoExposure.ResumeLayout(false);
            this.pAutoExposure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.GroupBox gDefectCorrection;
        private System.Windows.Forms.Panel pAutoExposure;
        private System.Windows.Forms.RadioButton rbSenorPixelCorrectionOff;
        private System.Windows.Forms.RadioButton SenorPixelCorrection;
        private System.Windows.Forms.Label lblSenorPixelCorrection;
        private System.Windows.Forms.Label lblCorrectionImageDirectory;
        private System.Windows.Forms.Panel pFlatFieldCorrection;
        private System.Windows.Forms.RadioButton rbFlatFieldCorrectionOff;
        private System.Windows.Forms.RadioButton FlatFieldCorrection;
        private System.Windows.Forms.Label lblFlatFieldCorrection;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.TextBox CorrectionImageDirectory;
        private System.Windows.Forms.GroupBox gGainAdjusment;
        private System.Windows.Forms.Label lblGainValue1;
        private System.Windows.Forms.Label lblGain1;
        private System.Windows.Forms.TrackBar Gain1;
        private System.Windows.Forms.Label lblBand1;
        private System.Windows.Forms.Label lblGainValue4;
        private System.Windows.Forms.Label lblGain4;
        private System.Windows.Forms.TrackBar Gain4;
        private System.Windows.Forms.Label lblBand4;
        private System.Windows.Forms.Label lblGainValue3;
        private System.Windows.Forms.Label lblGain3;
        private System.Windows.Forms.TrackBar Gain3;
        private System.Windows.Forms.Label lblBand3;
        private System.Windows.Forms.Label lblGainValue2;
        private System.Windows.Forms.Label lblGain2;
        private System.Windows.Forms.TrackBar Gain2;
        private System.Windows.Forms.Label lblBand2;
    }
}