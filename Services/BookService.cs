using BookApi.Interfaces;

namespace BookApi.Services;

public class BookService : IBookService
{
    public List<string> GetAll()
        => new List<string> { "Clean Code", "DDD", "C# in Depth" };
}
