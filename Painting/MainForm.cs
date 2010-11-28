using System;
using System.Windows.Forms;

namespace Painting
{
	public partial class MainForm : Form
	{
		private readonly FormState maximizer = new FormState();
		private Viewer _imageViewForm;

		public MainForm()
		{
			InitializeComponent();
			FirstTimeLoad();
		}

		private void FirstTimeLoad()
		{
			tbFolder.Text = Properties.Settings.Default.workingDirectory;
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

		private void btnMaximize_Click(object sender, EventArgs e)
		{
			maximizer.Maximize(_imageViewForm);
		}
	}
}
