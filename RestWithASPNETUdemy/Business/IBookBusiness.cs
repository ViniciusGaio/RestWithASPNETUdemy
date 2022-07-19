using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book Update(Book book);
        List<Book> FindAll();
        Book FindById(int id);
        void Delete(int id);
    }
}
