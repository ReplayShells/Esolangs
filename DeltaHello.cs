using System;
using System.Speech.Synthesis;

namespace DeltaHello
{
    class Program
    {
        static void Main(string[] args)
        {
            int ac = 0;
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
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
                            case 'H':
                                Console.WriteLine("Hello,world!");
                                break;

                            case 'Q':
                                Console.WriteLine(cmd);
                                break;

                            case '9':
                                Bottles99();
                                break;

                            case 'S':
                                synth.Speak("Hello,world!");
                                break;

                            case '+':
                                ac++;
                                break;

                            case 'C':
                                Console.WriteLine(ac.ToString());
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
        
        static void Bottles99()
        {
            for (int i = 99; i > -1; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
                    Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall.");
                    break;
                }
                if (i == 1)
                {
                    Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer.");
                    Console.WriteLine("Take one down and pass it around, no more bottles of beer on the wall.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("{0} bottles of beer on the wall, {0} bottles of beer.", i);
                    Console.WriteLine("Take one down and pass it around, {0} bottles of beer on the wall.", i - 1);
                    Console.WriteLine();
                }
            }
        }
    }
}
