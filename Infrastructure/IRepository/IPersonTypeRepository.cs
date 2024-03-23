using Infrastructure.Models;

namespace Infrastructure.IRepository
{
    public interface IPersonTypeRepository : IRepository<PersonType , byte>
    {
        List<PersonType> GetPersonTypes();
        bool Add(PersonType command);
       
    }
}
