namespace WinFormCharpWebCam
{
    //Design by Pongsakorn Poosankam
    partial class mainWinForm
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
        	this.imgVideo = new System.Windows.Forms.PictureBox();
        	this.bntStart = new System.Windows.Forms.Button();
        	this.bntCapture = new System.Windows.Forms.Button();
        	this.bntVideoFormat = new System.Windows.Forms.Button();
        	this.bntVideoSource = new System.Windows.Forms.Button();
        	((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// imgVideo
        	// 
        	this.imgVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.imgVideo.Location = new System.Drawing.Point(12, 12);
        	this.imgVideo.Name = "imgVideo";
        	this.imgVideo.Size = new System.Drawing.Size(336, 283);
        	this.imgVideo.TabIndex = 0;
        	this.imgVideo.TabStop = false;
        	// 
        	// bntStart
        	// 
        	this.bntStart.Location = new System.Drawing.Point(12, 301);
        	this.bntStart.Name = "bntStart";
        	this.bntStart.Size = new System.Drawing.Size(75, 23);
        	this.bntStart.TabIndex = 2;
        	this.bntStart.Text = "Start";
        	this.bntStart.UseVisualStyleBackColor = true;
        	this.bntStart.Click += new System.EventHandler(this.bntStart_Click);
        	// 
        	// bntCapture
        	// 
        	this.bntCapture.Location = new System.Drawing.Point(263, 301);
        	this.bntCapture.Name = "bntCapture";
        	this.bntCapture.Size = new System.Drawing.Size(85, 23);
        	this.bntCapture.TabIndex = 5;
        	this.bntCapture.Text = "Get QCode";
        	this.bntCapture.UseVisualStyleBackColor = true;
        	this.bntCapture.Click += new System.EventHandler(this.bntCapture_Click);
        	// 
        	// bntVideoFormat
        	// 
        	this.bntVideoFormat.Location = new System.Drawing.Point(110, 301);
        	this.bntVideoFormat.Name = "bntVideoFormat";
        	this.bntVideoFormat.Size = new System.Drawing.Size(147, 23);
        	this.bntVideoFormat.TabIndex = 7;
        	this.bntVideoFormat.Text = "Video Format";
        	this.bntVideoFormat.UseVisualStyleBackColor = true;
        	this.bntVideoFormat.Click += new System.EventHandler(this.bntVideoFormat_Click);
        	// 
        	// bntVideoSource
        	// 
        	this.bntVideoSource.Location = new System.Drawing.Point(12, 330);
        	this.bntVideoSource.Name = "bntVideoSource";
        	this.bntVideoSource.Size = new System.Drawing.Size(336, 23);
        	this.bntVideoSource.TabIndex = 8;
        	this.bntVideoSource.Text = "Video Source";
        	this.bntVideoSource.UseVisualStyleBackColor = true;
        	this.bntVideoSource.Click += new System.EventHandler(this.bntVideoSource_Click);
        	// 
        	// mainWinForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(363, 362);
        	this.Controls.Add(this.bntVideoSource);
        	this.Controls.Add(this.bntVideoFormat);
        	this.Controls.Add(this.bntCapture);
        	this.Controls.Add(this.bntStart);
        	this.Controls.Add(this.imgVideo);
        	this.Name = "mainWinForm";
        	this.Text = "QCode";
        	this.Load += new System.EventHandler(this.mainWinForm_Load);
        	((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.Button bntStart;
        private System.Windows.Forms.Button bntCapture;
        private System.Windows.Forms.Button bntVideoFormat;
        private System.Windows.Forms.Button bntVideoSource;
    }
}

