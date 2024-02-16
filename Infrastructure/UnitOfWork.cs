using Application;
using Application.Contracts.Person;
using Infrastructure.Models;
using Infrastructure.Repository;

namespace Infrastructure
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
