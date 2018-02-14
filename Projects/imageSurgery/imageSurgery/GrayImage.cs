using System;
using System.Drawing;

namespace imageSurgery
{
	public class GrayImage 
	{
		private Bitmap _bmp;

		public GrayImage(string FilePath)
		{
			_bmp = new Bitmap(FilePath);
		}

		public void Calculating()
		{
			int rgb;
			Color c;

			for (int y = 0; y < _bmp.Height; y++)
			{
				for (int x = 0; x < _bmp.Width; x++)
				{
					c = _bmp.GetPixel(x, y);
					rgb = (int)((c.R + c.G + c.B) / 3);
					_bmp.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
				}
			}
		}

		public void SaveImage(string FilePath)
		{
			Calculating();
			_bmp.Save(FilePath);
		}
	}
}
