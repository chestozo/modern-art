using System;
using System.Windows.Forms;

namespace Painting
{
	public partial class MainForm : Form
	{
		private readonly FormState maximizer = new FormState();
		private Viewer _imageViewForm;
		private ImageManager _imgMan;

		public MainForm()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			FirstTimeLoad();
		}

		private void FirstTimeLoad()
		{
			tbFolder.Text = Properties.Settings.Default.workingDirectory;
		}

		private void btnShowImage_Click(object sender, EventArgs e)
		{
			_imgMan = new ImageManager(tbFolder.Text, (int)nudArchSize.Value);

			_imageViewForm = new Viewer();
			_imageViewForm.Show();

			_imgMan.Init(_imageViewForm);
			_imageViewForm.DrawAction = _imgMan.Draw;
			_imgMan.StartMonitor();
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

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			maximizer.Restore(_imageViewForm);
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			_imgMan.UpdateImageSize();
		}

		private void nudArchSize_ValueChanged(object sender, EventArgs e)
		{
			_imgMan.ArchSize = (int)nudArchSize.Value;
		}
	}
}
