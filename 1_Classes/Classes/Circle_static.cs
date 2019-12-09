namespace Classes
{
    public static class Circle_static
    {
        const double pi = 3.14159;
        static double radius;

        public static void Set_Radius(double r) => radius = r;

        public static double Length_Circle =>  2 * pi * radius;

        public static double Area_Circle =>  pi * radius * radius;
    }
}
