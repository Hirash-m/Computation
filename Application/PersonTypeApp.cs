using Application.Contracts.PersonType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class PersonTypeApp : IPersonTypeApp
    {
        private readonly IPersonTypeRepository personTypeRepository;

        public PersonTypeApp(IPersonTypeRepository personTypeRepository)
        {
            this.personTypeRepository = personTypeRepository;
        }
        public List<PersonTypeView> GetPersonTypes()
        {
           return personTypeRepository.GetPersonTypes();
        }
    }
}
