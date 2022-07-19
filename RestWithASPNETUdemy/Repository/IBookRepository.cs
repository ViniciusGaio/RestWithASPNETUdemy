using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Repository
{
    public interface IBookRepository
    {
        Book Create(Book book);
        Book Update(Book book);
        List<Book> FindAll();
        Book FindById(int id);
        void Delete(int id);
        bool Exists(int id);

    }
}
