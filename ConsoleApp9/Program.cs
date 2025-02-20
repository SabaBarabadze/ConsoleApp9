using ConsoleApp9.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static List<Book> books = new List<Book>();
        static void Main(string[] args)

        {


          
     
     
            BookManager manager = new BookManager();
           

            books.Add(new Book("wigni1", new Author("avtori1", "1900", "qveyana1"), 1900));
            books.Add(new Book("wigni2", new Author("avtori2", "1800", "qveyana2"), 1800));
        

            while (true)
            {
                Console.WriteLine("Book Manager");
                Console.WriteLine("1 Daamate wigni");
                Console.WriteLine("2 Daatvaliere wignebi");
                Console.WriteLine("3 Modzebne wigni sataurit");
                Console.WriteLine("4 Dasruleba");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        manager.AddBook();
                        break;
                    case "2":
                        manager.LoadPreAddedBooks();
                        manager.DisplayAllbooks();
                       

                        break;
                    case "3":
                        manager.SearchByTitle();
                        break;
                        case "4":
                        return;
                }
            }
        }



    }


        


    }





