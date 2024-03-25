using Application.Contracts.Person;
using Application.Contracts.PersonType;
using Infrastructure.IRepository;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.App;

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
                    Family = person.Family,
                    PersonTypeName = person.Type.Name,
                    NationalCode= person.NationalCode,
                    Email =person.Email,
                    personType =person.Type

                   
                };

                personViews.Add(personView);
            }

            return personViews;
        }

        public OperationResult PersonAdd(PersonAdd personAdd)
        {

            var newPerson = new Person
            {
                Name = personAdd.Name,
                Family = personAdd.Family,
                TypeId = personAdd.TypeId,
                NationalCode = personAdd.NationalCode,
                Email = personAdd.Email

            };

            var opersation = new OperationResult();
            personRepository.AddPerson(newPerson);



            return opersation.Succeeded();
        }

        public OperationResult PersonEdit(PersonAdd personAdd)
        {
            var operation = new OperationResult();
            var Person = personRepository.Get(personAdd.ID);

            Person.Edit(personAdd.ID, personAdd.Name, personAdd.Family,
                personAdd.NationalCode, personAdd.TypeId, personAdd.Email);
            personRepository.SaveChanges();
            return operation.Succeeded();
        }
    }
}
