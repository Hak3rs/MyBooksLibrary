using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksLibrary.Entity
{
    public interface IEntity
    {
        int Id { get; set; }
        string Title { get; set; }
        string NameAuthor { get; set; }
        string SurnameAuthor { get; set; }
        int Page { get; set; }
        int Rank { get; set; }
    }
}
