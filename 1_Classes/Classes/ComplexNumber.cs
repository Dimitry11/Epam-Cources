#region Assembly Classes:
namespace Classes
{
    #region ComplexNumber:
    public class ComplexNumber
    {
        #region Fields:
        double realNumber, imagionary;
        #endregion

        #region Constructor:
        public ComplexNumber(double realNumber, double imagionary)
        {
            this.realNumber = realNumber;
            this.imagionary = imagionary;
        }
        #endregion

        #region Properties:
        public double RealNumber
        {
            get { return realNumber; }
            set { realNumber = value; }
        }
      
        public double Imaginary
        {
            get { return imagionary; }
            set { imagionary = value; }
        }
        #endregion

        #region Overload Operation '*' & '/':
        public static ComplexNumber operator *(ComplexNumber obj1, ComplexNumber obj2)
        {
            return new ComplexNumber(obj1.realNumber * obj2.realNumber, obj1.imagionary * obj2.imagionary);
        }

        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.realNumber / c2.realNumber, c1.imagionary / c2.imagionary);
        }
        #endregion

        #region Represent an Object:
        public override string ToString()
        {
            return $"({realNumber}, {imagionary})";
        }
        #endregion
    }
    #endregion
}
#endregion
