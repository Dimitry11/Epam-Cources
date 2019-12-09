namespace Inharitance
{
    using System;

    public class _4_Figure_Last : IDrawable
    {
        readonly double x, y;

        public _4_Figure_Last() { }

        public _4_Figure_Last(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void Draw() { }

        public void DrawAll(params IDrawable[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Draw();
            }
        }
    }

    public class Square_L : _4_Figure_Last
    {
        public Square_L(double x, double y) : base(x, y) { }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nDraw Square!\n");
        }
    }

    public class Rectungle_L : _4_Figure_Last
    {
        public Rectungle_L(double x, double y) : base(x, y) { }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Draw Rectungle");
            Console.ResetColor();
        }
    }
}
