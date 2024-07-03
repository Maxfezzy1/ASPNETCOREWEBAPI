using ASPNETCOREWEBAPI.Entities;

namespace ASPNETCOREWEBAPI.Data
{
    public class BookData : IBookData
    {
        public Book AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync<T>(T obj)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> ListBooks()
        {

            return new List<Book>
            {
                new Book
                {
                     Author = "Ifenna",
                     Description = "Description",
                     Id = 1,
                     ISBN = "Isbn",
                     Publisher = "Mark",

                },

                 new Book
                {
                     Author = "Markson",
                     Description = "Description2",
                     Id = 2,
                     ISBN = "Isbn2",
                     Publisher = "BNXN",

                },

                  new Book
                {
                     Author = "Angel",
                     Description = "Description3",
                     Id = 3,
                     ISBN = "Isbn3",
                     Publisher = "Killerfreak",

                },

                   new Book
                {
                     Author = "Zark",
                     Description = "Description4",
                     Id = 4,
                     ISBN = "Isbn4",
                     Publisher = "Farouk",

                }
            };

        }

        public Task<IEnumerable<Book>> ListBooksAsync()
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync<T>(T obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> saveAsync<T>(T obj)
        {
            throw new NotImplementedException();
        }

        public Book UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public object UpdateBook(object book)
        {
            throw new NotImplementedException();
        }
    }
}
