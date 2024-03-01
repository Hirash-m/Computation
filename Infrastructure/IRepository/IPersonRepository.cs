using Infrastructure.Models;

namespace Infrastructure.IRepository

{
    public interface IPersonRepository
    {
        List<Person> GetPersons();
    }
}
