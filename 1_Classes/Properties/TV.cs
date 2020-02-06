using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    /*  Task 1:
   Создайте класс Телевизор, обьявите в нем поле громкость звука, для доступа к этому полю реализуйте 
   свойство. Громкость может быть в диапазоне от 0 до 100. */
    public class TV
    {
        double volume;
        public double Volume
        {
            get
            {
                return volume;
            }
            set
            {
                // Громкость может быть в диапазоне от 0 до 100:
                if (value >= 0 && value <= 100)
                    volume = value;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Volume is: {Volume}");
        }
    }
}
