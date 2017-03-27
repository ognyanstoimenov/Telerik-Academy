using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
	class Program
	{
		static void PrintMatrix(char[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write("{0,00}", matrix[i, j]);
				}
				Console.WriteLine();
			}
		}
		static void FillMatrix(char[,] matrix, int rows)
		{
			for (int i = 0; i < rows; i++)
			{
				char[] currentLine = Console.ReadLine().ToCharArray();
				for (int j = 0; j < currentLine.Length; j++)
				{
					matrix[i, j] = currentLine[j];
				}
			}
		}
		static void Main()
		{
			string[] dimensions = Console.ReadLine().Split('x');
			int rows = int.Parse(dimensions[0]);
			int cols = int.Parse(dimensions[1]);
			char[,] field = new char[rows, cols];
			FillMatrix(field, rows);
			int indexOfEntrance = new int();
			for (int i = 0; i < cols; i++)
			{
				if (field[0, i] == 'e')
				{
					indexOfEntrance = i;
				}
			}
			int[] currentPos = { 0, indexOfEntrance };
			int length = 3;
			string[] direction = Console.ReadLine().Split(',');
			bool rockHit = false;
			bool outOfLength = false;
			bool outOfRange = false;
			bool escaped = false;
			int[] targetDirection = new int[2];
			for (int i = 0; i < direction.Length; i++)
			{
				if ((i + 1) % 5 == 0) length--;
				if (direction[i] == "s")
				{
					targetDirection[0] = currentPos[0] + 1;
					targetDirection[1] = currentPos[1];
				}
				else if (direction[i] == "w")
				{
					targetDirection[0] = currentPos[0] - 1;
					targetDirection[1] = currentPos[1];
				}
				else if (direction[i] == "a")
				{
					targetDirection[0] = currentPos[0];
					targetDirection[1] = currentPos[1] - 1;
				}
				else if (direction[i] == "d")
				{
					targetDirection[0] = currentPos[0];
					targetDirection[1] = currentPos[1]+1;
				}
				if (targetDirection[0] > rows - 1)
				{
					outOfRange = true;
					break;
				}
				if (targetDirection[1] > cols - 1) targetDirection[1] = 0;
				if (targetDirection[1] < 0) targetDirection[1] = cols - 1;
				if (field[targetDirection[0], targetDirection[1]] == '@')
				{
					length++;
					field[targetDirection[0], targetDirection[1]] = '-';
				}
				if (field[targetDirection[0], targetDirection[1]] == '%')
				{
					rockHit = true;
					break;
				}
				if (field[targetDirection[0],targetDirection[1]] == 'e')
				{
					escaped = true;
					break;
				}
				currentPos[0] = targetDirection[0];
				currentPos[1] = targetDirection[1];
				if (length == 0)
				{
					outOfLength = true;
					break;
				}
			}

			if(rockHit == true)
			{
				Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]",targetDirection[0],targetDirection[1]);
			}
			else if(outOfLength == true)
			{
				Console.WriteLine("Sneaky is going to starve at [{0},{1}]", targetDirection[0], targetDirection[1]);
			}
			else if (escaped == true)
			{
				Console.WriteLine("Sneaky is going to get out with length {0}",length);
			}
			else if(outOfRange == true)
			{
				Console.WriteLine("Sneaky is going to be lost into the depths with length {0}",length);
			}
			else
			{
				Console.WriteLine("Sneaky is going to be stuck in the den at [{0},{1}]",currentPos[0],currentPos[1]);
			}

		}
	}
}
