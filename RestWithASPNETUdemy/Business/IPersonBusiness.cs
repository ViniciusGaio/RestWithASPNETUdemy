using RestWithASPNETUdemy.Data.VO;

namespace RestWithASPNETUdemy.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO Update(PersonVO person);
        List<PersonVO> FindAll();
        PersonVO FindById(int id);
        void Delete(int id);

    }
}
