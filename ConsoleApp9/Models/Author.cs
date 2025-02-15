using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Models
{
    internal class Author
    {
        public string Authorname { get; set; }

        public string Yearborn { get; set; }

        public string Country { get; set; }

        public Author(string authorName, string yearborn, string country)
        {
           Authorname = authorName;

            Yearborn = yearborn;
            Country = country;
        }

        public override string ToString()
        {
            return $"Avtoris saxeli {Authorname} daibada {Yearborn} erovnebit iko {Country}";
        }
    }
}
