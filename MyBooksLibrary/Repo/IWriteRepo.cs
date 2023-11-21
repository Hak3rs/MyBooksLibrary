using MyBooksLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksLibrary.Repo
{
    public interface IWriteRepo<in T>
        where T : class, IEntity, new()
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }
}
