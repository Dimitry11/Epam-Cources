using Classes;
using Collections;
using Inharitance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class All_Tasks
    {
        public void Task_1()
        {
            Console.Clear();
            Point leftUp, rightLow;
            Console.WriteLine("Enter the upper and lower right corner coordinates: ");
            Console.Write("Input upper-left coord\nX: ");
            leftUp.X = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            leftUp.Y = double.Parse(Console.ReadLine());
            Console.Write("Input lower-right coord\nX: ");
            rightLow.X = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            rightLow.Y = double.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(leftUp, rightLow);
            Console.WriteLine($"Perimeter of Rectangle is: {rect.Perimenter()}");
            Console.WriteLine($"Area of Rectangle is: {rect.Area()}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_2()
        {
            Console.Clear();
            Point LeftUp, RightLow;
            Console.WriteLine("Enter the upper and lower right corner coordinates: ");
            Console.Write("Input upper-left coord\nX: ");
            LeftUp.X = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            LeftUp.Y = double.Parse(Console.ReadLine());
            Console.Write("Input lower-right coord\nX: ");
            RightLow.X = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            RightLow.Y = double.Parse(Console.ReadLine());
            Rectangle2 rect2 = new Rectangle2(LeftUp, RightLow);
            Console.WriteLine($"Perimeter of Rectangle is: {rect2.GetPerimetr}");
            Console.WriteLine($"Area of Rectangle is: {rect2.GetArea}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_3()
        {
            Console.Clear();
            Console.Write("Input radius: ");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            Console.WriteLine($"Length of a Circle is: {circle.Length_Circle()}");
            Console.WriteLine($"Area of a Circle is: {circle.Area_Circle()}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_4()
        {
            Console.Clear();
            Point left, right;
            Console.WriteLine("Static of Rectangle:\nEnter the upper and lower right corner coordinates: ");
            Console.Write("Input upper-left coord\nX: ");
            left.X = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            left.Y = double.Parse(Console.ReadLine());
            Console.Write("Input lower-right coord\nX: ");
            right.X = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            right.Y = double.Parse(Console.ReadLine());
            Rectangle_static.Set_Coordinates(left, right);
            Console.WriteLine($"Perimeter of Rectangle is: {Rectangle_static.Perimenter()}");
            Console.WriteLine($"Area of Rectangle is: {Rectangle_static.Area()}");
            Console.Write("\n\nStatic of Circle: \n\nInput radius: ");
            double r = double.Parse(Console.ReadLine());
            Circle_static.Set_Radius(r);
            Console.WriteLine($"Length of a Circle is: {Circle_static.Length_Circle}");
            Console.WriteLine($"Area of a Circle is: {Circle_static.Area_Circle}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_5()
        {
            Console.Clear();
            Console.WriteLine("Set 1st of the ComplexNumber\n");
            Console.Write("Input The RealNumber: ");
            double realNumber1 = double.Parse(Console.ReadLine());
            Console.Write("Imput imaginary: ");
            double imaginary1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\nSet 2nd of the ComplexNumber\n");
            Console.Write("Input The RealNumber: ");
            double realNumber2 = double.Parse(Console.ReadLine());
            Console.Write("Imput imaginary: ");
            double imaginary2 = double.Parse(Console.ReadLine());

            ComplexNumber complex1 = new ComplexNumber(realNumber1, imaginary1);
            ComplexNumber complex2 = new ComplexNumber(realNumber2, imaginary2);

            ComplexNumber multiple = complex1 * complex2;
            ComplexNumber divide = complex1 / complex2;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n\nMultipled 2 object is: {multiple}");
            Console.WriteLine($"\nDivided 2 object is: {divide}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Default()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This number of task this NOT exist");
            Console.ReadKey();
        }

        public void Task_6()
        {
            Console.Clear();
            Figure[] figures = new Figure[]
            {
                new Square(),
                new Rectungle()
            };

            for (int i = 0; i < figures.Length; i++)
            {
                figures[i].Draw();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_7()
        {
            Console.Write("for Square:\nImput X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Imput Y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("for Rectangle_R:\nImput X: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Imput Y: ");
            double y1 = double.Parse(Console.ReadLine());

            _2_Figure_ReadOnly[] figures = new _2_Figure_ReadOnly[]
            {
                new Square_R(x, y),
                new Rectangle_R(x1, y1)
            };

            for(int i=0; i<figures.Length; i++)
            {
                figures[i].Draw();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}


// Collections Theme:
/*
  List<Person> persons = new List<Person>();
persons.Add(new Person { Name = "Person 1", Age = 33, PhoneNumbers = new string[] { "+123-445-00", "3-098-22-33", "+20-00-33-44" } });
persons.Add(new Person { Name = "Person 1", Age = 33, PhoneNumbers = new string[] { "+123-445-00", "3-098-22-33", "+20-00-33-44" } });
persons.Add(new Person { Name = "Person 1", Age = 33, PhoneNumbers = new string[] { "+123-445-00", "3-098-22-33", "+20-00-33-44" } });
persons.Add(new Person { Name = "Person 1", Age = 33, PhoneNumbers = new string[] { "+123-445-00", "3-098-22-33", "+20-00-33-44" } });
     */
