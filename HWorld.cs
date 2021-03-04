using System;

class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Write(">> ");
            string input = Console.ReadLine();
            int i = 0;
            for (; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'h':
                        switch (input[++i])
                        {
                            case 'h':
                                Console.WriteLine("Hello, Hello!");
                                break;
                            case 'w':
                                Console.WriteLine("Hello, World!");
                                break;
                            default:
                                Console.WriteLine("Hello!");
                                i--;
                                break;
                        }
                        break;
                    case 'w':
                        switch (input[++i])
                        {
                            case 'h':
                                Console.WriteLine("World, Hello!");
                                break;
                            case 'w':
                                Console.WriteLine("World, World!");
                                break;
                            default:
                                Console.WriteLine("World!");
                                i--;
                            break;
                        }
                        break;
                    case 'q':
                        return;
                    default:
                        Console.Write(input[i]);
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}