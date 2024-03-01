using Application.Contracts.Person;
using Application.Contracts.PersonType;
using Infrastructure.IRepository;
using Infrastructure.Models;
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
            var persons = personRepository.GetPersons();
            List<PersonView> personViews = new List<PersonView>();

            foreach (var person in persons)
            {
                PersonView personView = new PersonView
                {
                    ID = person.Id,
                    Name = person.Name,
                    Family=person.Family
                };

                personViews.Add(personView);
            }

            return personViews;
        }
    }
}
