using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;

namespace Calculator
{
    class Plus
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathLib.Class1.Plus());//Сложение
            Console.ReadLine();
            Console.WriteLine(MathLib.Class1.Minus());//Вычитание
            Console.ReadLine();
            Console.WriteLine(MathLib.Class1.Multiply());//Умножение
            Console.ReadLine();
            Console.WriteLine(MathLib.Class1.Divide());//Деление
            Console.ReadLine();
        }
    }
}