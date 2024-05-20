using Application;
using Application.Contracts.AddressContracts;
using Application.Contracts.Inventory;
using Application.Contracts.Person;
using Application.Contracts.PersonType;
using Application.Contracts.PhoneContracts;
using Application.Contracts.ProductContract;
using Infrastructure.IRepository;
using Infrastructure.Models;
using Infrastructure.Repository;

namespace Computation.UI
{
    public class UnitOfWork : IDisposable
    {
        private ComputationContext db = new ComputationContext();


        private IPersonApp _personApp;
        private IPersonRepository _personRepository;

        public IPersonApp PersonApp
        {
            get
            {
                if (_personRepository == null)
                {
                    _personRepository = new PersonRepository(db);
                }

                if (_personApp == null)
                {
                    _personApp = new PersonApp(_personRepository);
                }

                return _personApp;
            }
        }

        private IPersonTypeApp _personTypeApp;
        private IPersonTypeRepository _personTypeRepository;

        public IPersonTypeApp PersonTypeApp
        {
            get
            {
                if (_personTypeRepository == null)
                {
                    _personTypeRepository = new PersonTypeRepository(db);
                }

                if (_personTypeApp == null)
                {
                    _personTypeApp = new PersonTypeApp(_personTypeRepository);
                }

                return _personTypeApp;
            }
        }


        private IPhoneApp _phoneApp;
        private IPhoneRepository _phoneRepository;

        public IPhoneApp PhoneApp
        {
            get
            {
                if (_phoneRepository == null)
                {
                    _phoneRepository = new PhoneRepositpry(db);
                }

                if (_phoneApp == null)
                {
                    _phoneApp = new PhoneApp(_phoneRepository);
                }

                return _phoneApp;
            }
        }

        private IAddressApp _addressApp;
        private IAddressRepository _addressRepository;

        public IAddressApp AddressApp
        {
            get
            {
                if (_addressRepository == null)
                {
                    _addressRepository = new AddressRepositpry(db);
                }

                if (_addressApp == null)
                {
                    _addressApp = new AddressApp(_addressRepository);
                }

                return _addressApp;
            }
        }

        private IInventoryApp _inventoryApp;
        private IInventoryRepository _inventoryRepository;

        public IInventoryApp InventoryApp
        {
            get
            {
                if (_inventoryRepository == null)
                {
                    _inventoryRepository = new InventoryRepository(db);
                }

                if (_inventoryApp == null)
                {
                    _inventoryApp = new InventoryApp(_inventoryRepository);
                }

                return _inventoryApp;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private IProductApp _productApp;
        private IProductRepository _productRepository;

        public IProductApp ProductApp
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(db);
                }

                if (_productApp == null)
                {
                    _productApp = new ProductApp(_productRepository);
                }

                return _productApp;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
