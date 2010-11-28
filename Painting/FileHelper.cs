using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using Microsoft.Win32.SafeHandles;

namespace Painting
{
	public static class FileHelper
	{
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern SafeFileHandle CreateFile(string lpFileName,
		FileSystemRights dwDesiredAccess, FileShare dwShareMode, IntPtr
		securityAttrs, FileMode dwCreationDisposition, FileOptions
		dwFlagsAndAttributes, IntPtr hTemplateFile);

		private const int ERROR_SHARING_VIOLATION = 32;

		public static bool IsFileInUse(string fileName)
		{
			SafeFileHandle fileHandle = null;
			try
			{
				fileHandle = CreateFile(
					fileName,
					FileSystemRights.Modify,
					FileShare.Write,
					IntPtr.Zero,
					FileMode.OpenOrCreate,
					FileOptions.None,
					IntPtr.Zero
					);

				if (fileHandle.IsInvalid)
				{
					if (Marshal.GetLastWin32Error() == ERROR_SHARING_VIOLATION)
					{
						return true;
					}
				}
			}
			catch
			{
				return true; 
			}
			finally
			{
				if (fileHandle != null)
					fileHandle.Close();
			}

			return false;
		}

	}
}
