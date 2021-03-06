using System;

class Program
{
    static void Main()
    {
        Console.Write(">> ");
        string bf = Console.ReadLine();
            
        string r = "using System;\n\nclass Program{\nstatic void Main(){\nchar[] mem = new char[0xff];\nint ptr = 0;\n";
        for (int i = 0; i < bf.Length; i++)
        {
            switch (bf[i])
            {
                 case '>':
                    r += "ptr++;\n";
                    break;
                case '<':
                    r += "ptr--;\n";
                    break;
                case '+':
                    r += "mem[ptr]++;\n";
                    break;
                case '-':
                    r += "mem[ptr]--;\n";
                    break;
                case '.':
                    r += "Console.Write((char)mem[ptr]);\n";
                    break;
                case ',':
                    r += "mem[ptr] = (char)Console.Read();\n";
                    break;
                case '[':
                    r += "while(mem[ptr] != 0){\n";
                    break;
                case ']':
                    r += "}\n";
                    break;
            }
        }
        r += "}\n}\n";

        Console.WriteLine(r);
    }
}