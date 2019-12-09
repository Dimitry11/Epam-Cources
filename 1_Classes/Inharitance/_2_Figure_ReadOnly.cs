namespace Inharitance
{
    using System;

    public abstract class _2_Figure_ReadOnly
    {
        protected readonly double X, Y;

        public _2_Figure_ReadOnly(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public abstract void Draw();
    }

    public class Square_R : _2_Figure_ReadOnly
    {
        public Square_R(double X, double Y) : base(X, Y) { }

        public override void Draw()
        {
            Console.WriteLine($"Square_Readonly with Point: X: {X} Y: {Y}");
        }
    }

    public class Rectangle_R : _2_Figure_ReadOnly
    {
        public Rectangle_R(double X, double Y) : base(X, Y) { }

        public override void Draw()
        {
           Console.WriteLine($"Rectungle ReadOnly with Point: X: {X} Y: {Y}");
        }
    }
}
