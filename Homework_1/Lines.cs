using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Lines
    {
        public void oneLine(Int32 size, string text)
        {
            int borderWidth = (size - 1) * 2 + text.Length + 2;
            int borderHeight = (size - 1) * 2 + 3;
            for (int j = 0; j < borderHeight; j++)
            {
                for (int i = 0; i < borderWidth; i++)
                {
                    if (j == 0 || j == borderHeight - 1)
                    {
                        Console.Write("+");
                    }
                    else if (i == 0 || i == borderWidth - 1)
                    {
                        Console.Write("+");
                    }
                    else if (i == size && j == size)
                    {
                        Console.Write(text);
                        i = size - 1 + text.Length;
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }


        public void twoLine(Int32 size, string text)
        {
            int borderWidth = (size - 1) * 2 + text.Length + 2;
            int borderHeight = (size - 1) * 2 + 3;
            for (int j = 0; j < borderHeight; j++)
            {
                for (int i = 0; i < borderWidth; i++)
                {
                    if (j == 0 || j == borderHeight - 1)
                    {
                        Console.Write("+");
                    }
                    else if (i == 0 || i == borderWidth - 1)
                    {
                        Console.Write("+");
                    }
                    else if ((i + j) % 2 == 0)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }

        public void threeLine(Int32 size, string text)
        {
            int borderWidth = (size - 1) * 2 + text.Length + 2;
            int n = 1;
            for (int j = 0; j < borderWidth; j++)
            {
                for (int i = 0; i < borderWidth; i++)
                {

                    if (j == 0 || j == borderWidth - 1)
                    {
                        Console.Write("+");
                    }
                    else if (i == 0 || i == borderWidth - 1)
                    {
                        Console.Write("+");
                    }
                    else if (j == i)
                    {
                        Console.Write("+");
                    }
                    else if (i == borderWidth - n - 1 && j == n || i == borderWidth - n - 2 && j == n + 1)
                    {
                        Console.Write("+");
                        n++;
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
