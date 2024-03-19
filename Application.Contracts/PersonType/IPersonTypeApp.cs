using Utility.App;

namespace Application.Contracts.PersonType
{
    public interface IPersonTypeApp
    {
        List<PersonTypeView> GetPersonTypes();
        OperationResult AddPersonType(Infrastructure.Models.PersonType command);

        OperationResult DeletePersonType(byte id);
    }
}
