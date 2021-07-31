using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using MessagingToolkit.Barcode;



namespace WinFormCharpWebCam
{
	//Design by Pongsakorn Poosankam
	public partial class mainWinForm : Form
	{
		public mainWinForm()
		{
			InitializeComponent();
		}
		WebCam webcam;
		private void mainWinForm_Load(object sender, EventArgs e)
		{
			webcam = new WebCam();
			webcam.InitializeWebCam(ref imgVideo);
		}

		private void bntStart_Click(object sender, EventArgs e)
		{
			webcam.Start();
		}

		private void bntCapture_Click(object sender, EventArgs e)
		{
			try {
				var Scanner = new BarcodeDecoder();
				Result result = Scanner.Decode(new Bitmap(imgVideo.Image));
				MessageBox.Show(result.Text);
			} catch (Exception re) {
				MessageBox.Show(re.ToString());
			}
            
		}

		private void bntVideoFormat_Click(object sender, EventArgs e)
		{
			webcam.ResolutionSetting();
		}

		private void bntVideoSource_Click(object sender, EventArgs e)
		{
			webcam.AdvanceSetting();
		}

        
	}
}
