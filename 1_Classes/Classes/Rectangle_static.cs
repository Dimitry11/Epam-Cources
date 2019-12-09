namespace Classes
{
    public static class Rectangle_static
    {
        static Point leftUp, rightLow;

        public static void Set_Coordinates(Point l, Point r)
        {
            leftUp.X = l.X;
            leftUp.Y = l.Y;
            rightLow.X = r.X;
            rightLow.Y = r.Y;
        }

        public static double Perimenter()
        {
            return AbsoluteNumber(leftUp.X - rightLow.X) * 2 +
                          (leftUp.Y - rightLow.Y) * 2;
        }

        public static double Area()
        {
            return AbsoluteNumber(leftUp.X - rightLow.X) * (leftUp.Y - rightLow.Y);
        }


        static double AbsoluteNumber(double value)
        {
            // Если мы передали отрицательное число, то возратиться положительное, усли положительное,
            // то без изменений:
            return value <= 0.0 ? 0.0 - value : value;
        }
    }
}
