using Application.Contracts.PersonType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public OperationResult AddPersonType(PersonTypeAdd command)
        {
            var operation = new OperationResult();
            var existingPersonType = personTypeRepository.GetPersonTypes().FirstOrDefault(p => p.Name == command.Name);

            if (existingPersonType != null)
            {
               return operation.Failed("نوع تکراری میباشد .");
            }

            personTypeRepository.Add(command);

            return operation.Succeeded();


        }

        public List<PersonTypeView> GetPersonTypes()
        {
           return personTypeRepository.GetPersonTypes();
        }
    }
}
