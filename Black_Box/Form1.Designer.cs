namespace Black_Box
{
    partial class BlackBox
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChooseVideoDevice = new System.Windows.Forms.ComboBox();
            this.ShowDeltaX = new System.Windows.Forms.Label();
            this.ShowDeltaY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(95, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1276, 751);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // ChooseVideoDevice
            // 
            this.ChooseVideoDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ChooseVideoDevice.FormattingEnabled = true;
            this.ChooseVideoDevice.Location = new System.Drawing.Point(12, 12);
            this.ChooseVideoDevice.Name = "ChooseVideoDevice";
            this.ChooseVideoDevice.Size = new System.Drawing.Size(77, 21);
            this.ChooseVideoDevice.TabIndex = 1;
            // 
            // ShowDeltaX
            // 
            this.ShowDeltaX.AutoSize = true;
            this.ShowDeltaX.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShowDeltaX.Location = new System.Drawing.Point(14, 54);
            this.ShowDeltaX.Name = "ShowDeltaX";
            this.ShowDeltaX.Size = new System.Drawing.Size(0, 13);
            this.ShowDeltaX.TabIndex = 2;
            // 
            // ShowDeltaY
            // 
            this.ShowDeltaY.AutoSize = true;
            this.ShowDeltaY.Location = new System.Drawing.Point(13, 82);
            this.ShowDeltaY.Name = "ShowDeltaY";
            this.ShowDeltaY.Size = new System.Drawing.Size(0, 13);
            this.ShowDeltaY.TabIndex = 3;
            // 
            // BlackBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.ShowDeltaY);
            this.Controls.Add(this.ShowDeltaX);
            this.Controls.Add(this.ChooseVideoDevice);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BlackBox";
            this.ShowIcon = false;
            this.Text = "BlackBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlackBox_FormClosing);
            this.Load += new System.EventHandler(this.BlackBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ChooseVideoDevice;
        private System.Windows.Forms.Label ShowDeltaX;
        private System.Windows.Forms.Label ShowDeltaY;
    }
}

