using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryServices.Models;

namespace InventoryServices.Services
{
    public class InventoryServices : IInventoryServices
    {
        private readonly Dictionary<string, Models.InventoryItems> InventoryItems;
        public InventoryServices()
        {
            InventoryItems = new Dictionary<string, Models.InventoryItems>();
        }
        public Models.InventoryItems AddInventoryItems(Models.InventoryItems items)
        {
            InventoryItems.Add(items.ItemName, items);
            return items;
        }

        public Dictionary<string, InventoryItems> GetInventoryItems()
        {
            return InventoryItems;
        }
    }
}
