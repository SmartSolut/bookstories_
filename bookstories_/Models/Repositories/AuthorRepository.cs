using System;
using System.Collections.Generic;
using System.Linq;

namespace bookstories_.Models.Repositories
{
    public class AuthorRepository : IBookstoreRepository<Authors>
    {
        // بيانات مؤلفين وهمية داخل الذاكرة
        private List<Authors> _authorList = new List<Authors>()
        {
            new Authors { id = 1, fullname = "Najeeb Alshamy" },
            new Authors { id = 2, fullname = "Ahmed Saleh" },
            new Authors { id = 3, fullname = "Fatima Al-Mutairi" }
        };

        public void Add(Authors entity)
        {
            entity.id = _authorList.Max(a => a.id) + 1;
            _authorList.Add(entity);
        }

        public void Delete(int id)
        {
            var author = _authorList.FirstOrDefault(a => a.id == id);
            if (author != null)
                _authorList.Remove(author);
        }

        public Authors Find(int id)
        {
            return _authorList.FirstOrDefault(a => a.id == id);
        }

        public IList<Authors> List()
        {
            return _authorList.ToList();
        }

        public void Update(int id, Authors entity)
        {
            var author = _authorList.FirstOrDefault(a => a.id == id);
            if (author != null)
            {
                author.fullname = entity.fullname;
            }
        }
    }
}
