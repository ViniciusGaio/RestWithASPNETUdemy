namespace RestWithASPNETUdemy.Model.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person Update(Person person);
        List<Person> FindAll();
        Person FindById(int id);
        void Delete(int id);

    }
}
