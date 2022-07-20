using RestWithASPNETUdemy.Data.Converter.Contract;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Data.Converter.Implementations
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        //in
        public Book Parse(BookVO origin)
        {
            if (origin == null) return null;
            return new Book
            {
                Id = origin.Id,
                Author = origin.Author,
                Title = origin.Title,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
            };
        }
        //out
        public BookVO Parse(Book origin)
        {
            if (origin == null) return null;
            return new BookVO
            {
                Id = origin.Id,
                Author = origin.Author,
                Title = origin.Title,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
            };
        }
        //in
        public List<Book> Parse(List<BookVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
        //out
        public List<BookVO> Parse(List<Book> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
