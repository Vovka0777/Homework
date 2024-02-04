using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант 1. f(x)=3x2, x =[-1; 1], h = 0,1
            //double h = 0.1;

            //double start = -1;
            //double end = 1;
            //
            //for (double x = start; x <= end; x += h)
            //{
            //    double y = 3 * Math.Pow(x, 2);
            //    Console.WriteLine($"x = {x:F1}, f(x) = {y:F3}");
            //}
            // Console.ReadKey();

            //Вариант 2.f(x) = x3, x =[-2; 2], h = 0,2.
            // double h = 0.2;

            // double start = -2;
            // double end = 2;

            // for(double x = start; x <= end; x+=h)
            // {
            //     double y = 3 * Math.Pow(x, 2);
            //     Console.WriteLine($"x = {x:f1}, f(x) = {y:f3}");
            //}
            //Console.ReadKey();

            //Вариант 3.f(x) =х , x =[0; 5], h = 0,2.

            // double start = 0;
            // double end = 5;

            // double h = 0.2;


            // Console.WriteLine("x\tf(x)");
            // for (double x = start; x <= end; x += h)
            // {
            //    double result = Math.Sqrt(x);
            //    Console.WriteLine($"{x}\t{result}");
            //}

            //Console.ReadLine();


            // Вариант 4. f(x)=cos x, x=[-3,14;3,14], h=0,2.

            //double start = -3.14;
            //double end = 3.14;

            //double h = 0.2;


            //Console.WriteLine("x\tf(x)");
            //for (double x = start; x <= end; x += h)
            //{
            //    double result = Math.Cos(x);
            //    Console.WriteLine($"{x}\t{result}");
            // }

            // Console.ReadLine();


            // Вариант 5. f(x)= х/12, x =[1; 12], h = 0,5

            //  double start = 1;
            //  double end = 12;

            // double h = 0.5;

            //Console.WriteLine("x\tf(x)");
            // for (double x = start; x <= end; x += h)
            //{
            //    double result = 12 / x;
            //    Console.WriteLine($"{x}\t{result}");
            //}

            //Console.ReadLine();

            //Вариант 6.f(x) = tg x, x =[-1, 57; 1,57], h = 0,2

            // double start = -1.57;
            // double end = 1.57;

            // double h = 0.2;

            // Console.WriteLine("x\tf(x)");
            // for (double x = start; x <= end; x += h)
            // {
            //     double result = Math.Tan(x);
            //     Console.WriteLine($"{x}\t{result}");
            // }

            // Console.ReadLine();

            //Вариант 7. f(x)=корень х/ (x+1), x =[0; 2], h = 0,2


            //double start = 0;
            // double end = 2;

            // double h = 0.2;

            // Console.WriteLine("x\tf(x)");
            // for (double x = start; x <= end; x += h)
            // {
            //      double result = Math.Sqrt(x) / (x + 1);
            //      Console.WriteLine($"{x}\t{result}");
            // }

            //   Console.ReadLine();

            //Вариант 8. f(x)=sin x, x=[-3,14;3,14], h=0,2

            // double start = -3.14;
            // double end = 3.14;

            // double h = 0.2;

            //Console.WriteLine("x\tf(x)");
            //for (double x = start; x <= end; x += h)
            //{
            //    double result = Math.Sin(x);
            //    Console.WriteLine($"{x}\t{result}");
            // }

            //Console.ReadLine();

            //Вариант 9. f(x)=1/2 x^2 + 3, x=[-3;3], h=0,5.

            //double start = -3;
            //double end = 3;

            // double h = 0.5;

            //Console.WriteLine("x\tf(x)");
            //for (double x = start; x <= end; x += h)
            //{
            //    double result = 0.5 * Math.Pow(x, 2) + 3;
            //    Console.WriteLine($"{x}\t{result}");
            // }

            //Console.ReadLine();


            //Вариант 10. f(x)=1/2(x-5)^2, x=[0;8], h=0,2

            //double start = 0;
            //double end = 8;

            //double h = 0.2;

            //Console.WriteLine("x\tf(x)");
            //for (double x = start; x <= end; x += h)
            //{
            //    double result = 0.5 * Math.Pow(x - 5, 2);
            //    Console.WriteLine($"{x}\t{result}");
            // }

            //Console.ReadLine();

            //Вариант 11. f(x)=1/4x^2+ x+1, x=[-5;5], h=0,2.

            //double start = -5;
            //double end = 5;

            //double h = 0.2;

            //Console.WriteLine("x\tf(x)");
            //for (double x = start; x <= end; x += h)
            // {
            //    double result = 0.25 * Math.Pow(x, 2) + x + 1;
            //    Console.WriteLine($"{x}\t{result}");
            // }

            //Console.ReadLine();


            //Вариант 12. f(x)= 1/2(x-3)^2+ 2, x=[-2;7], h=0,1.

            // double start = -2;
            // double end = 7;

            // double h = 0.1;

            // Console.WriteLine("x\tf(x)");
            // for (double x = start; x <= end; x += h)
            // {
            //     double result = 0.5 * Math.Pow(x - 3, 2) + 2;
            //     Console.WriteLine($"{x}\t{result}");
            // }

            // Console.ReadLine();

            //Вариант 13. f(x)=модуль х , x=[-3;3], h=0,2

            //double start = -3;
            //double end = 3;

            //double h = 0.2;

            // Console.WriteLine("x\tf(x)");
            // for (double x = start; x <= end; x += h)
            // {
            //     double result = Math.Abs(x);
            //     Console.WriteLine($"{x}\t{result}");
            // }

            // Console.ReadLine();

            //Вариант 14. f(x)=1/8x^4-x^2, x=[-3;3], h=0,1

           // double start = -3;
           // double end = 3;

           // double h = 0.1;

           // Console.WriteLine("x\tf(x)");
           // for (double x = start; x <= end; x += h)
           // {
           //     double result = (1.0 / 8.0) * Math.Pow(x, 4) - Math.Pow(x, 2);
           //     Console.WriteLine($"{x}\t{result}");
          //  }

          //  Console.ReadLine();
        }
    }
}
