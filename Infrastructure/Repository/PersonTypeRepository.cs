using Application.Contracts.PersonType;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PersonTypeRepository : BaseRepository<PersonType, int> , IPersonTypeRepository
    {
        private readonly ComputationContext ctx;

        public PersonTypeRepository(ComputationContext ctx) : base(ctx) 
        {
            this.ctx = ctx;
        }

        public bool Add(PersonTypeAdd command)
        {
            var personType = new PersonType { Name = command.Name};
            ctx.PersonTypes.Add(personType);
            ctx.SaveChanges();
            return true;

        }

        public List<PersonTypeView> GetPersonTypes()
        {
            return ctx.PersonTypes.Select(c => new PersonTypeView
            {
                Id = c.Id,
                Name = c.Name
            }).ToList();
        }
    }
}
