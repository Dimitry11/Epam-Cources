namespace Inharitance
{
    using System;

    public abstract class Figure
    {
        public abstract void Draw();
    }

    public class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Draving The Square!");
        }
    }

    public class Rectungle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Draving The Rectungle!");
        }
    }
}
