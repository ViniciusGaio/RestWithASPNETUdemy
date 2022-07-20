using RestWithASPNETUdemy.Data.VO;


namespace RestWithASPNETUdemy.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO Update(BookVO book);
        List<BookVO> FindAll();
        BookVO FindById(int id);
        void Delete(int id);
    }
}
