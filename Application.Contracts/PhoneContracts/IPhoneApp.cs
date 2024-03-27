using Application.Contracts.PersonType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.App;

namespace Application.Contracts.PhoneContracts
{
    public interface IPhoneApp
    {
        List<PhoneView> GetPhonesByPersonId(int personId);
        OperationResult AddPhone(Infrastructure.Models.Phone command,int personId);

        OperationResult DeletePhone(int id);
        OperationResult EditPhone(PhoneView command);
    }


    public class PhoneView
    {
        public int Id { get; set; }

        public bool IsMain { get; set; }

        public short Type { get; set; }

        public string Phone1 { get; set; } = null;
    }
}
