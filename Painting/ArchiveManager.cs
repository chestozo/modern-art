using System;
using System.Drawing;
using System.IO;

namespace Painting
{
	public static class ArchiveManager
	{
		/// <summary>
		/// Creates a copy of the image with maximum side equal to 500px. And saves it to archive directory.
		/// </summary>
		/// <param name="file">Source image file.</param>
		/// <param name="archDirectory">Archive directory.</param>
		/// <param name="imageSize">Max image size value.</param>
		public static void ArchiveImage(FileInfo file, string archDirectory, int imageSize)
		{
			try
			{
				// Create archive directory if not already exists.
				if (!Directory.Exists(archDirectory))
					Directory.CreateDirectory(archDirectory);

				// Here we can get OutOfMemoryException in case image is corrupted.
				using (var image = Image.FromFile(file.FullName))
				{
					//Scale
					var sw = (double) image.Width/imageSize;
					var sh = (double) image.Height/imageSize;
					var s = Math.Max(sw, sh);

					//Calculate point
					var w = image.Width/s;
					var h = image.Height/s;

					//Draw 
					using (var copy = new Bitmap((int) w, (int) h))
					{
						using (var g = Graphics.FromImage(copy))
						{
							g.DrawImage(image, 0, 0, (int) w, (int) h);
						}
						copy.Save(Path.Combine(archDirectory, file.Name));
					}
				}
			}
			catch
			{}
		}

		public static bool CopyArchiveToExternalStorage(string archDirectory, string driveName, string fileNameMask)
		{
			try
			{
				var dir = new DirectoryInfo(archDirectory);
				
				// Create destination directory.
				var destDir = Path.Combine(driveName, string.Format("photo_room_{0:dd.MM.yyyy_HH.mm.ss}", DateTime.Now));
				Directory.CreateDirectory(destDir);
				
				// Copy file by file.
				foreach (var file in dir.GetFiles(fileNameMask))
				{
					file.CopyTo(Path.Combine(destDir, file.Name), true);
				}
			
				// Success.
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
