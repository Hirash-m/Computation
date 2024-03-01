using Infrastructure.Models;

namespace Infrastructure.IRepository
{
    public interface IPersonTypeRepository
    {
        List<PersonType> GetPersonTypes();
        bool Add(PersonType command);
    }
}
