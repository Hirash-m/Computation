
using Infrastructure.IRepository;
using Infrastructure.Models;


namespace Infrastructure.Repository
{
    public class PersonTypeRepository : BaseRepository<PersonType, byte> , IPersonTypeRepository 
    {
        private readonly ComputationContext ctx;

        public PersonTypeRepository(ComputationContext ctx) : base(ctx) 
        {
            this.ctx = ctx;
        }

        public bool Add(PersonType command)
        {
            var personType = new PersonType { Name = command.Name};
            ctx.PersonTypes.Add(personType);
            ctx.SaveChanges();
            return true;

        }

        

        public List<PersonType> GetPersonTypes()
        {
            return ctx.PersonTypes.ToList();
        }
    }
}
