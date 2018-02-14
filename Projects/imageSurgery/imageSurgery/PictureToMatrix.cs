using System;
using System.Drawing;

namespace imageSurgery
{
	public class PictureToMatrix
	{
		public Color[][] ColorMatrix;
		public int Height;
		public int Width;
		public double[,] GaussianArray;
		public double[,] TempArray;
		public int[,] GaussianImage;
		public Bitmap GI;
		public double TempNewValue;
		public int NewValue;

		public PictureToMatrix(string FilePath)
		{
			this.image = new Bitmap(FilePath);
		}

		public Bitmap image { get; protected set;}

		public Color[][] GetMatrix()
		{
			Height = image.Height;
			Width = image.Width;

			ColorMatrix = new Color[Width][];
			for (int i = 0; i < Width; i++)
			{
				ColorMatrix[i] = new Color[Height];
				for (int j = 0; j < Height; j++)
				{
					ColorMatrix[i][j] = image.GetPixel(i, j);
				}
			}
			return ColorMatrix;
		}

		public void GaussianMatrix()
		{
			GaussianArray = new double[,]{
				{ 1.0/16.0, 2.0/16.0, 1.0/16.0 },
				{ 2.0/16.0, 4.0/16.0, 2.0/16.0 }, 
				{ 1.0/16.0, 2.0/16.0, 1.0/16.0 }};
		}

		public void GaussOperator()
		{
			GaussianMatrix();

			TempArray = new double[,] {
				{ 0, 0, 0 },
				{ 0, 0, 0 },
				{ 0, 0, 0 }};

			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					TempArray[i, j] = ColorMatrix[i][j].R * GaussianArray[i, j];
					TempNewValue += TempArray[i, j];
				}
			}
			NewValue = Convert.ToInt32(TempNewValue);
			TempNewValue = 0;
		}

		public void WholePicture()
		{
			GaussianImage = new int[image.Width, image.Height];

			for (int x = 0; x < image.Width - 2; x++)
			{
				for (int y = 0; y < image.Height - 2; y++)
				{
					GaussOperator();
					GaussianImage[x + 1, y + 1] = NewValue;
				}
			}
		}

		public void SaveImage(string FilePath)
		{
			WholePicture();
			GI.Save(FilePath);
		}

		public void FindNewValue()
		{
			GetMatrix();
			GaussianMatrix();
			//GaussOperator();
			WholePicture();
		}

		public void PrintGaussian()
		{
			FindNewValue();

			Console.WriteLine($"Before: ");
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write($"{ColorMatrix[i][j].R} ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.WriteLine($"Gauss: ");
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write($"{GaussianArray[i,j]} ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.WriteLine($"After: ");
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Console.Write($"{TempArray[i,j]} ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.WriteLine($"New Values:");
			for (int i = 0; i < image.Width; i++)
			{
				for (int j = 0; j < image.Height; j++)
				{
					Console.Write($"{GaussianImage[i,j]} ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
		
		public void PrintAllPixels()
		{ 
			GetMatrix();

			for (int i = 0; i < Width; i++)
			{
				for (int j = 0; j < Height; j++)
				{
					Console.WriteLine($"({i},{j}) - {ColorMatrix[i][j]}");
				}
			}
		}
	}
}

/*
How to save as a .jpg
Move colors
*/