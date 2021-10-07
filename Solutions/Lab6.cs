using System;
using System.Linq;
namespace bootcamp.Solutions
{
    class Lab6
    {
        public void problem1()
        {
            int num = int.Parse(Console.ReadLine());
            for(int i = num; i<= num; i++)
            {
                if(num%i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        public void problem2()
        {
            int N = int.Parse(Console.ReadLine());
            while(true)
            {
                int K = int.Parse(Console.ReadLine());
                if(K == N)
                {
                    Console.WriteLine(K);
                    break;
                }
                else if (K > N)
                {
                    Console.WriteLine($"{K}>");
                }
                else
                {
                    Console.WriteLine($"{K}<");
                }
            }
        }

        public void problem3()
        {
            int sum = 0;
            while(true)
            {
                int K = int.Parse(Console.ReadLine());
                if(K == 0)
                {
                    Console.WriteLine(sum);
                    break;
                }
                else
                {
                    sum += K;
                }
            }
        }

        public void problem4()
        {
            for(int i = 2; i<= 10; i++)
            {
                Console.Write($"{i}!=");
                int res = 1;
                for(int j=1; j< i; j++)
                {
                    res *= j;
                    Console.Write($"{j}*");
                }
                Console.WriteLine($"{i}={res}");
            }
        }

        public void problem5()
        {
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            for(int i = ints.Min(); i>= 1; i--)
            {
                if(ints[0]%i ==0 & ints[1]%i==0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        public void problem6()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n-i; j++){Console.Write(" ");}
                for (int j = 0; j < 2*i-1; j++){Console.Write("*");}
                Console.WriteLine("");
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++){Console.Write(" ");}
                for (int j = 0; j < 2*(n-i)-1; j++){Console.Write("*");}
                Console.WriteLine("");
            }
        }

        public void problem7()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = i; j < i+10; j++)
                {
                    Console.Write($"{j%10} ");
                }
                Console.WriteLine();
            }
        }

        public void problem8()
        {
            int n = int.Parse(Console.ReadLine());
            var counter = 0;
            for (int i = 1; i <= n; i++)
            {
                counter += i.ToString().Count(f => (f == '3'));
            }
            Console.WriteLine(counter);
        }

        public void problem9()
        {
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n-i; j++){Console.Write(" ");}
                int k = a;
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{ k++%10} ");
                    a = k%10;
                }
                Console.WriteLine();
            }
        }

        public void problem10()
        {
            var num = Console.ReadLine();
            int n = 0;
            while(true)
            {
                for (int i = 0; i < num.Length; i++)
                {
                    n += int.Parse(num[i].ToString());
                }
                if (n>10)
                {
                    num = n.ToString();
                }
                else if (n==10)
                {
                    Console.WriteLine(1);
                    break;
                }
                else
                {
                    Console.WriteLine(n);
                    break;
                }
                n = 0;
            }
        }

        public void problem11()
        {
            var cube = new int[6]{1, 2, 3, 4, 5, 6};
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        if(cube[i] + cube[j] + cube[k] == 10)
                        {
                            Console.WriteLine($"{cube[i]} {cube[j]} {cube[k]}");
                        }
                    }
                }
            }
        }

        public void problem12()
        {
            int sum = 0;
            int n =1+ int.Parse(Console.ReadLine());
            while(n-->0)
            {
                sum += n;    
            }
            Console.WriteLine($"{sum}");

        }

        public void problem13()
        {
            int sum = 0;
            int counter = 0;
            int prev = 0;
            while(true)
            {
                // int K = int.Parse(Console.Read());
                // if(K <= 0)
                // {
                //     Console.WriteLine($"{sum} {Math.Round(sum/counter, 2)} {prev}");
                //     break;
                // }
                // else
                // {
                //     sum += K;
                //     counter += 1;
                //     prev = K;
                // }
                
            }
        }

        public void problem14()
        {
            int n = int.Parse(Console.ReadLine());
            var ints = Console.ReadLine().Split().Select(double.Parse).ToList();
            double sum = 0;
            
            foreach (var item in ints)
            {
                sum += Math.Pow(item, 3);
            }

            System.Console.WriteLine(sum);
            
        }

        public void problem15()
        {
            var user = int.Parse(Console.ReadLine());
            var sum = 1;
            for (int i = 2; i < 13; i++)
            {
                sum *= i;
                if (sum == user)
                {
                    Console.WriteLine(true);
                    break;
                }
                else if (sum > user)
                {
                    Console.WriteLine(false);
                    break;
                }
            }
        }

        public void problem24()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void problem23()
        {
            var n = Console.ReadLine();
            Console.WriteLine(n.Length);
        }

        public void problem22()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if(i.ToString().Length == 1)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    var len = i.ToString().Length;
                    double res = 0;
                    foreach(var a in i.ToString())
                    {
                        res += Math.Pow(double.Parse(a.ToString()), len);
                    }
                    if (res == i)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }

        public void problem21()
        {
            int count = 0;
            long a = long.Parse(Console.ReadLine());
            while (a != long.Parse(Reverse(a.ToString())))
            {
                a = a + long.Parse(Reverse(a.ToString()));
                count++;
            }
            System.Console.WriteLine($"{count} {a}");
            
        }

        public void Problem16()
        {
            int a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                bool tubmi = true;
                if(a % 2 == 0)
                {
                    a++;
                    tubmi = false;
                    continue;
                }
                for(int i = 3; i <= Math.Sqrt(a); i += 2)
                {
                    if(a % i == 0)
                    {
                        a++;
                        tubmi = false;
                        continue;
                    }
                }
                if(tubmi)
                {
                    System.Console.WriteLine(a);
                    break;
                }
            }
        }
        public void Problem17()
        {
            int x = 0, y = 0;
            var a = int.Parse(Console.ReadLine());
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            for(int i = 0; i < ints.Count; i++)
            {
                int j = i + 1;
                var checker = j % 4;
                switch (checker)
                {
                    case 1: y += ints[i]; break;
                    case 2: x += ints[i]; break;
                    case 3: y -= ints[i]; break;
                    case 0: x -= ints[i]; break;
                }
            }
            System.Console.WriteLine($"{x} {y}");
        }
        public void Problem18()
        {
            var ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            long N = ints[0], M = ints[1];
            int i = 0;
            while(N > 1 && M > 1)
            {
                if(N % 2 == 0)
                {
                    N /= 2;
                }
                else
                {
                    N = N * 3 + 1;
                }

                if(M % 2 == 0)
                {
                    M /= 2;
                }
                else
                {
                    M = M * 3 + 1;
                }
                i++;
            }
            if(N == 1)
            {
                System.Console.WriteLine($"{ints[0]} {i}");
            }
            else if(M == 1)
            {
                System.Console.WriteLine($"{ints[1]} {i}");                
            }
        }
        public void Problem19()
        {
            var num = int.Parse(Console.ReadLine());
            long a = 0, b = 1, c = a + b;
            for(int i = 3; i < num; i++)
            {
                a = b;
                b = c;
                c = a + b;
            }
            System.Console.WriteLine(c);
        }
    }
}