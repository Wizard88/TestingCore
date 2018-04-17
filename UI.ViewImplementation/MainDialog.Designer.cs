namespace UI.ViewImplementation
{
    partial class MainDialog
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
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblAbout = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.gbCommunication = new System.Windows.Forms.GroupBox();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.lblCalbox = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.cbCalbox = new System.Windows.Forms.ComboBox();
            this.lblMultimeter = new System.Windows.Forms.Label();
            this.cbMultimeter = new System.Windows.Forms.ComboBox();
            this.lblCalibration = new System.Windows.Forms.Label();
            this.btnCalibration = new System.Windows.Forms.Button();
            this.lblJustify = new System.Windows.Forms.Label();
            this.btnJustify = new System.Windows.Forms.Button();
            this.gbCommunication.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHelp
            // 
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHelp.Location = new System.Drawing.Point(395, 271);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(82, 23);
            this.lblHelp.TabIndex = 32;
            this.lblHelp.Text = "Help";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHelp.BackgroundImage = global::UI.ViewImplementation.Properties.Resources.blank;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHelp.Location = new System.Drawing.Point(395, 297);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(82, 71);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAbout.Location = new System.Drawing.Point(483, 271);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(88, 23);
            this.lblAbout.TabIndex = 30;
            this.lblAbout.Text = "About";
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAbout.BackgroundImage = global::UI.ViewImplementation.Properties.Resources.blank;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAbout.Location = new System.Drawing.Point(486, 297);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(82, 71);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSettings.Location = new System.Drawing.Point(443, 84);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(143, 23);
            this.lblSettings.TabIndex = 29;
            this.lblSettings.Text = "Settings";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnSettings.BackgroundImage = global::UI.ViewImplementation.Properties.Resources.settings;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Enabled = false;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(443, 109);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(143, 146);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // gbCommunication
            // 
            this.gbCommunication.BackColor = System.Drawing.Color.Transparent;
            this.gbCommunication.Controls.Add(this.cbDevice);
            this.gbCommunication.Controls.Add(this.lblCalbox);
            this.gbCommunication.Controls.Add(this.lblDevice);
            this.gbCommunication.Controls.Add(this.cbCalbox);
            this.gbCommunication.Controls.Add(this.lblMultimeter);
            this.gbCommunication.Controls.Add(this.cbMultimeter);
            this.gbCommunication.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbCommunication.Location = new System.Drawing.Point(17, 12);
            this.gbCommunication.Name = "gbCommunication";
            this.gbCommunication.Size = new System.Drawing.Size(637, 52);
            this.gbCommunication.TabIndex = 28;
            this.gbCommunication.TabStop = false;
            this.gbCommunication.Text = "Connected devices";
            // 
            // cbDevice
            // 
            this.cbDevice.BackColor = System.Drawing.SystemColors.Window;
            this.cbDevice.DisplayMember = "View";
            this.cbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(82, 19);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(110, 21);
            this.cbDevice.TabIndex = 0;
            this.cbDevice.TabStop = false;
            this.cbDevice.ValueMember = "Value";
            this.cbDevice.SelectionChangeCommitted += new System.EventHandler(this.cbDevice_SelectionChangeCommitted);
            // 
            // lblCalbox
            // 
            this.lblCalbox.AutoSize = true;
            this.lblCalbox.Location = new System.Drawing.Point(434, 22);
            this.lblCalbox.Name = "lblCalbox";
            this.lblCalbox.Size = new System.Drawing.Size(50, 13);
            this.lblCalbox.TabIndex = 9;
            this.lblCalbox.Text = "Calboxes";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(13, 22);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(46, 13);
            this.lblDevice.TabIndex = 7;
            this.lblDevice.Text = "Devices";
            // 
            // cbCalbox
            // 
            this.cbCalbox.DisplayMember = "View";
            this.cbCalbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalbox.FormattingEnabled = true;
            this.cbCalbox.Location = new System.Drawing.Point(507, 19);
            this.cbCalbox.Name = "cbCalbox";
            this.cbCalbox.Size = new System.Drawing.Size(110, 21);
            this.cbCalbox.TabIndex = 2;
            this.cbCalbox.TabStop = false;
            this.cbCalbox.ValueMember = "Value";
            this.cbCalbox.SelectionChangeCommitted += new System.EventHandler(this.cbCalbox_SelectionChangeCommitted);
            // 
            // lblMultimeter
            // 
            this.lblMultimeter.AutoSize = true;
            this.lblMultimeter.Location = new System.Drawing.Point(215, 22);
            this.lblMultimeter.Name = "lblMultimeter";
            this.lblMultimeter.Size = new System.Drawing.Size(63, 13);
            this.lblMultimeter.TabIndex = 8;
            this.lblMultimeter.Text = "Multimeters ";
            // 
            // cbMultimeter
            // 
            this.cbMultimeter.DisplayMember = "View";
            this.cbMultimeter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMultimeter.FormattingEnabled = true;
            this.cbMultimeter.Location = new System.Drawing.Point(301, 19);
            this.cbMultimeter.Name = "cbMultimeter";
            this.cbMultimeter.Size = new System.Drawing.Size(110, 21);
            this.cbMultimeter.TabIndex = 1;
            this.cbMultimeter.TabStop = false;
            this.cbMultimeter.ValueMember = "Value";
            this.cbMultimeter.SelectionChangeCommitted += new System.EventHandler(this.cbMultimeter_SelectionChangeCommitted);
            // 
            // lblCalibration
            // 
            this.lblCalibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCalibration.Location = new System.Drawing.Point(264, 86);
            this.lblCalibration.Name = "lblCalibration";
            this.lblCalibration.Size = new System.Drawing.Size(143, 20);
            this.lblCalibration.TabIndex = 27;
            this.lblCalibration.Text = "Calibration";
            this.lblCalibration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalibration
            // 
            this.btnCalibration.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalibration.BackgroundImage = global::UI.ViewImplementation.Properties.Resources.test;
            this.btnCalibration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalibration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalibration.Enabled = false;
            this.btnCalibration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCalibration.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalibration.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalibration.Location = new System.Drawing.Point(264, 109);
            this.btnCalibration.Name = "btnCalibration";
            this.btnCalibration.Size = new System.Drawing.Size(143, 146);
            this.btnCalibration.TabIndex = 1;
            this.btnCalibration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalibration.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalibration.UseVisualStyleBackColor = false;
            this.btnCalibration.Click += new System.EventHandler(this.btnCalibration_Click);
            // 
            // lblJustify
            // 
            this.lblJustify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJustify.Location = new System.Drawing.Point(85, 83);
            this.lblJustify.Name = "lblJustify";
            this.lblJustify.Size = new System.Drawing.Size(143, 23);
            this.lblJustify.TabIndex = 26;
            this.lblJustify.Text = "Justify";
            this.lblJustify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJustify
            // 
            this.btnJustify.BackColor = System.Drawing.SystemColors.Control;
            this.btnJustify.BackgroundImage = global::UI.ViewImplementation.Properties.Resources.justify;
            this.btnJustify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnJustify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJustify.Enabled = false;
            this.btnJustify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJustify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJustify.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnJustify.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJustify.Location = new System.Drawing.Point(85, 109);
            this.btnJustify.Name = "btnJustify";
            this.btnJustify.Size = new System.Drawing.Size(143, 146);
            this.btnJustify.TabIndex = 0;
            this.btnJustify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJustify.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnJustify.UseVisualStyleBackColor = false;
            this.btnJustify.Click += new System.EventHandler(this.btnJustify_Click);
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(670, 380);
            this.ControlBox = false;
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.gbCommunication);
            this.Controls.Add(this.lblCalibration);
            this.Controls.Add(this.btnCalibration);
            this.Controls.Add(this.lblJustify);
            this.Controls.Add(this.btnJustify);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.gbCommunication.ResumeLayout(false);
            this.gbCommunication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.GroupBox gbCommunication;
        private System.Windows.Forms.ComboBox cbDevice;
        private System.Windows.Forms.Label lblCalbox;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.ComboBox cbCalbox;
        private System.Windows.Forms.Label lblMultimeter;
        private System.Windows.Forms.ComboBox cbMultimeter;
        private System.Windows.Forms.Label lblCalibration;
        private System.Windows.Forms.Button btnCalibration;
        private System.Windows.Forms.Label lblJustify;
        private System.Windows.Forms.Button btnJustify;
    }
}