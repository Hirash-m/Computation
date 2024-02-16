namespace Application.Contracts.Person
{
    public interface IPersonRepository
    {
        List<PersonView> GetPersons();
    }
}
