namespace Classes
{
    public class Rectangle2
    {
        Point UpLeft { get; set; }
        Point LowRight { get; set; }
        double Area { get; set; }
        double Perimetr { get; set; }

        public Rectangle2(Point UpLeft, Point LowRight)
        {
            this.UpLeft = UpLeft;
            this.LowRight = LowRight;
            Area = AbsoluteNumber(UpLeft.X - LowRight.X) * (UpLeft.Y - LowRight.Y);
            Perimetr = AbsoluteNumber(UpLeft.X - LowRight.X) * 2 + (UpLeft.Y - LowRight.Y) * 2;
        }

        // Properties (ReadOnly) to get accessible to private of fields:
        public double GetArea => Area;
        public double GetPerimetr => Perimetr;
        // Method to get absolutely of number:
        double AbsoluteNumber(double number) => (number <= 0.0) ? 0.0 - number : number;
    }
}
