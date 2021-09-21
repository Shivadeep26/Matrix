using System;
using System.Collections.Generic;

namespace ConsoleAppMatrixOrder
{
    public class Program
    {
        private static readonly int rowvalue = 3;
        private static readonly int colvalue = 3;
        public static void Main()
        {
            Random rnd = new Random();

            int i, j;
            string[,] arr1 = new string[rowvalue, colvalue];

            Console.Write("\n\nRead array of size "+rowvalue+"x"+colvalue+" matrix :\n");
            Console.Write("------------------------------------------------------\n");

            /* Stored values into the array*/
            Console.Write("Input elements in the matrix :\n");
            List<int> numbers = new List<int>();

            for (i = 0; i < rowvalue; i++)
            {
                for (j = 0; j < colvalue; j++)
                {
                takenumber: var random = rnd.Next(0, 9);
                    bool isnumber = !numbers.Contains(random);
                    if (isnumber)
                    {
                        numbers.Add(random);
                        Console.WriteLine("element - [{0},{1}] :" + random + " ", i, j);
                        arr1[i, j] = random.ToString();
                    }
                    else
                    {
                        goto takenumber;
                    }
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < rowvalue; i++)
            {
                Console.Write("\n");
                for (j = 0; j < colvalue; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");

            int row = GetRandomRow();

            int col = GetRandomCol();

            GetRandomnumber(arr1, row, col);
        }

        private static int GetRandomCol()
        {
            Randomcol:  Console.WriteLine("Enter the Col between 1 to 3");
            int col = Convert.ToInt32(Console.ReadLine());
            if (col > colvalue)
            {
                goto Randomcol;
            }
            return col;
        }

        private static int GetRandomRow()
        {
            Randomrow:  Console.WriteLine("Enter the Row  between 1 to 3");
            int row = Convert.ToInt32(Console.ReadLine());
            if(row > rowvalue)
            {
                goto Randomrow;
            }
            return row;
        }

        private static void GetRandomnumber(string[,] arr1, int row, int col)
        {
            Console.WriteLine("The number in the position is ");
            Console.WriteLine("[{0},{1}] = {2}", row, col, arr1[row - 1, col - 1]);
            Console.ReadLine();
        }

    }
}