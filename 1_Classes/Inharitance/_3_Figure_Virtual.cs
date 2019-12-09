namespace Inharitance
{
    using System;
    
    public class _3_Figure_Virtual
    {
        readonly double x, y;

        public _3_Figure_Virtual(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
        public virtual void Draw()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\nIt is a figure is - ");
        }
    }

    public class Square_ : _3_Figure_Virtual
    {
        public Square_(double x, double y) : base(x, y) { }

        public override void Draw()
        {
            base.Draw();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Square");
            Console.ResetColor();
        }
    }

    public class Rectungle_ : _3_Figure_Virtual
    {
        public Rectungle_(double x, double y) : base(x, y) { }
        public override void Draw()
        {
            base.Draw();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Rectungle");
            Console.ResetColor();
        }
    }
}
