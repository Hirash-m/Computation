using Application.Contracts.Person;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ComputationContext ctx;

        public PersonRepository(ComputationContext ctx)
        {
            this.ctx = ctx;
        }

        public List<PersonView> GetPersons()
        {
           return ctx.Persons.Select(c => new PersonView
            {
                ID = c.Id,
                Name = c.Name,
                Family = c.Family
            }).ToList();
        }
    }
}
