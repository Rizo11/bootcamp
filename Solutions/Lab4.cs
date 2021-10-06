using System;
using System.Linq;

namespace bootcamp.Solutions
{
    class Lab4
    {
        public void problem1()
        {
            var num = int.Parse(Console.ReadLine()).ToString("D5");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{num[i]}!");
            }
            Console.Write($"{num[4]}");
        }

        public void problem2()
        {
            Console.WriteLine(">>>");
            var num = int.Parse(Console.ReadLine());
            int h = num / 3600;
            int m = (num - h*3600) / 60;
            int s = num - m*60 - h*3600;
            Console.WriteLine($"{h}:{m}:{s}");
        }

        public void problem3()
        {
            Console.WriteLine(">>>");
            var num = Console.ReadLine();
            Console.WriteLine($"{num[2]}");
        }

        public void problem4()
        {
            Console.WriteLine(">>>");
            var num = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.Round(num/100d)*100}");
        }

        public void problem5()
        {
            Console.WriteLine(">>>");
            var C = float.Parse(Console.ReadLine());
            var r = C/(2*3.141592);
            Console.WriteLine($"Area: {Math.Round(3.141592 * r*r)}");
        }

        public void problem6()
        {
            Console.WriteLine(">>>");
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine((num >=20  & num <= 30) ? 1 : 0);
        }

        public void problem7()
        {
            Console.WriteLine(">>>");
            var c = Console.ReadLine();
            bool b = Char.IsLetter(c[0]);
            if (b)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        public void problem8()
        {
            Console.WriteLine(">>>");
            var num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        
        public void problem9()
        {
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine($"{ints.Max()}");
        }

        public void problem10()
        {
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine($"{(int)ints.Max()/ints.Min()}\n{ints.Max()%ints.Min()}");
        }

    }
}