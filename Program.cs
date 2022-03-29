using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//tema Lab4 ex 2

namespace TemaLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);

            bool gasit;
            for (int i = 65; i < 91; i++)
            {
                gasit = false;
                
                char a, b;
                for (int j = 0; j < args.Length; j++)
                {
                    b = Convert.ToChar(i);
                    a = args[j].First(); 
                    
                    if (a == b || a == b + 32)
                    {
                        Console.Write(args[j] + " ");
                        gasit = true;
                    }

                }
                if (gasit == true)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
