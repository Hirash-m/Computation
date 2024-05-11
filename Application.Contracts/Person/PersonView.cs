using Application.Contracts.AddressContracts;
using Application.Contracts.PhoneContracts;
using Infrastructure.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


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
        [DisplayName("نوع شخص")]
        public string PersonTypeName { get; set; }

        [DisplayName("کد ملی")]
        public string NationalCode { get; set; }

        [DisplayName("ایمیل")]
        public string Email { get; set; }
        [Browsable(false)]
        public Infrastructure.Models.PersonType personType {  get; set; } 

        public ICollection<PhoneView> Phones { get; set; }

        public ICollection<AddressView> Addresses { get; set; }

    }

    public class PersonAdd : PersonView
    {
        private byte typeId = 54; // تنظیم مقدار پیش‌فرض برای TypeId به 1

        public byte TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }

    }
}
