using Application.Contracts.AddressContracts;
using Infrastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.App;

namespace Application
{
    public class AddressApp : IAddressApp
    {
        private readonly IAddressRepository _addressRepository;

        public AddressApp(IAddressRepository addressRepository)
        {
            this._addressRepository = addressRepository;
        }
        OperationResult IAddressApp.DeleteAddress(int id)
        {
            var operation = new OperationResult();
            var address = _addressRepository.Get(id);
            if (address!= null)
            {
                _addressRepository.Delete(address);
            }
            return operation.Succeeded();
        }
    }
}
