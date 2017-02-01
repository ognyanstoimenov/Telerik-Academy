
namespace Matrix

{
	using System;

	class Matrix<T>
	{
		private T[,] matrix;

		public Matrix(int rows, int cols)
		{
			this.Rows = rows;
			this.Cols = cols;

			matrix = new T[Rows, Cols];
		}


		public int Cols { get; }
		public int Rows { get; }

		public T this[int row, int col]
		{
			get { return matrix[row, col]; }
			set { matrix[row, col] = value; }
		}

		public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
		{
			if (first.Rows != second.Rows || first.Cols != second.Cols)
			{
				throw new ArgumentException("Matrices not the same length");
			}

			Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);

			for (int row = 0; row < result.Rows; row++)
			{
				for (int col = 0; col < result.Cols; col++)
				{
					result[row, col] = (dynamic)first[row, col] + second[row, col];
				}
			}

			return result;
		}

		public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
		{
			if (first.Rows != second.Rows || first.Cols != second.Cols)
			{
				throw new ArgumentException("Matrices not the same length");
			}

			Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);

			for (int row = 0; row < result.Rows; row++)
			{
				for (int col = 0; col < result.Cols; col++)
				{
					result[row, col] = (dynamic)first[row, col] - second[row, col];
				}
			}

			return result;
		}

		public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
		{
			if (first.Cols != second.Rows)
			{
				throw new ArgumentException("Matrices not the same length");
			}

			Matrix<T> result = new Matrix<T>(first.Rows, second.Cols);

			for (int row = 0; row < result.Rows; row++)
			{
				for (int col = 0; col < result.Cols; col++)
				{
					for (int secondRow = 0; secondRow < result.Cols; secondRow++)
					{
						result[row, col] = (dynamic)first[row, col] * second[secondRow, col];
					}
				}
			}

			return result;
		}

		public static bool operator true(Matrix<T> matrix)
		{
			for (int row = 0; row < matrix.Rows; row++)
			{
				for (int col = 0; col < matrix.Cols; col++)
				{
					if (matrix[row, col].Equals(default(T)))
					{
						return false;
					}
				}
			}

			return true;
		}

		public static bool operator false(Matrix<T> matrix)
		{
			for (int row = 0; row < matrix.Rows; row++)
			{
				for (int col = 0; col < matrix.Cols; col++)
				{
					if (matrix[row, col].Equals(default(T)))
					{
						return false;
					}
				}
			}

			return true;
		}

		public override string ToString()
		{
			string rows = string.Empty;

			for (int row = 0; row < this.Rows; row++)
			{
				for (int col = 0; col < this.Cols; col++)
				{
					rows += string.Format("{0,5}", this.matrix[row, col]);
				}

				rows += Environment.NewLine;
			}

			return rows;
		}
	}

}

