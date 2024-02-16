using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Person
{
    public class PersonView
    {
        [DisplayName("کد")]
        public int ID { get; set; }

        [DisplayName("نام")]
        public string Name { get; set; }

        [DisplayName("نام خانوادگی")]
        public string Family { get; set; }

    }
}
