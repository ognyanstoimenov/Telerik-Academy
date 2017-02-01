namespace Matrix
{
	class Program
	{
		static void Main(string[] args)
		{
			Matrix<int> A = new Matrix<int>(4, 3);
			Matrix<int> B = new Matrix<int>(4, 3);
			Matrix<int> plus = A + B;
			Matrix<int> minus = A - B;
			Matrix<int> product = A * B;
		}
	}
}
