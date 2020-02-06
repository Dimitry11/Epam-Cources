namespace Runner
{
    using System;
    using Classes;
    using Collections;
    using Inharitance;
    using System.Linq;
    using System.Threading;
    using System.Collections;
    using System.Collections.Generic;
    using Properties;

    class All_Tasks
    {
        IEnumerable<Person> persons;
        List<string> str_elem;
        Random rand;

        public All_Tasks()
        {
            rand = new Random();
            if (persons == null)
            {
                int countRand = rand.Next(5, 42);
                Random_Generator randPersons = new Random_Generator();
                persons = randPersons.GetPersonsRandom(countRand);
            }
        }
        public void Task_1()
        {
            Console.Clear();
            Point leftUp, rightLow;
            Console.WriteLine("Enter the upper and lower right corner coordinates: ");
            Console.Write("Input upper-left coord\nX: ");
            leftUp.X = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            leftUp.Y = double.Parse(Console.ReadLine());
            Console.Write("Input lower-right coord\nX: ");
            rightLow.X = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            rightLow.Y = double.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(leftUp, rightLow);
            Console.WriteLine($"Perimeter of Rectangle is: {rect.Perimenter()}");
            Console.WriteLine($"Area of Rectangle is: {rect.Area()}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_2()
        {
            Console.Clear();
            Point LeftUp, RightLow;
            Console.WriteLine("Enter the upper and lower right corner coordinates: ");
            Console.Write("Input upper-left coord\nX: ");
            LeftUp.X = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            LeftUp.Y = double.Parse(Console.ReadLine());
            Console.Write("Input lower-right coord\nX: ");
            RightLow.X = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            RightLow.Y = double.Parse(Console.ReadLine());
            Rectangle2 rect2 = new Rectangle2(LeftUp, RightLow);
            Console.WriteLine($"Perimeter of Rectangle is: {rect2.GetPerimetr}");
            Console.WriteLine($"Area of Rectangle is: {rect2.GetArea}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_3()
        {
            Console.Clear();
            Console.Write("Input radius: ");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            Console.WriteLine($"Length of a Circle is: {circle.Length_Circle()}");
            Console.WriteLine($"Area of a Circle is: {circle.Area_Circle()}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_4()
        {
            Console.Clear();
            Point left, right;
            Console.WriteLine("Static of Rectangle:\nEnter the upper and lower right corner coordinates: ");
            Console.Write("Input upper-left coord\nX: ");
            left.X = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            left.Y = double.Parse(Console.ReadLine());
            Console.Write("Input lower-right coord\nX: ");
            right.X = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            right.Y = double.Parse(Console.ReadLine());
            Rectangle_static.Set_Coordinates(left, right);
            Console.WriteLine($"Perimeter of Rectangle is: {Rectangle_static.Perimenter()}");
            Console.WriteLine($"Area of Rectangle is: {Rectangle_static.Area()}");
            Console.Write("\n\nStatic of Circle: \n\nInput radius: ");
            double r = double.Parse(Console.ReadLine());
            Circle_static.Set_Radius(r);
            Console.WriteLine($"Length of a Circle is: {Circle_static.Length_Circle}");
            Console.WriteLine($"Area of a Circle is: {Circle_static.Area_Circle}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_5()
        {
            Console.Clear();
            Console.WriteLine("Set 1st of the ComplexNumber\n");
            Console.Write("Input The RealNumber: ");
            double realNumber1 = double.Parse(Console.ReadLine());
            Console.Write("Imput imaginary: ");
            double imaginary1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\nSet 2nd of the ComplexNumber\n");
            Console.Write("Input The RealNumber: ");
            double realNumber2 = double.Parse(Console.ReadLine());
            Console.Write("Imput imaginary: ");
            double imaginary2 = double.Parse(Console.ReadLine());

            ComplexNumber complex1 = new ComplexNumber(realNumber1, imaginary1);
            ComplexNumber complex2 = new ComplexNumber(realNumber2, imaginary2);

            ComplexNumber multiple = complex1 * complex2;
            ComplexNumber divide = complex1 / complex2;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n\nMultipled 2 object is: {multiple}");
            Console.WriteLine($"\nDivided 2 object is: {divide}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Default()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This number of task this NOT exist");
            Console.ReadKey();
        }

        public void Task_6()
        {
            Console.Clear();
            Figure[] figures = new Figure[]
            {
                new Square(),
                new Rectungle()
            };

            for (int i = 0; i < figures.Length; i++)
            {
                figures[i].Draw();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_7()
        {
            Console.Clear();
            Console.Write("for Square:\nImput X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Imput Y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("\n\nfor Rectangle_R:\nImput X: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Imput Y: ");
            double y1 = double.Parse(Console.ReadLine());

            _2_Figure_ReadOnly[] figures = new _2_Figure_ReadOnly[]
            {
                new Square_R(x, y),
                new Rectangle_R(x1, y1)
            };

            for (int i = 0; i < figures.Length; i++)
            {
                figures[i].Draw();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_8()
        {
            Console.Clear();
            Console.Write("for Square:\nImput X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Imput Y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("\n\nfor Rectangle_R:\nImput X: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Imput Y: ");
            double y1 = double.Parse(Console.ReadLine());

            _3_Figure_Virtual[] figures = new _3_Figure_Virtual[]
            {
                new Square_(x, y),
                new Rectungle_(x1, y1)
            };

            for (int i = 0; i < figures.Length; i++)
            {
                figures[i].Draw();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_9()
        {
            Console.Clear();
            Console.Write("for Square:\nImput X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Imput Y: ");
            double y = double.Parse(Console.ReadLine());

            Square_L square = new Square_L(x, y);

            Console.Write("\n\nfor Rectangle_R:\nImput X: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Imput Y: ");
            double y1 = double.Parse(Console.ReadLine());

            Rectungle_L rectungle = new Rectungle_L(x1, y1);
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

            _4_Figure_Last figer4 = new _4_Figure_Last();
            figer4.DrawAll(square, rectungle);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_10()
        {
            List<Person> list = persons.ToList();
            Console.WriteLine(new String('-', 120));
            Console.WriteLine($"\t\t\t\t\t      Current List of The Person random({list.Count}) is:\n");
            Console.WriteLine(new String('-', 120));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t\t\t\t   {0,-13}  {1,5}", "Name:", "Age:");
            Console.WriteLine(new String('-', 120));
            Console.ForegroundColor = ConsoleColor.Green;



            for (int i = 0; i < list.Count; i++)
            {
                Console.ForegroundColor = ColorsRand()[i];
                Console.WriteLine("\t\t\t\t\t\t    {0,-13} {1,5}", list[i].Name, list[i].Age);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        ConsoleColor[] ColorsRand() // Method which Generating random of the Colors:
        {
            ConsoleColor[] colors = new ConsoleColor[]
            {
                 ConsoleColor.Blue,ConsoleColor.Cyan,ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,ConsoleColor.DarkMagenta,
                 ConsoleColor.DarkRed,ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,ConsoleColor.Magenta,ConsoleColor.Yellow,
                 ConsoleColor.Blue,ConsoleColor.Cyan,ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,ConsoleColor.DarkMagenta,
                 ConsoleColor.DarkRed,ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,ConsoleColor.Magenta,ConsoleColor.Yellow,
                 ConsoleColor.Blue,ConsoleColor.Cyan,ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,ConsoleColor.DarkMagenta,
                 ConsoleColor.DarkRed,ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,ConsoleColor.Magenta,ConsoleColor.Yellow,
                 ConsoleColor.Blue,ConsoleColor.Cyan,ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,ConsoleColor.DarkMagenta,
                 ConsoleColor.DarkRed,ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,ConsoleColor.Magenta,ConsoleColor.Yellow
            };

            return colors;
        }

        public void Task_11()
        {
            Person[] twoPersons = new Person[2];
            for (int i = 0; i < twoPersons.Length; i++)
            {
                twoPersons[i] = new Person();
                Console.ForegroundColor = ColorsRand()[i];
                Console.WriteLine($"\n\n{i + 1} Person:");
                Console.Write("Input Name: ");
                twoPersons[i].Name = Console.ReadLine();
                Console.Write("Input Age: ");
                twoPersons[i].Age = int.Parse(Console.ReadLine());
                Console.Write("Auto generating Phone Numbers...\n\n");
                twoPersons[i].PhoneNumbers = new Random_Generator().GetNumbersRandom(new Random().Next(2, 10));
                Thread.Sleep(new Random().Next(1000, 6000));
            }

            List<Person> lPersons = new List<Person>();
            lPersons.AddRange(twoPersons);
            Console.WriteLine(new String('-', 120));
            Console.WriteLine($"\t\t\t\t\t      Current List of The Person random({lPersons.Count}) is:\n");
            Console.WriteLine(new String('-', 120));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\t\t\t\t\t\t   {0,-13}", "Phone Numbers:");
            Console.WriteLine(new String('-', 120));
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < lPersons.Count; i++)
            {
                foreach (string numbers in lPersons[i].PhoneNumbers)
                {
                    Console.ForegroundColor = ColorsRand()[i];
                    Console.WriteLine("\t\t\t\t\t\t    {0,-13}", numbers);
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_12()
        {
            int choice = 0, i = 0, max = 0;
            str_elem = new List<string>();
            Console.Write("\nEnter a max list size. Limit from 100 to ..[maximum]: ");
            try
            {
                max = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your input was a string... Try integer for options!");
                Console.ReadKey(); Console.ResetColor();
            }

            str_elem.AddRange(Words_Rand(Count_List_Rand(max)));

            do
            {
                Console.Clear();
                Console.ForegroundColor = ColorsRand()[i++];
                Console.WriteLine("\n1 - Show All List of Words");
                Console.WriteLine("\n2 - Remove all duplicated items from the list");
                Console.WriteLine("\n3 - Remove all items starting with 'Z'");
                Console.WriteLine("\n4 - Sort all the list by DESCEND");
                Console.WriteLine("\n5 - Number of list Items");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\nMake your choice..");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your input was a string... Try integer for options!");
                    Console.ReadKey();
                }
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        ShowListElem(str_elem);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\nAll elements without All Duplicate is:");
                        HashSet<string> my_hesh = DeleteDuplicates();
                        Console.WriteLine("All elemnts start with 'X' is: ");
                        ShowListElem(my_hesh);
                        break;
                    case 3:
                        Console.Clear();
                        List_without_X();
                        ShowListElem(str_elem);
                        break;
                    case 4:
                        Console.Clear();
                        //IEnumerable<string> sorted = Desk_sort(str_elem);
                        //Console.WriteLine("Sorted elements by descended is: ");
                        //int count = 0;
                        //foreach (var sort in sorted)
                        //{
                        //    Console.Write($"\t\t\t\t\t           {count + 1} Element: ");
                        //    Console.WriteLine($"    {sort}");
                        //    count++;
                        //}

                        // Classics of Sorting by Descendens:
                        Console.WriteLine("Sorted elements by descended is: ");
                        int count = 0;
                        str_elem.Sort();
                        str_elem.Reverse();
                        foreach (string sort in str_elem)
                        {
                            Console.Write($"\t\t\t\t\t           {count + 1} Element: ");
                            Console.WriteLine($"    {sort}");
                            count++;
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine($"Number of list Items is: {str_elem.Count}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                }
            }
            while (choice != 0);
        }

        void ShowListElem(IEnumerable<string> str_elem)
        {
            int countColor = 0;
            Console.WriteLine($"Count random of element is: {str_elem.Count()}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to Show this Elements: ");
            Console.ReadKey();
            Console.Clear();
            foreach (string elem in str_elem)
            {
                Console.ForegroundColor = ColorsRand()[rand.Next(0, 47)];
                Console.Write($"\t\t\t\t\t           {countColor + 1} Element: ");
                Console.WriteLine($"   {elem}");
                countColor++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        string[] Words_Rand(int n)
        {
            string[] words = new string[n];

            for (int i = 0; i < words.Length; i++)
                words[i] += Symbols_Rand();

            return words;
        }

        string Symbols_Rand(int letters = 4)
        {
            char[] symbols = new char[letters]; // ['\0']['\0']['\0']['\0']

            for (int i = 0; i < symbols.Length; i++)
                symbols[i] += ((char)rand.Next('a', 'z'));

            return new string(symbols).ToUpper();
        }

        int Count_List_Rand(int max)
        {
            return rand.Next(100, max);
        }

        HashSet<string> DeleteDuplicates()
        {
            HashSet<string> duplicateRemove = new HashSet<string>(str_elem);

            return duplicateRemove;
        }
        // HashSet<string> DeleteDuplicates() => new HashSet<string>(str_elem);  -  .Net Core example

        public void List_without_X()
        {
            for (int i = str_elem.Count - 1; i >= 0; i--)
            {
                if (str_elem[i].StartsWith("X"))
                    str_elem.RemoveAt(i);
            }
        }

        IEnumerable<string> Desk_sort(List<string> words)
            =>
            from word in words orderby word.Substring(1, 0) descending select word;

        public void Task_13()
        {
            Console.Clear();
            ArrayList myAarrayList = new ArrayList();

            byte _byte = 255;
            myAarrayList.Add(234235);   // int
            myAarrayList.Add(115.2223); // double
            myAarrayList.Add('$');      // char
            myAarrayList.Add("string"); // string
            myAarrayList.Add(_byte);    // byte
            myAarrayList.Add(true);     // bool

            foreach (object item in myAarrayList)
                Console.WriteLine($"{item.GetType()}: {item}");

            //if (myObj.str.GetType() == typeof(string))
            //{
            //    Console.WriteLine("Type is Correct (Type is string)");
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Type is Uncorrect.. (Type is NOT a string)");
            //}

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        bool isPrime(int n)
        {
            if (n == 1) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % 2 == 0) return false;
            }

            return true;
        }

        public void Task_14()
        { 
            int size = 100;
            ArrayList arrPraime = new ArrayList();
            for (int i = 1; i < size; i++)
            {
                if (isPrime(i) == true)
                {
                    arrPraime.Add(i);
                }
            }

            foreach (object o in arrPraime)
                Console.WriteLine(o);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_15()
        {
            Random rand = new Random();
            int size = rand.Next(10, 20);
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < size; i++) 
            {
                arrayList.Add(rand.Next(10, 99));
            }
            int choice = 0;
            do
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine(new string('-', 120));
                Console.ForegroundColor = ConsoleColor.Magenta;
                foreach (object o in arrayList)
                    Console.Write($"  {o}");
                Console.ResetColor();
                Console.WriteLine("\n\n"+new string('-', 120));
                Console.WriteLine("1 - Delete 1st Element of the ListArray");
                Console.WriteLine("2 - Add a new element in the beginig");
                Console.WriteLine("3 - Delete last element ");
                Console.WriteLine("4 - Add a new element in the end");
                Console.WriteLine("5 - add a new element to the specified position");
                Console.WriteLine("6 - add array of an element to the specified position");
                Console.WriteLine("7 - Delete an element with the same of a value");
                Console.WriteLine("8 - Reverse");
                Console.WriteLine("9 - Clear All List");
                Console.WriteLine("0 - Exit");
                Console.Write("Please make your choice..");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch(Exception) { }
                switch (choice)
                {
                    case 1:
                        arrayList.RemoveAt(0);
                        break;
                    case 2:
                        Console.Write("Imput element: ");
                        object begin_elem = Console.ReadLine();
                        arrayList[0] = begin_elem;
                        break;
                    case 3:
                        size = arrayList.Count;
                        arrayList.RemoveAt(size - 1);
                        break;
                    case 4:
                        Console.Write("Imput element: ");
                        object end_elem = Console.ReadLine();
                        arrayList.Add(end_elem);
                        break;
                    case 5:
                        Console.Write("Imput position: ");
                        int poss = int.Parse(Console.ReadLine());
                        Console.Write("Imput element: ");
                        object el = Console.ReadLine();
                        arrayList.Insert(poss, el);
                        break;
                    case 6:
                        Console.Write("Imput position: ");
                        int pos_arr = int.Parse(Console.ReadLine());
                        Console.Write("Imput array of an elements: ");
                        object[] arr_elem = new object[] { 111, '$', "Hello World", 999.9, true, 2.3f };
                        arrayList.InsertRange(pos_arr, arr_elem);
                        break;
                    case 7:
                        Console.Write("Input an element to delete: ");
                        object same_elem = Console.ReadLine();
                        arrayList.Remove(same_elem);
                        break;
                    case 8: arrayList.Reverse(); break;
                    case 9: arrayList.Clear(); break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This number doesn't exists... Try again!");
                        Console.ReadKey(true);
                        Console.ResetColor();
                        break;
                }
            } while (choice != 0);
        }

        public void Task_16()
        {
            TV tv = new TV();
            Console.Write("Enter TV volume range 0 - 100: ");
            tv.Volume = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            string result = tv.Volume == 0 ? "Your value doesnt Entered in this Range 1-100" : $"{tv.Volume}";
            Console.WriteLine($"\n\nYour volume is:{result}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_17()
        {
            Console.Write("Imput side1: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Imput side2: ");
            double side2 = double.Parse(Console.ReadLine());
            Rectangle4 rect = new Rectangle4(side1, side2);
            Console.WriteLine($"Area is: {rect.Area}\nPerimetr is{rect.Perimetr}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
            Console.ReadKey();
            Console.ResetColor();
        }

        public void Task_18()
        {
            Book[] books = new Book[]
            {
                new Book("The Time Machine", "Herbert George Wells", "Fantastic", 1895),
                new Book("C# 8 VIA CLR", "A.Troelsen", "Programming", 2018),
                new Book("C# 4.0", "Herbert Shild", "Science", 2007),
                new Book("Clear Code", "Steve McConnel", "Programming", 2010),
                new Book("C++", "Bern Straustrup", "Documentary", 1981)
            };
                HomeLibrary library = new HomeLibrary(books);
            int choice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Add New Book in Home Library");
                Console.WriteLine("2 - Search Book By Name");
                Console.WriteLine("3 - Search Book By Author");
                Console.WriteLine("4 - Search Book By Genre");
                Console.WriteLine("5 - Search Book By Year Publishing");
                Console.WriteLine("6 - Delete Book");
                Console.WriteLine("7 - Show All Books");
                Console.WriteLine("0 - Exit");
                Console.Write("Please make your choice..");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();

                        Console.Write("Enter book name: ");
                        string nameBook = Console.ReadLine();

                        Console.Write("Enter book author: ");
                        string author = Console.ReadLine();

                        Console.Write("Enter book ganre: ");
                        string ganre = Console.ReadLine();

                        Console.Write("Enter book year of publish: ");
                        int year = int.Parse(Console.ReadLine());

                        Book newBook = new Book(nameBook, author, ganre, year);
                        library.AddBook(newBook);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("\nEnter name of the Book: ");
                        string name = Console.ReadLine();
                        library.SerchByName(name);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("\nEnter author of the Book: ");
                        string author1 = Console.ReadLine();
                        library.SerchByAuthor(author1);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("\nEnter ganre of the Book: ");
                        string ganre1 = Console.ReadLine();
                        library.SerchByGanre(ganre1);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("\nEnter year of publishing of the Book: ");
                        int years = int.Parse(Console.ReadLine());
                        library.SerchByYear(years);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    case 6:
                        try
                        {
                            library.DeleteBook();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("The last book was deleted successfully!");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
                            Console.ReadKey();
                            Console.ResetColor();
                        }
                        catch 
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Something went wrong...book was NOT deleted ...! ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
                            Console.ReadKey();
                            Console.ResetColor();
                            Console.ResetColor();
                        }
                        break;
                    case 7:
                        Console.Clear();
                        library.Print_all_info();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"This number doesn't exist...Try again!");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                }

            } while (choice != 0);         
        }

        public void Task_19()
        {
            int choice = 0;
            Console.Clear();
            Console.Write("Enter size of an Array: ");
            int size = int.Parse(Console.ReadLine());
            Vector vector = new Vector(size);
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(new string('-', 120));
                vector.Print();
                Console.WriteLine("\n\n"+new string('-', 120));
                Console.ResetColor();
                Console.WriteLine("1 - PushBack – добавляет элемент в конец вектора;");
                Console.WriteLine("2 - PopBack – удаляет элемент с конца вектора");
                Console.WriteLine("3 - Insert – вставляет элемент в нужную позицию");
                Console.WriteLine("4 - Erase – удаляет элемент с нужной позиции");
                Console.WriteLine("5 - Empty – делает проверку, пустой ли вектор");
                Console.WriteLine("6 - At – возвращает значение элемента, индекс которого принимает метод");
                Console.WriteLine("7 - Reverse – делает реверс вектора");
                Console.WriteLine("8 - Clear – очищает вектор");
                Console.WriteLine("9 - Fill all element to random");
                Console.WriteLine("0 - Exit application");
                Console.Write("Please make your choice...");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter element for add in Array: ");
                        int element = int.Parse(Console.ReadLine());
                        vector.PushBack(element);
                        Console.Clear();
                        break;
                    case 2:
                        vector.PopBack();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write("Enter position: ");
                        int position = int.Parse(Console.ReadLine());
                        Console.Write("Enter element: ");
                        int elem = int.Parse(Console.ReadLine());
                        vector.Insert(position, elem);
                        Console.Clear();
                        break;
                    case 4:
                        Console.Write("Enter position for delete: ");
                        int posDel = int.Parse(Console.ReadLine());
                        vector.Erase(posDel);
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        if (vector.Empty() == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("THis Array is Empty... Try Fill it!");
                            Console.ResetColor();
                        }
                        else Console.WriteLine("This Array is NOT Empty!");
                        break;
                    case 6:
                        Console.Clear();
                        Console.Write("Enter index: ");
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine($"\nIndex [{index}] = {vector.At(index)}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                    case 7:
                        vector.Reverse();
                        Console.Clear();
                        break;
                    case 8:
                        vector.Clear();
                        Console.Clear();
                        break;
                    case 9:
                        Console.Clear();
                        vector.FillArrayRand();
                        break;
                    default:
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"This number doesn't exist...Try again!");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t\t\t\t\t       Press any Key to continue..");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;
                }
            } while (choice != 0);
        }
    }
}


