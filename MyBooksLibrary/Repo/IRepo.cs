using MyBooksLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksLibrary.Repo
{
    public interface IRepo<T> : IReadRepo<T>, IWriteRepo<T>
        where T : class, IEntity, new()
    {
    }
}
