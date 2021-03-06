﻿using ReactGrid.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace ReactGrid.Controllers.api
{
    public class ItemsController : ApiController
    {
        [Route("api/items")]
        public List<Item> Get()
        {
            var items = new List<Item>();

            for (var i = 700; i != 0; i--) {
                items.Add(new Item()
                {
                    Id = i,
                    Name = "Item " + i,
                    Type = (ItemType)(i % 3),
                    CreatedDate = DateTime.Now.AddDays(i)
                });
            }

            return items;
        }
    }
}