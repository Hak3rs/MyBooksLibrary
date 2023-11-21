using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksLibrary.Entity
{
    public class CategoryBook : Book
    {
        public string? category { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\nCategory: {category}\t(Category)";
        }
    }
}
