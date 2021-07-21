using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryServices.Services
{
    public interface IInventoryServices
    {
        Models.InventoryItems AddInventoryItems(Models.InventoryItems items);
        Dictionary<string,Models.InventoryItems> GetInventoryItems();
    }
}
