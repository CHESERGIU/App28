using System;
namespace App28
{    class Program
    {
        static void Main(string[] args)
        {
            //int[] values = { 2, 3, 1, 5, 6, 2, 8 };
            //int index;

            //for (index = 0; index < values.Length; index++)
            //{
            //    if (values[index] == 6)
            //        break;
            //}

            //int[] values = { 2, 3, 1, 5, 6, 2, 8 };
            //int count = 0;

            //for (int i = 0; i < values.Length; i++)
            //{
            //    if (values[i] % 2 != 0)
            //        continue;
            //    count++;
            //}Console.WriteLine(count);

            //string line = Console.ReadLine();
            //int number = Convert.ToInt32(line);
            //string result = "";

            //while (line != "gata")
            //{
            //    result += number * 2 + " ";
            //    line = Console.ReadLine();
            //    number = Convert.ToInt32(line);
            //}
            //Console.WriteLine(result);

            //string line = Console.ReadLine();
            //int number = Convert.ToInt32(line);
            //string result = "";
            //int total = 0;

            //while (line != "gata")
            //{
            //    total += number;
            //    result += total + " ";
            //    line = Console.ReadLine();
            //}
            //Console.WriteLine(result);

            //string line = Console.ReadLine();
            //string result = "";

            //while (line != "gata")
            //{
            //    int number = Convert.ToInt32(line);
            //    result = (number * 2).ToString();
            //    line = Console.ReadLine();
            //}

            //Console.WriteLine(result);

            //string line = Console.ReadLine();
            //string result = "";

            //while (line != "gata")
            //{
            //    int number = Convert.ToInt32(line);
            //    result += number * 2;
            //    line = Console.ReadLine();
            //}

            //Console.WriteLine(result);

            //string line = Console.ReadLine();
            //string result = "";

            //for (int i = 0; i < 5; i++)
            //{
            //    int number = Convert.ToInt32(line);
            //    result += number * 2 + " ";
            //}

            //Console.WriteLine(result);

            //string line = Console.ReadLine();
            //string result = "";
            //int total = 0;

            //while (line != "gata")
            //{
            //    int number = Convert.ToInt32(line);
            //    total += number;
            //    result += total + " ";
            //    line = Console.ReadLine();
            //}
            //Console.WriteLine(result);

            //string line = Console.ReadLine();
            //string result = "";

            //while (true)
            //{
            //    line = Console.ReadLine();
            //    if (line == "gata") break;
            //    int number = Convert.ToInt32(line);
            //    result += number * 2 + " ";
            //}
            //Console.WriteLine(result);

            string line = Console.ReadLine();
            string result = "";
            int total = 0;

            while (line != "gata")
            {
                int number = Convert.ToInt32(line);
                total += number;
                result += total + " ";
                line = Console.ReadLine();
            }
            Console.WriteLine(result);
        }
    }
}
