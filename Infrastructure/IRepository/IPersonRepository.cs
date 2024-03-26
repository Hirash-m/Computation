using Infrastructure.Models;

namespace Infrastructure.IRepository

{
    public interface IPersonRepository : IRepository< Person , int>
    {
        List<Person> GetPersons();
        bool AddPerson(Person person);
        Person GetPerson(int id);

    }
}
