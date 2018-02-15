using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            CLBirdie.MakeSomeNoise(name);
        }

        public static void Assign1_1()
        {
            for (int i = 100; i < 203; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Assign1_2()
        {
            for (int i = 202; i > 99; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void Assign1_3()
        {
            int x = 100;
            while (x < 202)
            {
                x += 2;

                switch (x)
                {
                    case 110:
                    case 120:
                    case 140:
                        Console.WriteLine(x + " This is a funny number");
                        break;
                    case 122:
                        Console.WriteLine(x + " This is my lucky number");
                        break;
                    case 198:
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine(x);
                        break;
                }
            }
     
        }

        public static void Assign1_4()
        {
            for (int i = 1; i<256; i++)
            {
                Console.WriteLine("{0:X}", i);
            }
        }

    }
}
