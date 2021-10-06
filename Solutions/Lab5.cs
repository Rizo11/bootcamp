using System;
using System.Linq;
namespace bootcamp.Solutions
{
    class Lab5
    {
        public void problem1()
        {
            var degree = int.Parse(Console.ReadLine());
            if (degree < 0)
            {
                Console.WriteLine("ichkarida o'yna");
            }
            else if (degree >= 0 & degree < 40)
            {
                Console.WriteLine("tashqarida o'yna");
            }
            else
            {
                Console.WriteLine("ichkarida o'yna");
            }
        }

        public void problem2()
        {
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            if(ints[0] == ints[1]*ints[1])
            {
                Console.WriteLine($"{ints[1]}*{ints[1]}={ints[0]}");
            }
            else if (ints[1] == ints[0]*ints[0])
            {
                Console.WriteLine($"{ints[0]}*{ints[0]}={ints[1]}"); 
            }
            else
            {
                Console.WriteLine($"none");
            }
        }

        public void problem3()
        {
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine($"max: {ints.Max()}");
        }

        public void problem4()
        {
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine($"max: {ints.Max()} min: {ints.Min()}");
        }

        public void problem5()
        {
            var num = int.Parse(Console.ReadLine());
            if(num % 30 == 0)
            {
                Console.WriteLine("A");
            }
            else if (num % 6 == 0)
            {
                Console.WriteLine("B");   
            }
            else if (num % 10 == 0)
            {
                Console.WriteLine("C");   
            }
            else if (num % 15 == 0)
            {
                Console.WriteLine("D");   
            }
            else if(num%2==0 || num%3==0 || num%5==0)
            {
                Console.WriteLine("E");
            }
            else
            {
                Console.WriteLine("N");
            }
        }

        public void problem6()
        {
            var year = int.Parse(Console.ReadLine());
            if(year%4==0)
            {
                if (year%100 == 0)
                {
                    if (year%400==0)
                    {
                        Console.WriteLine("Leap year");
                    }
                    else
                    {
                        Console.WriteLine("Normal year");
                    }
                }
                else
                {
                    Console.WriteLine("Leap year");
                }
            }
            else
            {
                Console.WriteLine("Normal year");
            }
        }

        public void problem7()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 6);
            while (true)
            {
                Console.WriteLine("enter your guess: ");
                var user = int.Parse(Console.ReadLine());
                if (user == num)
                {
                    Console.WriteLine("correct");
                    break;
                }
                else if(user > num)
                {
                    Console.WriteLine("DOWN");
                }
                else
                {
                    Console.WriteLine("UP");
                }
            }
        }

        public void problem8()
        {
            var c = Console.ReadLine();
            if(char.IsLetter(c[0]))
            {
                Console.WriteLine((char.IsUpper(c[0]))? char.ToLower(c[0]):char.ToUpper(c[0]));
            }
            else
            {
                Console.WriteLine("none");
            }
        }

        public void problem9()
        {
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            var ints1 = Console.ReadLine().Split().Select(int.Parse).ToList();

            var s = 0;
            var b = 0;
            for (int i = 0; i < 3; i++)
            {
                if(ints[i] == ints1[i])
                {
                    s += 1;
                }
                else
                {
                    b += (ints[i] == ints1[0])? 1 : 0;
                    b += (ints[i] == ints1[1])? 1 : 0;
                    b += (ints[i] == ints1[2])? 1 : 0;
                }
            }
            Console.WriteLine($"{s}S{b}B");
        }

        public void problem10()
        {
            var a = Console.ReadLine();
            System.Data.DataTable table = new System.Data.DataTable();
            var result = Convert.ToInt32(table.Compute(a, String.Empty));
            System.Console.WriteLine(result.ToString());
        }

        public void problem11()
        {
            var choice = int.Parse(Console.ReadLine());
            var money = int.Parse(Console.ReadLine());

            if(choice == 1)
            {
                //1000 - 500
                int f = (money-500)/500;
                int h = ((money-500)%500)/100;
                Console.WriteLine("Americano");
                Console.WriteLine($"{f} {h}");
            }
            else if(choice == 2)
            {
                int f = (money-400)/500;
                int h = ((money-400)%500)/100;
                Console.WriteLine("Caffe Latte");
                Console.WriteLine($"{f} {h}");
            }
            else if(choice == 3)
            {
                int f = (money-300)/500;
                int h = ((money-300)%500)/100;
                Console.WriteLine("Lemon Tea");
                Console.WriteLine($"{f} {h}");
            }
        }

        public void problem12()
        {
            var num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    problem4();
                    break;

                case 2:
                    problem9();
                    break;

                case 3:
                    problem10();
                    break;

                default:
                    break;
            }
        }

        public void problem13()
        {
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            foreach (var item in ints)
            {
                sum += item;
            }
            Console.WriteLine((sum > 100)? true:false);
        }

        public void problem14()
        {
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            if(Math.Pow(ints[0], 2)+Math.Pow(ints[1], 2) == Math.Pow(ints[2], 2))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        public void problem15()
        {
            var user = Console.Read();
            if(user == '+' || user == '-' || user == '/' || user == '*' || user == '%')
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        public void problem16()
        {
            var nums = new string[11] {"nol", "bir", "ikki", "uch", "to'rt", "besh", "olti", "yetti", "sakkiz", "to'qqiz", "boshqa"};
            var user = int.Parse(Console.ReadLine());
            if(user >= 0 & user<= 9)
            {
                Console.WriteLine(nums[user]);
            }
            else
            {
                Console.WriteLine(nums[10]);
            }
        }

        public void problem17()
        {
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();

            if(ints[1] < 45 & ints[0] == 0)
            {
                ints[1] += 15;
                ints[0] = 23;
            }
            else if(ints[1] < 45 & ints[0] != 0)
            {
                ints[1] += 15;
                ints[0] -= 1;
            }
            else if(ints[1] > 45 & ints[0] != 0)
            {
                ints[1] -= 45;
                ints[0] -= 1;
            }
            Console.WriteLine($"{ints[0]} {ints[1]}");
        }

        public void problem18()
        {
            int unicode = int.Parse(Console.ReadLine());
            char character = (char) unicode;
            Console.WriteLine(character.ToString());
        }

        public void problem19()
        {
            Console.WriteLine(">>>");
            var num = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.Round(num/1000d)*1000}");
        }

        public void problem20()
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

        public void problem21()
        {
            var num = int.Parse(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }

}