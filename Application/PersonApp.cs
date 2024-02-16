using Application.Contracts.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class PersonApp : IPersonApp
    {
        private readonly IPersonRepository personRepository;

        public PersonApp(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public List<PersonView> GetPersons()
        {
            return personRepository.GetPersons();
        }
    }
}
