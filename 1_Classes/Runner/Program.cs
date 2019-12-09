using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        #region Main():
        static void Main(string[] args)
        {
            Console.Title = "Epam Academy Tasks";
            All_Tasks tasks = new All_Tasks();
            Console.Title = "All TAsks for Epam";
            int choice = 0;
            do
            {
                Console.Clear();
                choice = Menu();
                switch (choice)
                {
                    case 1: tasks.Task_1(); break;
                    case 2: tasks.Task_2(); break;
                    case 3: tasks.Task_3(); break;
                    case 4: tasks.Task_4(); break;
                    case 5: tasks.Task_5(); break;
                    case 6: tasks.Task_6(); break;
                    case 7: tasks.Task_7(); break;
                    case 8: tasks.Task_8(); break;
                    case 9: tasks.Task_9(); break;
                    case 10: tasks.Task_10(); break;
                    case 11: tasks.Task_11(); break;
                    case 12: tasks.Task_12(); break;
                    case 13: tasks.Task_13(); break;
                    case 14: tasks.Task_14(); break;
                    case 15: tasks.Task_15(); break;
                    default:tasks.Default(); break;
                }
            } while (choice != 0);
        }
        #endregion

        #region Menu():
        static int Menu()
        {
            int choice = 0;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\t\t\t\t\t\t The Topic - 'Classes': ");
            Console.WriteLine("1 - Area & Perieter of the Rectangle");
            Console.WriteLine("2 - Area & Perieter of the Rectangle (using Auto-Implemented Properties)");
            Console.WriteLine("3 - Circle. Output Length & Area of a Circle");
            Console.WriteLine("4 - 1st & 3rd of the tasks Using Static classes");
            Console.WriteLine("5 - ComplexNumber");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t\t\t\t\t\t The Topic - 'Inheritance': ");
            Console.WriteLine("6. Figure: Square & Rectangle(Draw())");
            Console.WriteLine("7. Figure: ReadOnly");
            Console.WriteLine("8. Figure: Using Virtual Method");
            Console.WriteLine("9. Figure: Add IDrawable");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\t\t\t\t\t\t The Topic - 'Collections': ");
            Console.WriteLine("10. Person: Output - name, age, phone number");
            Console.WriteLine("11. Person: Add two persons");
            Console.WriteLine("12. Person: DisplayName() pageNumber");
            Console.WriteLine("13. Class ArrayList 1");
            Console.WriteLine("14. Class ArrayList 2 (Prime elements)");
            Console.WriteLine("15. Class ArrayList 3 (Main operations)");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t\t\t\t Please make your choice...");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\n\tPress any Key to continue..");
                Console.ReadKey();
                Console.ResetColor();
            }
            return choice;
        }
        #endregion
    }
}
