using MyBooksLibrary.Data;
using MyBooksLibrary.Entity;
using MyBooksLibrary.Repo;
using System.ComponentModel;

var bookRepo = new SqlRepo<Book>(new LibraryDbContext());

AddBook(bookRepo);
AddCategory(bookRepo);
WriteAllConsole(bookRepo);

static void AddBook(IRepo<Book> bookRepo)
{
    bookRepo.Add(new Book { Title = "12 Życiowych Zasad Antidotum na Chaos", NameAuthor = "Jordan B.", SurnameAuthor = "Peterson", Page = 430, Rank = 1});
    bookRepo.Add(new Book { Title = "HBC Swiry u wladzy", NameAuthor = "Wojciech", SurnameAuthor = "Drewniak" , Page = 473, Rank = 1});
    bookRepo.Add(new Book { Title = "Wytrzymalosc Psychiczna", NameAuthor = "Chris", SurnameAuthor = "McNab", Page = 308, Rank = 2 });
    bookRepo.Save();
}

static void AddCategory(IWriteRepo<CategoryBook> catRepo)
{
    catRepo.Add(new CategoryBook { Title = "HBC I straszno i smieszno - PRL", NameAuthor = "Wojciech", SurnameAuthor = "Drewniak", Page = 442, Rank = 1, category = "HISTORIA" });
    catRepo.Add(new CategoryBook { Title = "Zarabiaj kiedy spisz", NameAuthor = "Szymon", SurnameAuthor = "Mierzwa", Page = 184, Rank = 2, category = "ROZWOJ OSOBISTY"});
    catRepo.Add(new CategoryBook { Title = "ABC kazdego mechanika", NameAuthor = "Bartosz", SurnameAuthor = "Zakrzewski", Page = 473, Rank = 1, category = "MECHANIZACJA" });
    catRepo.Save();
}

static void WriteAllConsole(IReadRepo<IEntity> repo)
{
    var items = repo.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}