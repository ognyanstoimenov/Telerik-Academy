using System;

class Program
{
    static void Main()
    {
        int P = int.Parse(Console.ReadLine());
        string binaryP = Convert.ToString(P, 2);
        int M = int.Parse(Console.ReadLine());
        int[] N = new int[M];
        string[] binaryN = new string[M];
        //string[] tempBinaryN = new string[M];
        // int binaryNPosition = binaryP.Length - 1;
        int z1, y1;

        for (int i = 0; i < M; i++)
        {
            N[i] = int.Parse(Console.ReadLine());
            binaryN[i] = Convert.ToString(N[i], 2);
            //tempBinaryN[i] = binaryN[i];
            Console.WriteLine(binaryN[i]);
        }

        for (int i = 0; i < M; i++)
        {
            for (int y = binaryP.Length - 1; y > 0; y--)
            {
                for (int z = binaryN[i].Length - 1; z > 0; z--)
                {
                    if (binaryP[z] == binaryN[i][y])
                    {
                        y--;
                    }
                }
            }
        }

    }
}

    }
}

