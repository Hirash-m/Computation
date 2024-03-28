using Infrastructure.IRepository;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PhoneRepositpry : BaseRepository<Phone, int>, IPhoneRepository
    {

        private readonly ComputationContext ctx;


        public PhoneRepositpry(ComputationContext context) : base(context)
        {
            this.ctx = context;
        }

        public bool DeleteAdd(int phoneId)
        {
            DeleteById(phoneId);
            return true;
        }
    }
}
