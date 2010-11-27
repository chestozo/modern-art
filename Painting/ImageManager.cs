using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Painting
{
	public static class ImageManager
	{
		private static string _folder;
		private static Form _form;
		private static Timer _tick;
		//private static Rectangle _rect;
		private static FileInfo _currentImage;

		// Хранит текущую отображаемую картинку.
		private static Image _image;

		public static void Init(Rectangle rect, string folder, Form form)
		{
			_form = form;
			_folder = folder;
			//_rect = rect;
			_image = new Bitmap(rect.Width, rect.Height);
			ShowMalevich();

			_tick = new Timer { Interval = 1000 };
			_tick.Tick += _tick_Tick;

			_form.Resize += delegate { UpdateImageSize(); };
		}

		private static void UpdateImageSize()
		{
			if (_image != null)
			{
				using (_image)
				{
					// Finalize image
				}
			}
			_image = new Bitmap(_form.Bounds.Width, _form.Bounds.Height);
			DrawImage(_currentImage);
		}

		public static void Draw(Graphics gr)
		{
			gr.DrawImage(_image, 0, 0);
		}

		static void _tick_Tick(object sender, EventArgs e)
		{
			UpdatePainting();
		}

		public static void StartMonitor()
		{
			_tick.Enabled = true;
			_tick.Start();
		}

		public static void StopMonitor()
		{
			_tick.Stop();
			_tick.Enabled = false;
		}

		private static void UpdatePainting()
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

		private static void ShowMalevich()
		{
			using (var gr = Graphics.FromImage(_image))
			{
				ShowMalevich(gr);
			}
		}

		private static void ShowMalevich(Graphics gr)
		{
			gr.FillRectangle(Brushes.Black, 0, 0, _image.Width, _image.Height);
		}

		private static void DrawImage(FileInfo imageFile)
		{
			using (var image = Image.FromFile(imageFile.FullName))
			{
				//Scale
				var sw = (double)image.Width / _image.Width;
				var sh = (double)image.Height / _image.Height;
				var s = Math.Min(sw, sh);

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

		private static FileInfo GetMostRecentImage()
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

		private static void ArchiveImage(FileInfo file)
		{

		}
	}
}
