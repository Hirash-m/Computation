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

        public List<Person> GetPersons()
        {
           return ctx.Persons.Include(c=>c.Type).ToList();
        }
        public Person GetPerson(int id)
        {
            var a = ctx.Persons.Include(c => c.Type).Include(c => c.Phones).SingleOrDefault(c => c.Id == id);
            return a;
        }
      
    }
}
