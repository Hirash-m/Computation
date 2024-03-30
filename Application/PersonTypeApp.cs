using Application.Contracts.PersonType;
using Infrastructure.IRepository;
using Infrastructure.Models;
using Utility.App;

namespace Application
{
    public class PersonTypeApp : IPersonTypeApp
    {
        private readonly IPersonTypeRepository personTypeRepository;

        public PersonTypeApp(IPersonTypeRepository personTypeRepository)
        {
            this.personTypeRepository = personTypeRepository;
        }

        public OperationResult AddPersonType(Infrastructure.Models.PersonType command)
        {
            var operation = new OperationResult();
            var existingPersonType = personTypeRepository.GetPersonTypes().FirstOrDefault(p => p.Name == command.Name);

            if (existingPersonType != null)
            {
               return operation.Failed(".نوع تکراری میباشد ");
            }

            personTypeRepository.Add(command);

            return operation.Succeeded();


        }

        public OperationResult DeletePersonType(byte id)
        {
            var operation = new OperationResult();
            var personType = personTypeRepository.Get(id);
            if (personType != null)
            {
                personTypeRepository.Delete(personType);
                return operation.Succeeded();
            }
            else
            {
                return operation.Failed("مورد انتخاب شده وجود ندارد");
            }

        }

        public OperationResult EditPersonType(PersonTypeView command)
        {
            var operation = new OperationResult();
            var personType = personTypeRepository.Get(command.Id);
            var existingPersonType = personTypeRepository.GetPersonTypes().FirstOrDefault(p => p.Name == command.Name);
            if (existingPersonType != null)
            {
                return operation.Failed(". نوع تکراری میباشد ");
            }
            else
            {
                personType.Edit(command.Id, command.Name);
                personTypeRepository.SaveChanges();
                return operation.Succeeded();
            }
        }

        public List<PersonTypeView> GetPersonTypes()
        {
            var personTypes = personTypeRepository.GetPersonTypes();
            List<PersonTypeView> personTypeViews = new List<PersonTypeView>();

            foreach (var personType in personTypes)
            {
                PersonTypeView personTypeView = new PersonTypeView
                {
                    Id = personType.Id,
                    Name = personType.Name
                };

                personTypeViews.Add(personTypeView);
            }

            return personTypeViews;
        }
    }
}
