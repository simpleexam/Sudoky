namespace Sudoky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] SudokyMap = new int[9,9]
            {
                {0,0,3,0,9,2,0,0,0 },
                {4,0,0,0,3,0,0,1,0 },
                {2,7,0,0,0,0,0,0,0 },
                {0,1,0,3,0,0,0,0,8 },
                {0,5,0,1,0,7,0,3,0 },
                {3,0,0,0,0,8,0,6,0 },
                {0,0,0,0,0,0,0,5,3 },
                {0,3,0,0,8,0,0,0,9 },
                {0,0,0,6,2,0,1,0,0 }
            };

            while (true)
            {
                //вывод шапки
                Console.SetCursorPosition(2, 0);
                for (int i = 0; i< 9; i++)
                {
                    Console.Write($" {i}");
                }

                Console.SetCursorPosition(2, 1);
                for (int i = 0; i< 9; i++)
                {
                    Console.Write("--");
                }
                Console.WriteLine();
                //окончание вывода шапки


                for (int i = 0; i < 9; i++)
                {
                    Console.Write($"{i}| ");
                    for (int j = 0; j < 9; j++)
                    {
                        if ((i < 3 || i > 5) && (j < 3 || j > 5) && SudokyMap[i, j] != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(SudokyMap[i, j]+" ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if ((i > 2 && i < 6) && (j > 2 && j <6) && SudokyMap[i, j] != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(SudokyMap[i, j]+" ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (SudokyMap[i, j] != 0)
                        {
                            Console.Write(SudokyMap[i, j]+" ");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(SudokyMap[i, j]+" ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                    }
                    Console.WriteLine();
                }
                Console.Read();
            }
        }
    }
}