using Application.Contracts.PhoneContracts;
using Infrastructure.Models;
using Utility.App;


namespace Application
{
    public class PhoneApp : IPhoneApp
    {
        public OperationResult AddPhone(Phone command, int personId)
        {
            throw new NotImplementedException();
        }

        public OperationResult DeletePhone(int id)
        {
            throw new NotImplementedException();
        }

        public OperationResult EditPhone(PhoneView command)
        {
            throw new NotImplementedException();
        }

        public List<PhoneView> GetPhonesByPersonId(int personId)
        {
            throw new NotImplementedException();
        }
    }
}
