using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Painting
{
	public class ImageManager
	{
		private string _folder;
		private Form _form;
		private Timer _tick;
		private FileInfo _currentImage;

		// Хранит текущую отображаемую картинку.
		private Image _image;

		public void Init(string folder, Form form)
		{
			_form = form;
			_folder = folder;

			InitEmptyImage();
			ShowMalevich();

			_tick = new Timer { Interval = 300 };
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
				ArchiveImage(_currentImage);
				_currentImage = mostRecent;
				_form.Invalidate();
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
			using (var image = Image.FromFile(imageFile.FullName))
			{
				//Scale
				var sw = (double)image.Width / _image.Width;
				var sh = (double)image.Height / _image.Height;
				var s = Math.Max(sw, sh);

				//Calculate point
				var w = image.Width / s;
				var h = image.Height / s;

				var x = (_image.Width - w) / 2;
				var y = (_image.Height - h) / 2;

				//Draw 
				using (var g = Graphics.FromImage(_image))
				{
					ShowMalevich(g);
					g.DrawImage(image, (int)x, (int)y, (int)w, (int)h);
				}
			}
		}

		private FileInfo GetMostRecentImage()
		{
			FileInfo mostRecent = null;
			foreach (var fileName in Directory.GetFiles(_folder, "*.jpg"))
			{
				var fi = new FileInfo(Path.Combine(_folder, fileName));
				if (mostRecent == null || fi.CreationTime > mostRecent.CreationTime)
					mostRecent = fi;
			}
			return mostRecent;
		}

		private void ArchiveImage(FileInfo file)
		{

		}

		private void InitEmptyImage()
		{
			_image = new Bitmap(_form.Bounds.Width, _form.Bounds.Height);
		}
	}
}
