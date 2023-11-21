using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksLibrary.Entity
{
    public class Book : EntityBase
    {
        public string? Title { get; set; }
        public string? NameAuthor { get; set; }
        public string? SurnameAuthor { get; set; }

        public override string ToString()
        {
            return "======================================================\n" +
                "Id: " + Id +
                "\nTITLE: " + Title +
                "\nAUTHOR: " + NameAuthor + " " + SurnameAuthor +
                "\nPAGE: " + Page +
                "\nRANK: " + Rank;
        }
    }
}
