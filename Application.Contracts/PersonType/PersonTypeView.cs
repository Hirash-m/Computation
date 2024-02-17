using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.App;

namespace Application.Contracts.PersonType
{
    public class PersonTypeView
    {
        [DisplayName("کد")]
        public byte Id { get; set; }
        [DisplayName("نوع")]
        public string? Name { get; set; }
    }

    public class PersonTypeAdd
    {
        public string? Name { get; set; }
    }









    public interface IPersonTypeApp
    {
        List<PersonTypeView> GetPersonTypes();
        OperationResult AddPersonType(PersonTypeAdd command);
    }
    public interface IPersonTypeRepository
    {
        List<PersonTypeView> GetPersonTypes();
        bool Add(PersonTypeAdd command);
    }
}
