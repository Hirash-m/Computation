using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.IRepository
{
    public interface IPhoneRepository : IRepository<Phone , int>
    {
        bool PhoneAdd(Phone phone);
    }
}
