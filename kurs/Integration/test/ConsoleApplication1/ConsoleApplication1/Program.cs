﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public void MathFunctions()
        {
            double a, b, t, t0, dt, y;
            string NameFunction;
            Console.WriteLine("Введите имя F(t)исследуемой функции a*F(b*t)" +
                          " (sin, cos, tan, cotan)");
            NameFunction = Console.ReadLine();
            Console.WriteLine("Введите параметр a (double)");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите параметр b (double)");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите начальное время t0(double)");
            t0 = double.Parse(Console.ReadLine());
            const int points = 10;
            dt = 0.2;
            for (int i = 1; i <= points; i++)
            {
                t = t0 + (i - 1) * dt;
                switch (NameFunction)
                {
                    case ("sin"): y = a * Math.Sin(b * t); break;
                    case ("cos"): y = a * Math.Cos(b * t); break;
                    case ("tan"): y = a * Math.Tan(b * t); break;
                    case ("cotan"): y = a / Math.Tan(b * t); break;
                    case ("ln"): y = a * Math.Log(b * t); break;
                    case ("tanh"): y = a * Math.Tanh(b * t); break;
                    default: y = 1; break;
                } //switch 
                Console.WriteLine("t = " + t + "; " + a + "*" + NameFunction + "(" + b + "*t)= " + y + ";");
            } //for 
            double u = 2.5, v = 1.5, p, w;
            p = Math.Pow(u, v);
            w = Math.IEEERemainder(u, v);
            Console.WriteLine("u = " + u + "; v= " + v + "; power(u,v)= " + p + "; reminder(u,v)= " + w);
        } //MathFunctions

        public void Main()
        {
            Program l = new Program();
            l.MathFunctions();
        }
    }
}
