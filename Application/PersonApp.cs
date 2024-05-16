using Application.Contracts.AddressContracts;
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

        public int PersonCount()
        {
             return personRepository.CountPerson();

           
        }




        public List<PersonView> GetPersons(int skip , int row)
        {
            var persons = personRepository.GetPersons(skip , row);
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
                }).ToList(),
                Addresses = person.Addresses.Select(address =>
                new AddressView
                {
                    Id = address.Id,
                    Address1 = address.Address1,
                    RegionId = address.RegionId,
                    IsMain = address.IsMain,
                    TypeAdressId = address.TypeAdressId,
                    ZipCode = address.ZipCode,
                    Title = address.Title,

                }
                ).ToList()

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
                Phones = new List<Phone>(),
                Addresses = new List<Address>()
            };
            if (personAdd.Phones != null)
            {
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

                 }

                 if (personAdd.Addresses != null)
                {
                    // Add Addresses
                    foreach (var addressAdd in personAdd.Addresses) // Assuming 'Addresses' property exists in 'PersonAdd'
                    {
                        var address = new Address
                        {
                            Id = addressAdd.Id,
                            Address1 = addressAdd.Address1,
                            RegionId = addressAdd.RegionId,
                            IsMain = addressAdd.IsMain,
                            TypeAdressId = addressAdd.TypeAdressId,
                            ZipCode = addressAdd.ZipCode,
                            Title = addressAdd.Title,

                        };
                        newPerson.Addresses.Add(address);
                     }
                    }
                    var opersation = new OperationResult();
                    personRepository.AddPerson(newPerson);



                    return opersation.Succeeded();
                }

                public OperationResult PersonEdit(PersonAdd personAdd)
                {
                    var operation = new OperationResult();
                    var person = personRepository.Get(personAdd.ID);

                    // Update person information
                    person.Edit(personAdd.ID, personAdd.Name, personAdd.Family,
                                personAdd.NationalCode, personAdd.TypeId, personAdd.Email,
                                person.Phones, // Pass existing phones collection for now
                                person.Addresses); // Pass existing addresses collection for now

                    // Update Phones (existing code)
                    var phonesList = personAdd.Phones.Select(p => new Infrastructure.Models.Phone
                    {
                        Id = p.Id,
                        IsMain = p.IsMain,
                        Phone1 = p.Phone1,
                        Type = p.Type
                    }).ToList();

                    // Update existing phones or add new ones
                    foreach (var phone in phonesList)
                    {
                        var existingPhone = person.Phones.FirstOrDefault(ph => ph.Id == phone.Id);
                        if (existingPhone != null)
                        {
                            // Update existing phone
                            existingPhone.IsMain = phone.IsMain;
                            existingPhone.Phone1 = phone.Phone1;
                            existingPhone.Type = phone.Type;
                        }
                        else
                        {
                            // Add new phone
                            person.Phones.Add(phone);
                        }
                    }

                    // Update Addresses (new logic)
                    var addressesList = personAdd.Addresses.Select(a => new Infrastructure.Models.Address
                    {
                        // Assuming Address properties:
                        Id = a.Id,
                        Address1 = a.Address1,
                        RegionId = a.RegionId,
                        IsMain = a.IsMain,
                        TypeAdressId = a.TypeAdressId,
                        ZipCode = a.ZipCode,
                        Title = a.Title,

                    }).ToList();

                    // Update existing addresses or add new ones
                    foreach (var address in addressesList)
                    {
                        var existingAddress = person.Addresses.FirstOrDefault(a2 => a2.Id == address.Id);
                        if (existingAddress != null)
                        {
                            // Update existing address

                            existingAddress.Address1 = address.Address1;
                            existingAddress.RegionId = address.RegionId;
                            existingAddress.IsMain = address.IsMain;
                            existingAddress.TypeAdressId = address.TypeAdressId;
                            existingAddress.ZipCode = address.ZipCode;
                            existingAddress.Title = address.Title;
                        }
                        else
                        {
                            // Add new address
                            person.Addresses.Add(address);
                        }
                    }

                    personRepository.SaveChanges();
                    return operation.Succeeded();
                }

                public OperationResult PersonDelete(int id)
                {
                    var operation = new OperationResult();
                    var person = personRepository.Get(id);
                    if (person != null) personRepository.Delete(person);
                    return operation.Succeeded();
                }

       
    }

        }
