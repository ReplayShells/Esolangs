using System;

namespace TF
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsTruthy = true;
            while (true)
            {
                Console.Write(">> ");
                string cmd = Console.ReadLine();

                int i = 0;
                while (true)
                {
                    if(cmd == "")
                    {
                        IsTruthy = !IsTruthy;
                        break;
                    }

                    try
                    {
                        switch (cmd[i++])
                        {
                            case 'T':
                                Console.WriteLine("True");
                                break;

                            case 'F':
                                Console.WriteLine("False");
                                break;

                            default:
                                if (IsTruthy)
                                {
                                    Console.WriteLine("True");
                                }
                                else
                                {
                                    Console.WriteLine("False");
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
    }
}
