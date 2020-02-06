using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    /*
         Задание 3. 
    Созадть класс Книга(название, автор,  жанр, год издания). Для каждого поля описать свойства.
    Создать класс Домашняя библиотека. Предусмотреть возможность работы с произвольным числом книг, 
    поиска книги по какому-либо признаку(по автору, по году издания или жанру), добавления книги в библиотеку, 
    удаления книг из нее. Написать программу, демонстрирущую все разработанные элементы класса.
    */
    public class Book
    {
        string bookName, author, ganre;
        int yearPublishing;

        public Book() { }

        public Book(string bookName, string author, string ganre, int yearPublishing)
        {
            this.bookName = bookName;
            this.author = author;
            this.ganre = ganre;
            this.yearPublishing = yearPublishing;
        }

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        public string Autor
        {
            get { return author; }
            set { author = value; }
        }
        public string Ganre
        {
            get { return ganre; }
            set { ganre = value; }
        }
        public int YearPublishing
        {
            get { return yearPublishing; }
            set { yearPublishing = value; }
        }

        public void ShoBook()
        {
            Console.WriteLine($"\nBookName: {bookName}\nAutor: {author}\nGanre: {ganre}\nYearPublishing: {yearPublishing}");
        }

        public override string ToString()
        {
            return $"\nBookName: {bookName}\nAutor: {author}\nGanre: {ganre}\nYearPublishing: {yearPublishing}";
        }
    }

    public class HomeLibrary
    {
        Book[] books;
        public HomeLibrary(Book[] books)
        {
            this.books = books;
        }

        public void AddBook(Book book)
        {
            int length = books.Length;
            Book[] tmp = new Book[length + 1]; // [null][null][null][null][null][null]
            for (int i = 0; i < length; i++)
            {
                tmp[i] = books[i];      // [book1][book2][book3][book4][book5][null]     
                                        //    0      1      2      3      4     5
            }
            tmp[length] = book;
            length++;
            books = tmp;
        }

        public void SerchByName(string name)
        {
            bool flag = false;
            for (int i = 0; i < books.Length; i++)
            {
                if (name == books[i].BookName)
                {
                    flag = true;
                    Console.WriteLine(books[i]);
                    break;
                }
            }
            if (flag == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nBook with name - {name} NOT finded...Try again!");
                Console.ResetColor();
            }
        }

        public void SerchByAuthor(string author)
        {
            bool flag = false;
            for (int i = 0; i < books.Length; i++)
            {
                if (author == books[i].Autor)
                {
                    flag = true;
                    Console.WriteLine(books[i]);
                    break;
                }
            }
            if (flag == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nBook with author - {author} NOT finded...Try again!");
                Console.ResetColor();
            }
        }

        public void SerchByGanre(string ganre)
        {
            bool flag = false;
            for (int i = 0; i < books.Length; i++)
            {
                if (ganre == books[i].Ganre)
                {
                    flag = true;
                    Console.WriteLine(books[i]);
                    break;
                }
            }
            if (flag == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nBook with ganre - {ganre} NOT finded...Try again!");
                Console.ResetColor();
            }
        }

        public void SerchByYear(int year)
        {
            bool flag = false;
            for (int i = 0; i < books.Length; i++)
            {
                if (year == books[i].YearPublishing)
                {
                    flag = true;
                    Console.WriteLine(books[i]);
                    break;
                }
            }
            if (flag == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nBook with year of publish - {year} NOT finded...Try again!");
                Console.ResetColor();
            }
        }

        public void DeleteBook()
        {
            int length = books.Length;
            Book[] tmp = new Book[length - 1];
            for(int i = 0; i < length - 1; i++)
            {
                tmp[i] = books[i];
            }
            length--;
            books = tmp;
        }

        public void Print_all_info()
        {
            for (int i = 0; i < books.Length; i++) 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"\n{i + 1} book:");
                Console.ResetColor();
                Console.WriteLine(books[i]);
            }
        }
    }
}
