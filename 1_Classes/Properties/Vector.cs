namespace Properties
{
    using System;

    public class Vector
    {
        // Fields:
        int[] mass;
        int count, capasity;
        Random rand = new Random();

        // Constructors:
        public Vector()
        {
            count = 0;
            mass = new int[count];
            capasity = 5;
        }

        public Vector(int count)
        {
            this.count = count;
            mass = new int[count];
            FillArrayRand();
        }

        // Properties:
        public int Count { get { return count; } }
        public int Capacity
        {
            get { return capasity; }
            set
            {
                if (value > 0)
                    capasity = value;
            }
        }

        // Methods:
        public void PushBack(int elem)
        {
            int len = mass.Length;         // 5 elem the size of a current of an array
            int[] tmp = new int[len + 1];  // 6 elem the size of a temporary of an array
            for (int i = 0; i < len; i++)
                tmp[i] = mass[i];          // [3][4][5][3][4][0]

            tmp[len] = elem;
            len++;
            mass = tmp;
        }

        public void PopBack()
        {
            int len = mass.Length;         
            int[] tmp = new int[len - 1];  
            for (int i = 0; i < len - 1; i++)
                tmp[i] = mass[i];          

            len--;
            mass = tmp;
        }

        public void Insert(int pos, int elem)
        {
            int len = mass.Length;
            int[] tmp = new int[len + 1];
            for (int i = 0; i < pos; i++)
                tmp[i] = mass[i];
            tmp[pos] = elem;
            for (int i = pos + 1; i < len + 1; i++)
                tmp[i] = mass[i - 1];
            len++;
            mass = tmp;
        }

        public void Erase(int pos)
        {
            int len = mass.Length;
            int[] tmp = new int[len - 1];
            for (int i = 0; i < pos; i++)
                tmp[i] = mass[i];
            for (int i = pos + 1; i < len - 1; i++)
                tmp[i] = mass[i + 1];
            len--;
            mass = tmp;
        }

        public bool Empty()
        {
            if (mass.Length == 0)
                return true;
            else return false;
        }

        public int At(int index)
        {
            return mass[index];
        }

        public void Reverse()
        {
            Array.Reverse(mass);
        }

        public void Clear()
        {
            for (int i = 0; i < mass.Length; i++)
                Erase(i--);
        }

        public void Print()
        {
            for (int i = 0; i < mass.Length; i++)
                Console.Write($"  {mass[i]}");
        }

        public void FillArrayRand()
        {
            mass = new int[count];
            for (int i = 0; i < mass.Length; i++)
                mass[i] = rand.Next(10, 100);
        }
    }
}
