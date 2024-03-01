using Application;
using Application.Contracts.Person;
using Application.Contracts.PersonType;
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



        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
