using Azure;
using Utility.App;

namespace Application.Contracts.Person
{
    public interface IPersonApp

    {
        List<PersonView> GetPersons(int skip,int rows);
        OperationResult PersonAdd(PersonAdd personAdd);
        OperationResult PersonEdit(PersonAdd personAdd);
        PersonView GetPerson(int id);
        OperationResult PersonDelete(int id);
        int PersonCount();

    }
}
