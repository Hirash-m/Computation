using Application.Contracts.Inventory;
using Infrastructure.IRepository;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.App;

namespace Application
{
    public class InventoryApp : IInventoryApp
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryApp(IInventoryRepository inventoryRepository)
        {
            this._inventoryRepository = inventoryRepository;
        }
        public List<InventoryView> GetInventory()
        {
            // 1. Retrieve inventory data from the repository
            var inventory = _inventoryRepository.Get();

            // 2. Check for null or empty data (optional)
            if (inventory == null || !inventory.Any())
            {
                return new List<InventoryView>(); // Return an empty list if no data found
            }

            // 3. Create a list to hold InventoryView objects
            List<InventoryView> inventoryViews = new List<InventoryView>();

            // 4. Loop through each inventory item and convert to InventoryView
            foreach (var item in inventory)
            {
                // 5. Create a new InventoryView object
                InventoryView inventoryView = new InventoryView
                {
                    Id = item.Id,
                    Name = item.Name,
                    IsActive = item.IsActive,
                    
                };

                // 7. Add the InventoryView object to the list
                inventoryViews.Add(inventoryView);
            }

            // 8. Return the list of InventoryView objects
            return inventoryViews;
        }


        public OperationResult InventoryAdd(InventoryView command)
        {
            var operation = new OperationResult();
            var inventory = new Inventory
            {
                Name = command.Name,
                IsActive= command.IsActive,
               
            };

            _inventoryRepository.Create(inventory);
            return operation.Succeeded();
        }

        public OperationResult InventoryDelete(int id)
        {
            throw new NotImplementedException();
        }

        public OperationResult InventoryEdit(InventoryView command)
        {
            throw new NotImplementedException();
        }
    }
}
