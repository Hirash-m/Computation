using Application.Contracts.PhoneContracts;
using Infrastructure.IRepository;
using Infrastructure.Models;
using Utility.App;


namespace Application
{
    public class PhoneApp : IPhoneApp
    {
        private readonly IPhoneRepository _phoneRepository;

        public PhoneApp(IPhoneRepository phoneRepository)
        {
            this._phoneRepository = phoneRepository;
        }
        public OperationResult AddPhone(Phone command, int personId)
        {
            throw new NotImplementedException();
        }

        

        public OperationResult DeletePhone(int id)
        {
            var operation = new OperationResult();
            var phone = _phoneRepository.Get(id);
            if (phone != null)  _phoneRepository.Delete(phone);
           return operation.Succeeded();
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
