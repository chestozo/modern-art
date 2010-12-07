using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Timer=System.Windows.Forms.Timer;

namespace Painting
{
	public class ImageManager
	{
		private const int _updateInterval = 300; // milliseconds
		
		private readonly string _directory;
		private readonly string _archDirectory;
		private int _archImageSize; //px
		private readonly Timer _tick;
		private Form _form;
		
		private FileInfo _currentImage;

		public const string ImageFileMask = "*.jpg";
		
		public ImageManager(string directory, int archImageSize)
		{
			_directory = directory;
			_archDirectory = Path.Combine(_directory, "archive");
			_archImageSize = archImageSize;
			_tick = new Timer { Interval = _updateInterval };
		}

		public int ArchSize
		{
			get { return _archImageSize; }
			set { _archImageSize = value; }
		}

		public string ArchDirectory
		{
			get { return _archDirectory; }
		}

		public string WorkingDirectory
		{
			get { return _directory; }
		}

		public string CurrentImage
		{
			get { return _currentImage.FullName; }
		}

		// Хранит текущую отображаемую картинку.
		private Image _image;

		public void Init(Form form)
		{
			_form = form;

			InitEmptyImage();
			ShowMalevich();

			_tick.Tick += _tick_Tick;

			_form.Resize += delegate { UpdateImageSize(); };
		}

		public void UpdateImageSize()
		{
			if (_image != null)
			{
				using (_image)
				{
					// Finalize image
				}
			}
			InitEmptyImage();
			DrawImage(_currentImage);
			_form.Invalidate();
		}

		public void Draw(Graphics gr)
		{
			gr.DrawImage(_image, 0, 0);
		}

		private void _tick_Tick(object sender, EventArgs e)
		{
			UpdatePainting();
		}

		public void StartMonitor()
		{
			_tick.Enabled = true;
			_tick.Start();
		}

		public void StopMonitor()
		{
			_tick.Stop();
			_tick.Enabled = false;
		}

		private void UpdatePainting()
		{
			var mostRecent = GetMostRecentImage();
			if (mostRecent != null && (_currentImage == null || _currentImage.FullName != mostRecent.FullName))
			{
				DrawImage(mostRecent);
				_currentImage = mostRecent;
				_form.Invalidate();

				// Save image copy asynchronously.
				var thread = new Thread(() => ArchiveManager.ArchiveImage(_currentImage, _archDirectory, _archImageSize));
				thread.Start();
			}
		}

		private void ShowMalevich()
		{
			using (var gr = Graphics.FromImage(_image))
			{
				ShowMalevich(gr);
			}
		}

		private void ShowMalevich(Graphics gr)
		{
			gr.FillRectangle(Brushes.Black, 0, 0, _image.Width, _image.Height);
		}

		private void DrawImage(FileInfo imageFile)
		{
			try
			{
				if (imageFile == null)
					return;

				var fileName = imageFile.FullName;
				while (FileHelper.IsFileInUse(fileName))
					Thread.Sleep(200);

				// Here we can get OutOfMemoryException for example when image is corrupted.
				using (var image = Image.FromFile(fileName))
				{
					//Scale
					var sw = (double) image.Width/_image.Width;
					var sh = (double) image.Height/_image.Height;
					var s = Math.Max(sw, sh);

					//Calculate point
					var w = image.Width/s;
					var h = image.Height/s;

					var x = (_image.Width - w)/2;
					var y = (_image.Height - h)/2;

					//Draw 
					using (var g = Graphics.FromImage(_image))
					{
						ShowMalevich(g);
						g.Flush();
						g.DrawImage(image, (int) x, (int) y, (int) w, (int) h);
					}
				}
			}
			catch
			{
			}
		}

		private FileInfo GetMostRecentImage()
		{
			FileInfo mostRecent = null;
			foreach (var fileName in Directory.GetFiles(_directory, ImageFileMask))
			{
				var fi = new FileInfo(Path.Combine(_directory, fileName));
				if (mostRecent == null || fi.CreationTime > mostRecent.CreationTime)
					mostRecent = fi;
			}
			return mostRecent;
		}

		private void InitEmptyImage()
		{
			_image = new Bitmap(_form.Bounds.Width, _form.Bounds.Height);
		}
	}
}
