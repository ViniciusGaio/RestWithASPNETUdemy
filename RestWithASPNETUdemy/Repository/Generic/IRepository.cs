using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Base;

namespace RestWithASPNETUdemy.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T Update(T item);
        List<T> FindAll();
        T FindById(int id);
        void Delete(int id);
        bool Exists(int id);

    }
}
