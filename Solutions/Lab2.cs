using System;

namespace bootcamp.Solutions
{
    public class Lab2
    {
        public void problem1()
        {
            Console.WriteLine("222222");
            Console.WriteLine("2    2");
            Console.WriteLine("2    2");
            Console.WriteLine("222222");
        }
        
        public void problem2()
        {
            Console.WriteLine("  A");
            Console.WriteLine(" A A");
            Console.WriteLine("AAAAA");
        }

        public void problem3()
        {
            Console.WriteLine("Birthdate");
            Console.WriteLine("Enter month: ");
            var month = Console.ReadLine();
            Console.WriteLine("Enter date: ");
            var date = Console.ReadLine();
            Console.WriteLine("B-day is " + int.Parse(month).ToString("D2") + "-" + int.Parse(date).ToString("D2") + "(mm-dd)");
        }

        public void problem4()
        {
            Console.WriteLine("Birthdate");
            Console.WriteLine("Enter month and date: ");
            //var MandD = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEnteries);
            var ManD = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(ManD[0]);
            Console.WriteLine("Birdthday is " + int.Parse(ManD[0]).ToString("D2") + "-" + int.Parse(ManD[1]).ToString("D2") + " (mm-dd).");
        }

        public void problem5()
        {
            Console.WriteLine("Enter an int: ");
            var time = Console.ReadLine();
            for (int i = 0; i < 6; i++)
            {
                Console.Write(time);
            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(time + "    " + time);
            }
            for (int i = 0; i < 6; i++)
            {
                Console.Write(time);
            }


        }

        public void problem6()
        {
            var day = int.Parse(Console.ReadLine());
            Console.WriteLine(" Sun Mon Tue Wed Thu Fri Sat");
            for (int i = day; i < day + 7; i++)
            {  
                if(i > 30)
                {
                    day = 7 + day - i;
                    break;
                }
                Console.Write(String.Format("{0,4}", i));
            }
            for (int i = 1; i < day+1; i++)
            {
                Console.Write(String.Format("{0,4}", i));
            }
        }

        public void problem7()
        {
            Console.WriteLine(">>>");
            var num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                var i1 = i;
                var num1 = num;
                var res = i*num;
                Console.WriteLine(num1.ToString() + "*" + i1.ToString() + "=" + res.ToString());
            }
        }

        public void problem8()
        {
            var num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                var res = 1;
                var a = i;
                while (a != 0)
                {
                    res *= a;
                    a--;
                }
                Console.WriteLine(i.ToString() + "! = " + res.ToString());
            }
        }

        public void problem9()
        {
            var num = int.Parse(Console.ReadLine());
            var a1 = 0;
            var a2 = 1;
            var a3 = a1 + a2;
            Console.Write(a1.ToString() + " " + a2.ToString() + " ");
            for (int i = 0; i < num-2; i++)
            {
                Console.Write(a3.ToString() + " ");
                a1 = a2;
                a2 = a3;
                a3 = a1 + a2;   
            }
        }
    }
}