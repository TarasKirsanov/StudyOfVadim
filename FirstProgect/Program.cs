using FirstProgect.FIgures;
using System;

namespace FirstProgect
{
    class Program
    {
        static void Main(string[] args)
        {
            // создать класс треугольник и в нем реализовать 2 конструктора первый без парамтров () второй с 3 параметрами (x,y,z), а также 2 метода: получение площади и получение периметра
            Rectangle squard = new Rectangle(1,1);
            Console.WriteLine(squard.GetArea());
            Console.ReadKey();
        }
    }

}
