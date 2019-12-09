namespace Classes
{
    public class Circle
    {
        const double pi = 3.14159;
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Length_Circle()
        {
            double length = 2 * pi * radius;

            return length;
        } 
  
        public double Area_Circle()
        {
            double area = pi * radius * radius;
            return area;
        }
    }
}