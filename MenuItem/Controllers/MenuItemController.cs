using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuItemListing.Models;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<MenuItem> GetItem()
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="Shakes", Active=true, DateOfLaunch=new DateTime(2022,01,01), FreeDelivery=false,Price=100},
                new MenuItem() {Id=2, Name="Juices", Active=false, DateOfLaunch=new DateTime(2021,10,03), FreeDelivery=false,Price=150}

            };
            return MenuList;
        }

        [HttpGet("{id}")]
        public MenuItem GetItemById(int id)
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="Shakes", Active=true, DateOfLaunch=new DateTime(2022,01,01), FreeDelivery=false,Price=100},
                new MenuItem() {Id=2, Name="Juices", Active=false, DateOfLaunch=new DateTime(2021,10,03), FreeDelivery=false,Price=150}

            };
            MenuItem obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;

        }

    }
}
