using Microsoft.EntityFrameworkCore;
using MyBooksLibrary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksLibrary.Data
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Book => Set<Book>();
        public DbSet<CategoryBook> CategoryBooks => Set<CategoryBook>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("LibraryAppDb");
        }
    }
}
