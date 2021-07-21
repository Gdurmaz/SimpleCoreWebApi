using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryServices.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryServices.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly Services.IInventoryServices _service;
        public InventoryController(Services.IInventoryServices services)
        {
            _service = services; 
        }
        //Post method: FromForm for Json
        [HttpPost]
        [Route("AddInventoryItems")]
        public ActionResult<InventoryItems> AddInventoryItems([FromForm]Models.InventoryItems items)
        {
            var item = _service.AddInventoryItems(items);
            if (item==null)
            {
                return NotFound();
            }
            return item;
        }
        [HttpGet]
        [Route("GetInventoryItems")]
        public ActionResult<Dictionary<string,InventoryItems>> GetInventoryItems()
        {
            var items = _service.GetInventoryItems();
            if (items.Count()==0)
            {
                return NotFound();
            }
            return items;
        }
    }
}