using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Models
{
    internal class Book
    {

        public string Title { get; set; }
        public Author Author { get; set; }
        public int Year { get; set; }
        public Book(string title, Author author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }


        public override string ToString()
        {
            return $" Saxelwodeba {Title}, Gamoica {Year} -Shi    {Author}";
        }


    }

   
}

