using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculator.Models
{
    public class Calculator
    {
        public void Sum(int x, int y)
        {
          Console.WriteLine($"{x} + {y} = {x + y}"); 
        }
        public void Subtract(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiply(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }
        public void Divide(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Power(int x, int y)
        {
            Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
        }
        public void Sine(double angle)
        {
            double radian = angle * Math.PI / 180;
            double sine =Math.Sin(radian);
            Console.WriteLine($"{angle}º sine = {Math.Round(sine, 4)}");
        }
        public void Cosine(double angle)
        {
            double radian = angle * Math.PI / 180;
            double cosine =Math.Cos(radian);
            Console.WriteLine($"{angle}º cosine = {Math.Round(cosine, 4)}");
        }
        public void Tangent(double angle)
        {
            double radian = angle * Math.PI / 180;
            double tangent =Math.Tan(radian);
            Console.WriteLine($"{angle}º tangent = {Math.Round(tangent, 4)}");
        }
        public void SquareRoot(double x)
        {
            Console.WriteLine($"{x} square root = {Math.Sqrt(x)}");
        }
    }
}