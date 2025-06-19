using System;
using System.Collections.Generic;
using System.Linq;

namespace bookstories_.Models.Repositories
{
    public class BookRepository : IBookstoreRepository<Books>
    {
        private List<Books> _bookList = new List<Books>()
        {
            new Books
            {
                Id = 1,
                Title = "C# Fundamentals",
                Description = "Introductory guide to C#",
                Author = new Authors { id = 1, fullname = "Najeeb Alshamy" },
                AuthorId = 1
            },
            new Books
            {
                Id = 2,
                Title = "ASP.NET Core MVC",
                Description = "Building web apps with MVC",
                Author = new Authors { id = 2, fullname = "Ahmed Saleh" },
                AuthorId = 2
            }
        };

        public void Add(Books entity)
        {
            entity.Id = _bookList.Max(b => b.Id) + 1;
            _bookList.Add(entity);
        }

        public void Delete(int id)
        {
            var book = _bookList.FirstOrDefault(b => b.Id == id);
            if (book != null)
                _bookList.Remove(book);
        }

        public Books Find(int id)
        {
            return _bookList.FirstOrDefault(b => b.Id == id);
        }

        public IList<Books> List()
        {
            return _bookList.ToList();
        }

        public void Update(int id, Books entity)
        {
            var book = _bookList.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                book.Title = entity.Title;
                book.Description = entity.Description;
                book.Author = entity.Author;
                book.AuthorId = entity.AuthorId;
            }
        }
    }
}
