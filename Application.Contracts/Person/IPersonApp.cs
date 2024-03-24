using Azure;
using Utility.App;

namespace Application.Contracts.Person
{
    public interface IPersonApp

    {
        List<PersonView> GetPersons();
        OperationResult PersonAdd(PersonAdd personAdd);
    }
}
