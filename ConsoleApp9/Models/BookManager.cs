using System.Collections.Generic;
using System;

namespace ConsoleApp9.Models
{
    internal class BookManager
    {
        private List<Book> books = new List<Book>();
        private List<Author> authorList = new List<Author>();
        private bool preAddedBooksLoaded = false;

        public void AddBook()
        {
            Console.WriteLine("Sheiyvanet wignis saxeli");
            string title = Console.ReadLine();
            Console.WriteLine("Sheiyvanet wignis gamoshvebis weli");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Sheiyvanet avtoris saxeli");  // Changed Write to WriteLine
            string authorName = Console.ReadLine();
            Console.WriteLine("Sheikvanet avtoris dabadebis tarighi");
            string yearBorn = Console.ReadLine();
            Console.WriteLine("Sheiyvanet avtoris warmomavloba ");
            string country = Console.ReadLine();
            Author author1 = new Author(authorName, country, yearBorn);
            books.Add(new Book(title, author1, year));
        }

        public void LoadPreAddedBooks()
        {
            if (!preAddedBooksLoaded)
            {
                books.Add(new Book("wigni1", new Author("avtori1", "1900", "qveyana1"), 1900));
                books.Add(new Book("wigni2", new Author("avtori2", "1800", "qveyana2"), 1800));
                preAddedBooksLoaded = true;
            }
        }

        public void DisplayAllbooks()
        {
            foreach (Book i in books)
            {
                Console.WriteLine(i);
            }
        }

        public void SearchByTitle()
        {
            Console.WriteLine("Chaweret wignis satauri");
            string titleSearch = Console.ReadLine();
            bool iffound = false;  

            foreach (Book i in books)
            {
                if (i.Title.ToLower().Contains(titleSearch.ToLower()))  
                {
                    Console.WriteLine(i);
                    iffound = true;
                }
            }

            if (!iffound)  
            {
                Console.WriteLine("Wigni am sataurit ver moidzebna");
            }
        }
    }
}