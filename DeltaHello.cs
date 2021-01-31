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
                                Ryota_MIZ.Items.Y_Functions.Bottles99();
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
    }
}
