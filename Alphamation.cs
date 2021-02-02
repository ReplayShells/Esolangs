using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaMation
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            while (true)
            {
                Console.Write(">> ");
                string cmd = Console.ReadLine();

                int i = 0;
                while (true)
                {
                    try
                    {
                        switch (cmd[i++])
                        {
                            case '&':
                                MirrorMachine();
                                break;

                            case '+':
                                Console.WriteLine("Hello,world!");
                                break;

                            case '-':
                                Console.WriteLine(Console.ReadLine());
                                break;

                            case '*':
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Black;
                                break;

                            case '/':
                                Console.ResetColor();
                                break;

                            case ';':
                                c++;
                                break;

                            case ':':
                                c--;
                                break;

                            case '@':
                                switch (cmd[i++])
                                {
                                    case '+':
                                        Console.WriteLine("hello world.");
                                        break;

                                    case '-':
                                        Console.WriteLine(string.Concat(Console.ReadLine().Reverse()));
                                        break;

                                    case '*':
                                        Console.BackgroundColor = ConsoleColor.White;
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        break;

                                    case '/':
                                        Console.BackgroundColor = ConsoleColor.White;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        break;

                                    case ';':
                                        c *= 2;
                                        break;

                                    case ':':
                                        c /= 2;
                                        break;

                                    case '@':
                                        switch (cmd[i++])
                                        {
                                            case '+':
                                                return;

                                            case '-':
                                                Console.ReadLine();
                                                break;

                                            case '*':
                                                Console.BackgroundColor = ConsoleColor.Magenta;
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                break;

                                            case '/':
                                                Console.BackgroundColor = ConsoleColor.Blue;
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                break;

                                            case ';':
                                                c = 0xff;
                                                break;

                                            case ':':
                                                c = 0xffff;
                                                break;

                                            case '@':
                                                switch (cmd[i++])
                                                {
                                                    case '+':
                                                        Console.WriteLine("!dlrow,olleH");
                                                        break;

                                                    case '-':
                                                        Console.ForegroundColor = ConsoleColor.Gray;
                                                        Console.Write(string.Concat(Console.ReadLine().Reverse()));
                                                        break;

                                                    case '*':
                                                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                                                        Console.Write("Ç");
                                                        Console.ForegroundColor = ConsoleColor.Black;
                                                        break;

                                                    case '/':
                                                        Console.BackgroundColor = ConsoleColor.Green;
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        break;

                                                    case ';':
                                                        c = (c * 4) + 1;
                                                        break;

                                                    case ':':
                                                        c = (c / 4) + 1;
                                                        break;
                                                }
                                                break;
                                        }
                                        break;
                                }
                                break;
                        }
                    }
                    catch
                    {
                        break;
                    }
                }
                Console.Write("\n");
            }
        }
        // mirror-machine
        static void MirrorMachine()
        {
            int a = 0; uint b = 0;
            int.TryParse(Console.ReadLine(), out a);
            uint.TryParse(Console.ReadLine(), out b);
            a++;
            b--;
            if(a != 0)
            {
                Console.WriteLine(a);
                a = 0;
            }
            if(b != 1)
            {
                Console.WriteLine(b);
            }
            while(b != 0)
            {
                Console.WriteLine(b);
                b--;
            }
            int.TryParse(Console.ReadLine(), out a);
            uint.TryParse(Console.ReadLine(), out b);
            Console.WriteLine(a - b);
            Console.WriteLine("ABC");
            return;
        }
    }
}
