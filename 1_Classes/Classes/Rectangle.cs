using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{ 
    public class Rectangle
    {
        Point leftUp, rightLow;

        public Rectangle(Point leftUp, Point rightLow)
        {
            this.leftUp = leftUp;
            this.rightLow = rightLow;
        }

        public double Perimenter()
        {
            return AbsoluteNumber(leftUp.X - rightLow.X) * 2 +
                          (leftUp.Y - rightLow.Y) * 2;
        }

        public double Area()
        {
            return AbsoluteNumber(leftUp.X - rightLow.X) * (leftUp.Y - rightLow.Y);
        }

        double AbsoluteNumber(double value)
        {
            // Если мы передали отрицательное число, то возратиться положительное, усли положительное,
            // то без изменений:
            return value <= 0.0 ? 0.0 - value : value;  
        }
    }
}
