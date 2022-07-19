using RestWithASPNETUdemy.Data;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Repository.Implementations
{
    public class BookRepositoryImplementation : IBookRepository
    {
        private readonly ApplicationDbContext _context; 

        public BookRepositoryImplementation(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Book> FindAll()
        {
            return _context.Books.ToList();
        }

        public Book FindById(int id)
        {

            return _context.Books.SingleOrDefault(b => b.Id.Equals(id));

        }


        public Book Create(Book book)
        {
            try
            {
                _context.Add(book);
                _context.SaveChanges();

            }
            catch (Exception)
            { 
                throw;
            }
            return book;
        }
        public Book Update(Book book)
        {
            if (!Exists(book.Id)) throw new KeyNotFoundException("Book not found");

            var result = _context.Books.SingleOrDefault(b => b.Id.Equals(book.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(book);
                    _context.SaveChanges();

                }
                catch (Exception)
                {
                    throw;
                }
            }

            return book;
        }


        public void Delete(int id)
        {
            var result = _context.Books.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Books.Remove(result);
                    _context.SaveChanges();

                }
                catch (Exception)
                {
                    throw;
                }
            }

        }

        public bool Exists(int id)
        {
            return _context.Books.Any(p => p.Id.Equals(id));
        }
    }
}
