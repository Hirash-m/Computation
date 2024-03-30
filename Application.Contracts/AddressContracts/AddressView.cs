using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.App;

namespace Application.Contracts.AddressContracts
{
    public class AddressView
    {
        public int Id { get; set; }

        public int? RegionId { get; set; } = 0;

        public bool IsMain { get; set; }

        public short TypeAdressId { get; set; }

        public string? Address1 { get; set; }

        public string? ZipCode { get; set; }

        public string? Title { get; set; }
    }

    public interface IAddressApp
    {
        OperationResult DeleteAddress(int id); 

    }
}
