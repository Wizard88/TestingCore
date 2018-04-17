namespace UI.ViewImplementation
{
    partial class MainContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainContainer));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.tslCommunicationFtdi = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslCommunicationFtdiStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslCommunicationMultimeter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslCommunicationMultimeterStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslCommunicationFtdi,
            this.tslCommunicationFtdiStatus,
            this.tslCommunicationMultimeter,
            this.tslCommunicationMultimeterStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 637);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(884, 24);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // tslCommunicationFtdi
            // 
            this.tslCommunicationFtdi.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslCommunicationFtdi.Name = "tslCommunicationFtdi";
            this.tslCommunicationFtdi.Size = new System.Drawing.Size(123, 19);
            this.tslCommunicationFtdi.Text = "FTDI communication";
            // 
            // tslCommunicationFtdiStatus
            // 
            this.tslCommunicationFtdiStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslCommunicationFtdiStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tslCommunicationFtdiStatus.Name = "tslCommunicationFtdiStatus";
            this.tslCommunicationFtdiStatus.Size = new System.Drawing.Size(94, 19);
            this.tslCommunicationFtdiStatus.Text = "Not connected";
            // 
            // tslCommunicationMultimeter
            // 
            this.tslCommunicationMultimeter.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslCommunicationMultimeter.Name = "tslCommunicationMultimeter";
            this.tslCommunicationMultimeter.Size = new System.Drawing.Size(158, 19);
            this.tslCommunicationMultimeter.Text = "Multimeter communication";
            // 
            // tslCommunicationMultimeterStatus
            // 
            this.tslCommunicationMultimeterStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslCommunicationMultimeterStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tslCommunicationMultimeterStatus.Name = "tslCommunicationMultimeterStatus";
            this.tslCommunicationMultimeterStatus.Size = new System.Drawing.Size(94, 19);
            this.tslCommunicationMultimeterStatus.Text = "Not connected";
            // 
            // MainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.statusBar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "MainContainer";
            this.Text = "DV Cal Suite";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel tslCommunicationFtdi;
        private System.Windows.Forms.ToolStripStatusLabel tslCommunicationFtdiStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslCommunicationMultimeter;
        private System.Windows.Forms.ToolStripStatusLabel tslCommunicationMultimeterStatus;
    }
}