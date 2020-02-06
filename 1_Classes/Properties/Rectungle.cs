using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{   
 /*Задание 2.
Создать класс с именем Rectangle. 
В теле класса создать два поля, описывающие длины сторон double side1, side2. 
Создать пользовательский конструктор Rectangle(double side1, double side2), 
в теле которого поля side1 и side2 инициализируются значениями аргументов. 
Создать два метода, вычисляющие площадь прямоугольника – double AreaCalculator() и 
периметр прямоугольника – double PerimeterCalculator(). 
Создать два свойства double Area и double Perimeter с одним методом доступа get. 
Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на 
экран периметр и площадь. */
  public  class Rectangle4
    {
        double side1, side2;
        public Rectangle4(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        double Area_Calclator()
        {
            return side1 * side2;
        }

        double Perimetr_calculator()
        {
            return 2 * (side1 + side2);
        }

        public double Area
        {
            get
            {
                return Area_Calclator();
            }
        }

        public double Perimetr
        {
            get
            {
                return Perimetr_calculator();
            }
        }
    }
}
