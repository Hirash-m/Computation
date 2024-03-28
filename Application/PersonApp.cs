using Application.Contracts.Person;
using Application.Contracts.PersonType;
using Application.Contracts.PhoneContracts;
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
                    NationalCode = person.NationalCode,
                    Email = person.Email,
                    personType = person.Type,


                };

                personViews.Add(personView);
            }

            return personViews;
        }

        public PersonView GetPerson(int id)
        {
            var person = personRepository.GetPerson(id);

            PersonView personView = new PersonView
            {
                ID = person.Id,
                Name = person.Name,
                Family = person.Family,
                PersonTypeName = person.Type.Name,
                NationalCode = person.NationalCode,
                Email = person.Email,
                personType = person.Type,
                Phones = person.Phones.Select(phone => new PhoneView
                {
                    
                    Id = phone.Id,
                    Phone1 = phone.Phone1,
                    Type = phone.Type,
                    IsMain = phone.IsMain
                }).ToList()

            };
            return personView;
        }




        public OperationResult PersonAdd(PersonAdd personAdd)
        {

            var newPerson = new Person
            {
                Name = personAdd.Name,
                Family = personAdd.Family,
                TypeId = personAdd.TypeId,
                NationalCode = personAdd.NationalCode,
                Email = personAdd.Email,
                Phones = new List<Phone>()
            };
            foreach (var phoneadd in personAdd.Phones)
            {
                var phone = new Phone
                {
                    IsMain = phoneadd.IsMain,
                    Phone1 = phoneadd.Phone1,
                    Type = phoneadd.Type
                };
                newPerson.Phones.Add(phone);
            };
            var opersation = new OperationResult();
            personRepository.AddPerson(newPerson);



            return opersation.Succeeded();
        }

        public OperationResult PersonEdit(PersonAdd personAdd)
        {
            var operation = new OperationResult();
            var Person = personRepository.Get(personAdd.ID);
            var phonesList = personAdd.Phones.Select(p => new Infrastructure.Models.Phone
            {
                Id = p.Id,
                IsMain = p.IsMain,
                Phone1 = p.Phone1,
                Type = p.Type
            }).ToList();

            Person.Edit(personAdd.ID, personAdd.Name, personAdd.Family,
                personAdd.NationalCode, personAdd.TypeId, personAdd.Email, phonesList);
            personRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult PersonDelete(int id)
        {
            var operation = new OperationResult();
            personRepository.DeleteById(id);
                return operation.Succeeded();
        }
    }
}
