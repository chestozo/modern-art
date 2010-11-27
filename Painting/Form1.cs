using System;
using System.Windows.Forms;

namespace Painting
{
	public partial class Form1 : Form
	{
		private readonly FormState maximizer = new FormState();
		private Viewer _imageViewForm;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_imageViewForm = new Viewer();
			_imageViewForm.Show();

			ImageManager.Init(_imageViewForm.Bounds, tbFolder.Text, _imageViewForm);
			_imageViewForm.DrawAction = ImageManager.Draw;
			ImageManager.StartMonitor();
		}

		private void selectFolder_Click(object sender, EventArgs e)
		{
			if (folderDialog.ShowDialog() == DialogResult.OK)
			{
				tbFolder.Text = folderDialog.SelectedPath;
			}
		}

		private void cbAutoLoad_CheckedChanged(object sender, EventArgs e)
		{
			if (cbAutoLoad.Checked)
			{
				ImageManager.StartMonitor();
			}
			else
			{
				ImageManager.StopMonitor();
			}
		}

		private void btnMaximize_Click(object sender, EventArgs e)
		{
			maximizer.Maximize(_imageViewForm);
		}
	}
}
