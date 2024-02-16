using Application.Contracts.PersonType;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PersonTypeRepository : IPersonTypeRepository
    {
        private readonly ComputationContext ctx;

        public PersonTypeRepository(ComputationContext ctx)
        {
            this.ctx = ctx;
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
