using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write(">> ");
            string input = Console.ReadLine();
            int i = 0, accumulator = 0;
            for (; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'H':
                        Console.WriteLine("Hello,world!");
                        break;
                    case 'Q':
                        Console.WriteLine(input);
                        break;
                    case '9':
                        Func<int, bool, string> f = (x, y) =>
                            $"{(x == 0 ? "No more" : x.ToString())} bottle{(x == 1 ? "" : "s")} of beer{(y ? " on the wall" : "")}\r\n";
                        for (int tmp = 99; tmp > 0; tmp--)
                            Console.WriteLine($"{f(tmp, true)}{f(tmp, false)}Take one down, pass it around\r\n{f(tmp - 1, true)}");
                        break;
                    case '+':
                        accumulator++;
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}