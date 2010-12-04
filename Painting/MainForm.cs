using System;
using System.IO;
using System.Windows.Forms;
using Dolinay;

namespace Painting
{
	public partial class MainForm : Form
	{
		private readonly FormState maximizer = new FormState();
		private Viewer _imageViewForm;
		private ImageManager _imgMan;

		private ImageManager ImageMan
		{
			get
			{
				if (_imgMan == null)
					_imgMan = new ImageManager(tbFolder.Text, (int)nudArchSize.Value);
				return _imgMan;
			}
		}

		public MainForm()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			FirstTimeLoad();

			var detector = new DriveDetector();
			detector.DeviceArrived += FlashInserted;
		}

		private void FlashInserted(object sender, DriveDetectorEventArgs e)
		{
			// Copy files to drive here.
			if (ArchiveManager.CopyArchiveToExternalStorage(ImageMan.ArchDirectory, e.Drive, ImageManager.ImageFileMask))
			{
				var allDone = 
					cbRemoveImagesAfterArchive.Checked
					&& ClearArchiveDirectory()
					&& RemoveBigImages();
			}
			else
			{
				MessageBox.Show(
					"Не удалось скопировать все файлы. Необходимо скопировать их вручную. Возможно, просто не хватило места на диске.",
					"Не удалось скопировать файлы на внешний диск",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
					);

			}
		}

		private bool ClearArchiveDirectory()
		{
			return RemoveImages(ImageMan.ArchDirectory, null);
		}

		private bool RemoveBigImages()
		{
			return RemoveImages(ImageMan.WorkingDirectory, ImageMan.CurrentImage);
		}

		private static bool RemoveImages(string dirPath, string keepFile)
		{
			try
			{
				var dir = new DirectoryInfo(dirPath);
				if (dir.Exists)
				{
					foreach (var f in dir.GetFiles(ImageManager.ImageFileMask))
					{
						if (f.FullName == keepFile)
							continue;
						f.Delete();
					}
				}
				return true;
			}
			catch(Exception ex)
			{
#if DEBUG
				MessageBox.Show(ex.ToString(), "Debug", MessageBoxButtons.OK, MessageBoxIcon.Warning);
#endif
			}
			return false;
		}

		private void FirstTimeLoad()
		{
			tbFolder.Text = Properties.Settings.Default.workingDirectory;
			nudArchSize.Value = Properties.Settings.Default.archSize;
			cbRemoveImagesAfterArchive.Checked = Properties.Settings.Default.removeArchiveAfterCopied;
		}

		private void btnShowImage_Click(object sender, EventArgs e)
		{
			_imageViewForm = new Viewer();
			_imageViewForm.Show();

			ImageMan.Init(_imageViewForm);
			_imageViewForm.DrawAction = ImageMan.Draw;
			ImageMan.StartMonitor();
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
			ImageMan.UpdateImageSize();
		}

		private void nudArchSize_ValueChanged(object sender, EventArgs e)
		{
			ImageMan.ArchSize = (int)nudArchSize.Value;
		}
	}
}
