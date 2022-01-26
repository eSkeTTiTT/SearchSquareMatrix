using System;

namespace Задача
{
    class Program
    {
        public static int SearchMaxSquare(int[][] matrix)
        {
            int max = 0;

            //поменяю 0 на 1 - чтобы было проще считать
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[0].Length; ++j)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][j] = 1;
                    }
                    else
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            //идем справа - налево
            //снизу-вверх
            for (int i = matrix.Length - 2; i > - 1; --i)
            {
                for (int j = matrix[0].Length - 2; j > -1; --j)
                {
                    //
                    if (matrix[i][j] != 0)
                    {
                        matrix[i][j] = Math.Min(Math.Min(matrix[i + 1][j], matrix[i][j + 1]), matrix[i + 1][j + 1]) + 1;

                        //смотрим - больше ли этот максимум
                        if (matrix[i][j] > max)
                        {
                            max = matrix[i][j];
                        }
                    }

                }
            }

            return max;
        }

        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];

            matrix[0] = new int[5] { 0, 0, 0, 0, 0 };
            matrix[1] = new int[5] { 0, 0, 0, 1, 0 };
            matrix[2] = new int[5] { 0, 0, 0, 1, 0 };

            Console.WriteLine(SearchMaxSquare(matrix));
        }
    }
}
