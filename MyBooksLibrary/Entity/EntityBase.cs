using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksLibrary.Entity
{
    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? NameAuthor { get; set; }
        public string? SurnameAuthor { get; set; }
        public int Page { get; set; }
        public int Rank { get; set; }
    }
}
