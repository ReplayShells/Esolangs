using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write(">> ");
            string input = Console.ReadLine();
            int i = 0, c = 0;
            for (; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '1':
                        System.Threading.Thread.Sleep(1000);
                        c++;
                        break;
                    default:
                        Console.Write(input[i]);
                        break;
                }
            }
            Console.WriteLine((char)c);
            Console.WriteLine();
        }
    }
}