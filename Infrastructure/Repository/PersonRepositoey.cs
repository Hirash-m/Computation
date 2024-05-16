using Infrastructure.IRepository;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;



namespace Infrastructure.Repository
{
    public class PersonRepository : BaseRepository<Person, int> , IPersonRepository
    {
        private readonly ComputationContext ctx;

        public PersonRepository(ComputationContext ctx) :base(ctx) 
        {
            this.ctx = ctx;
        }

        public bool AddPerson(Person person)
        {
            try
            {
               // var newPerson = new Person(person.Name, person.Family, person.Type);
                ctx.Add(person);
                var result = ctx.SaveChanges();

                if (result > 0)
                {
                    return true; // بازگردانی true اگر عملیات با موفقیت انجام شود
                }
                else
                {
                    return false; // بازگردانی false اگر عملیات ناموفق باشد
                }
            }
            catch (Exception ex)
            {
                // می‌توانید در اینجا هندل کردن خطاها و بازگرداندن false را انجام دهید
                return false;
            }


        }

        public List<Person> GetPersons(int skip, int row)
        {
            return ctx.Persons.AsNoTracking()
                             .Include(c => c.Type)
                             .OrderBy(p => p.Id)
                             .Skip(skip)
                             .Take(row)
                             .ToList();
        }
        public Person GetPerson(int id)
        {
            var a = ctx.Persons.Include(c => c.Type).Include(c => c.Phones).Include(c=>c.Addresses).SingleOrDefault(c => c.Id == id);
            return a;
        }

        int IPersonRepository.CountPerson()
        {
           return ctx.Persons.AsNoTracking().Count();
        }
    }
}
