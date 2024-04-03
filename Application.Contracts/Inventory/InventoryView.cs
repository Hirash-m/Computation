using Application.Contracts.Person;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.App;

namespace Application.Contracts.Inventory
{
    public class InventoryView
    {
        public short Id { get; set; }

        public string Name { get; set; } = null!;

        public int UserId { get; set; } = 0;

        public bool IsActive { get; set; } = true;


    }

    public interface IInventoryApp
    {
        List<InventoryView> GetInventory();
        OperationResult InventoryAdd(InventoryView command);
        OperationResult InventoryEdit(InventoryView command);
        OperationResult InventoryDelete(short id);
    }
}
