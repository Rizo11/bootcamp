using System;

namespace bootcamp.Solutions
{
    class Lab3
    {
        public void problem1()
        {
            Console.WriteLine("Sonni kiriting:");
            var c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Natija (int):{c}\nNatija (char): {(char)c}");

        }

        public void problem2()
        {
            Console.WriteLine(">>>");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var res = a*b;
            Console.WriteLine("Area is: " + res.ToString());
        }

        public void problem3()
        {
            Console.WriteLine(">>>");
            var a = float.Parse(Console.ReadLine());
            var b = float.Parse(Console.ReadLine());
            var res = a*b;
            Console.WriteLine($"Area is: {Math.Round(res, 2)}");
        }

        public void problem4()
        {
            Console.WriteLine(">>>");
            var a = float.Parse(Console.ReadLine());
            Console.WriteLine($"Area is: {Math.Round(a)}");
        }

        public void problem5()
        {
            Console.WriteLine(">>>");
            var a = Console.ReadLine();
            Console.WriteLine($"upper: {a.ToUpper()}");
        }

        public void problem6()
        {
            Console.WriteLine(">>>");
            var a = Console.ReadLine();
            Console.WriteLine($"lower: {a.ToLower()}");
        }
    }
}
