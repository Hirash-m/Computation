using Infrastructure.IRepository;
using Infrastructure.Models;


namespace Infrastructure.Repository
{
    public class PersonRepository : BaseRepository<Person, int> , IPersonRepository
    {
        private readonly ComputationContext ctx;

        public PersonRepository(ComputationContext ctx) :base(ctx) 
        {
            this.ctx = ctx;
        }

        public List<Person> GetPersons()
        {
           return ctx.Persons.ToList();
        }
    }
}
