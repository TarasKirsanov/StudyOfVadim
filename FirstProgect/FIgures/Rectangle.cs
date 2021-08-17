using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProgect.FIgures
{
    public class Rectangle
    {
        //Поле
        public int X { get; set; }

        public int Y { get; set; }

        //конструктор
        public Rectangle()
        {
            X = 0;
            Y = 0;
        }


        //консруктор
        public Rectangle(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Метод
        public int GetArea()
        {
            var area = X * Y;
            return area;
        }

        //создать метод для получения периметра 

        // создать метод нахождения диагонали float 

        //создать конструктор в который приходит одно значени и обе стороны становяться равными этому значению
    }
}
