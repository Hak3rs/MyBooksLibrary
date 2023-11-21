using MyBooksLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksLibrary.Repo
{
    public interface IReadRepo<out T>
        where T : class, IEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
