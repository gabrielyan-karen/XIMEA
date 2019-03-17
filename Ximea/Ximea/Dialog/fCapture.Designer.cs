namespace Camera.Dialog
{
    partial class fCapture
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCapture));
            this.pFilePath = new System.Windows.Forms.Panel();
            this.btnAdvancedSettings = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.gCameraSettings = new System.Windows.Forms.GroupBox();
            this.pAutoExposure = new System.Windows.Forms.Panel();
            this.cbImageDataType = new System.Windows.Forms.ComboBox();
            this.lblImageDataType = new System.Windows.Forms.Label();
            this.cbNumberOfBands = new System.Windows.Forms.ComboBox();
            this.lblNumberOfBands = new System.Windows.Forms.Label();
            this.nAutoExposure = new System.Windows.Forms.NumericUpDown();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.lblAutoExposure = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.pDetectedCameras = new System.Windows.Forms.Panel();
            this.lblDetectedCameras = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pFilePath.SuspendLayout();
            this.gCameraSettings.SuspendLayout();
            this.pAutoExposure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoExposure)).BeginInit();
            this.pDetectedCameras.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pFilePath
            // 
            this.pFilePath.BackColor = System.Drawing.SystemColors.Window;
            this.pFilePath.Controls.Add(this.btnAdvancedSettings);
            this.pFilePath.Controls.Add(this.btnPhoto);
            this.pFilePath.Controls.Add(this.btnHelp);
            this.pFilePath.Controls.Add(this.gCameraSettings);
            this.pFilePath.Controls.Add(this.lblFilePath);
            this.pFilePath.Controls.Add(this.btnFilePath);
            this.pFilePath.Controls.Add(this.txtFilePath);
            this.pFilePath.Location = new System.Drawing.Point(12, 49);
            this.pFilePath.Name = "pFilePath";
            this.pFilePath.Size = new System.Drawing.Size(550, 262);
            this.pFilePath.TabIndex = 3;
            // 
            // btnAdvancedSettings
            // 
            this.btnAdvancedSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdvancedSettings.Location = new System.Drawing.Point(430, 227);
            this.btnAdvancedSettings.Name = "btnAdvancedSettings";
            this.btnAdvancedSettings.Size = new System.Drawing.Size(105, 23);
            this.btnAdvancedSettings.TabIndex = 9;
            this.btnAdvancedSettings.Text = "Advanced Settings";
            this.btnAdvancedSettings.UseVisualStyleBackColor = true;
            this.btnAdvancedSettings.Click += new System.EventHandler(this.btnAdvancedSettings_Click);
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(176)))), ((int)(((byte)(90)))));
            this.btnPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPhoto.ForeColor = System.Drawing.Color.White;
            this.btnPhoto.Location = new System.Drawing.Point(224, 227);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(100, 25);
            this.btnPhoto.TabIndex = 8;
            this.btnPhoto.Text = "PHOTO";
            this.btnPhoto.UseVisualStyleBackColor = false;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHelp.Location = new System.Drawing.Point(15, 228);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // gCameraSettings
            // 
            this.gCameraSettings.Controls.Add(this.pAutoExposure);
            this.gCameraSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gCameraSettings.Location = new System.Drawing.Point(15, 57);
            this.gCameraSettings.Name = "gCameraSettings";
            this.gCameraSettings.Size = new System.Drawing.Size(520, 164);
            this.gCameraSettings.TabIndex = 6;
            this.gCameraSettings.TabStop = false;
            this.gCameraSettings.Text = "Camera Settings";
            // 
            // pAutoExposure
            // 
            this.pAutoExposure.Controls.Add(this.cbImageDataType);
            this.pAutoExposure.Controls.Add(this.lblImageDataType);
            this.pAutoExposure.Controls.Add(this.cbNumberOfBands);
            this.pAutoExposure.Controls.Add(this.lblNumberOfBands);
            this.pAutoExposure.Controls.Add(this.nAutoExposure);
            this.pAutoExposure.Controls.Add(this.rbManual);
            this.pAutoExposure.Controls.Add(this.rbAuto);
            this.pAutoExposure.Controls.Add(this.lblAutoExposure);
            this.pAutoExposure.Location = new System.Drawing.Point(42, 35);
            this.pAutoExposure.Name = "pAutoExposure";
            this.pAutoExposure.Size = new System.Drawing.Size(420, 95);
            this.pAutoExposure.TabIndex = 3;
            // 
            // cbImageDataType
            // 
            this.cbImageDataType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbImageDataType.FormattingEnabled = true;
            this.cbImageDataType.Location = new System.Drawing.Point(295, 64);
            this.cbImageDataType.Name = "cbImageDataType";
            this.cbImageDataType.Size = new System.Drawing.Size(121, 23);
            this.cbImageDataType.TabIndex = 11;
            this.cbImageDataType.SelectionChangeCommitted += new System.EventHandler(this.cbImageDataType_SelectionChangeCommitted);
            // 
            // lblImageDataType
            // 
            this.lblImageDataType.AutoSize = true;
            this.lblImageDataType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblImageDataType.Location = new System.Drawing.Point(266, 46);
            this.lblImageDataType.Name = "lblImageDataType";
            this.lblImageDataType.Size = new System.Drawing.Size(96, 15);
            this.lblImageDataType.TabIndex = 10;
            this.lblImageDataType.Text = "Image Data type:";
            // 
            // cbNumberOfBands
            // 
            this.cbNumberOfBands.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNumberOfBands.FormattingEnabled = true;
            this.cbNumberOfBands.Location = new System.Drawing.Point(295, 21);
            this.cbNumberOfBands.Name = "cbNumberOfBands";
            this.cbNumberOfBands.Size = new System.Drawing.Size(121, 23);
            this.cbNumberOfBands.TabIndex = 9;
            this.cbNumberOfBands.SelectionChangeCommitted += new System.EventHandler(this.cbNumberOfBands_SelectionChangeCommitted);
            this.cbNumberOfBands.BindingContextChanged += new System.EventHandler(this.cbNumberOfBands_BindingContextChanged);
            // 
            // lblNumberOfBands
            // 
            this.lblNumberOfBands.AutoSize = true;
            this.lblNumberOfBands.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfBands.Location = new System.Drawing.Point(266, 5);
            this.lblNumberOfBands.Name = "lblNumberOfBands";
            this.lblNumberOfBands.Size = new System.Drawing.Size(103, 15);
            this.lblNumberOfBands.TabIndex = 8;
            this.lblNumberOfBands.Text = "Number of bands:";
            // 
            // nAutoExposure
            // 
            this.nAutoExposure.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nAutoExposure.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nAutoExposure.Location = new System.Drawing.Point(37, 64);
            this.nAutoExposure.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nAutoExposure.Name = "nAutoExposure";
            this.nAutoExposure.Size = new System.Drawing.Size(120, 23);
            this.nAutoExposure.TabIndex = 6;
            this.nAutoExposure.ValueChanged += new System.EventHandler(this.nAutoExposure_ValueChanged);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbManual.Location = new System.Drawing.Point(37, 42);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(88, 19);
            this.rbManual.TabIndex = 5;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual (μs)";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbAuto.Location = new System.Drawing.Point(37, 21);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(51, 19);
            this.rbAuto.TabIndex = 4;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Auto";
            this.rbAuto.UseVisualStyleBackColor = true;
            this.rbAuto.CheckedChanged += new System.EventHandler(this.rbAuto_CheckedChanged);
            // 
            // lblAutoExposure
            // 
            this.lblAutoExposure.AutoSize = true;
            this.lblAutoExposure.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAutoExposure.Location = new System.Drawing.Point(5, 5);
            this.lblAutoExposure.Name = "lblAutoExposure";
            this.lblAutoExposure.Size = new System.Drawing.Size(91, 15);
            this.lblAutoExposure.TabIndex = 3;
            this.lblAutoExposure.Text = "Exposure mode:";
            this.lblAutoExposure.Click += new System.EventHandler(this.lblAutoExposure_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilePath.Location = new System.Drawing.Point(12, 13);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(83, 15);
            this.lblFilePath.TabIndex = 5;
            this.lblFilePath.Text = "Save Location:";
            // 
            // btnFilePath
            // 
            this.btnFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilePath.Location = new System.Drawing.Point(460, 30);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(75, 25);
            this.btnFilePath.TabIndex = 4;
            this.btnFilePath.Text = "&Browse...";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilePath.Location = new System.Drawing.Point(15, 31);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(439, 23);
            this.txtFilePath.TabIndex = 3;
            // 
            // pDetectedCameras
            // 
            this.pDetectedCameras.BackColor = System.Drawing.SystemColors.Window;
            this.pDetectedCameras.Controls.Add(this.lblDetectedCameras);
            this.pDetectedCameras.Location = new System.Drawing.Point(12, 13);
            this.pDetectedCameras.Name = "pDetectedCameras";
            this.pDetectedCameras.Size = new System.Drawing.Size(550, 30);
            this.pDetectedCameras.TabIndex = 4;
            // 
            // lblDetectedCameras
            // 
            this.lblDetectedCameras.AutoSize = true;
            this.lblDetectedCameras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetectedCameras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(176)))), ((int)(((byte)(90)))));
            this.lblDetectedCameras.Location = new System.Drawing.Point(179, 8);
            this.lblDetectedCameras.Name = "lblDetectedCameras";
            this.lblDetectedCameras.Size = new System.Drawing.Size(0, 15);
            this.lblDetectedCameras.TabIndex = 6;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Camera Cameras";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 324);
            this.Controls.Add(this.pDetectedCameras);
            this.Controls.Add(this.pFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fCapture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera - Capture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fCapture_FormClosing);
            this.Load += new System.EventHandler(this.fCapture_Load);
            this.Shown += new System.EventHandler(this.fCapture_Shown);
            this.Resize += new System.EventHandler(this.fCapture_Resize);
            this.pFilePath.ResumeLayout(false);
            this.pFilePath.PerformLayout();
            this.gCameraSettings.ResumeLayout(false);
            this.pAutoExposure.ResumeLayout(false);
            this.pAutoExposure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAutoExposure)).EndInit();
            this.pDetectedCameras.ResumeLayout(false);
            this.pDetectedCameras.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pFilePath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Panel pDetectedCameras;
        private System.Windows.Forms.Label lblDetectedCameras;
        private System.Windows.Forms.GroupBox gCameraSettings;
        private System.Windows.Forms.Panel pAutoExposure;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.Label lblAutoExposure;
        private System.Windows.Forms.NumericUpDown nAutoExposure;
        private System.Windows.Forms.ComboBox cbImageDataType;
        private System.Windows.Forms.Label lblImageDataType;
        private System.Windows.Forms.ComboBox cbNumberOfBands;
        private System.Windows.Forms.Label lblNumberOfBands;
        private System.Windows.Forms.Button btnAdvancedSettings;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}