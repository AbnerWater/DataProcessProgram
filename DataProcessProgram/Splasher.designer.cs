namespace DataProcessProgram
{
    partial class Splasher
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
            this.splasherStatus = new System.Windows.Forms.Label();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labProgramName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // splasherStatus
            // 
            this.splasherStatus.AutoSize = true;
            this.splasherStatus.BackColor = System.Drawing.Color.Transparent;
            this.splasherStatus.Font = new System.Drawing.Font("黑体", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.splasherStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.splasherStatus.Location = new System.Drawing.Point(822, 513);
            this.splasherStatus.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.splasherStatus.Name = "splasherStatus";
            this.splasherStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splasherStatus.Size = new System.Drawing.Size(111, 43);
            this.splasherStatus.TabIndex = 1;
            this.splasherStatus.Text = "this";
            this.splasherStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pboxLogo
            // 
            this.pboxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxLogo.Image = global::DataProcessProgram.Properties.Resources.xjtu_32;
            this.pboxLogo.Location = new System.Drawing.Point(534, 20);
            this.pboxLogo.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(399, 126);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 4;
            this.pboxLogo.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 563);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(961, 22);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 5;
            // 
            // labProgramName
            // 
            this.labProgramName.BackColor = System.Drawing.Color.Transparent;
            this.labProgramName.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProgramName.ForeColor = System.Drawing.Color.Black;
            this.labProgramName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labProgramName.Location = new System.Drawing.Point(83, 153);
            this.labProgramName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labProgramName.Name = "labProgramName";
            this.labProgramName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labProgramName.Size = new System.Drawing.Size(862, 190);
            this.labProgramName.TabIndex = 6;
            this.labProgramName.Text = "纳米孔测序软件";
            this.labProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Splasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(961, 585);
            this.ControlBox = false;
            this.Controls.Add(this.labProgramName);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pboxLogo);
            this.Controls.Add(this.splasherStatus);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Splasher";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splasher";
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label splasherStatus;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labProgramName;
    }
}