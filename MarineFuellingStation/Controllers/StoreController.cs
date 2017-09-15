﻿using MFS.Controllers.Attributes;
using MFS.Models;
using MFS.Repositorys;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFS.Controllers
{
    [Route("api/[controller]"), Axios]
    public class StoreController : ControllerBase
    {
        private readonly StoreRepository r;
        public StoreController(StoreRepository repository)
        {
            r = repository;
        }
        [HttpGet]
        public ResultJSON<List<Store>> Get()
        {
            return new ResultJSON<List<Store>>
            {
                Code = 0,
                Data = r.GetAllList()
            };
        }
        [HttpGet("{id}")]
        public ResultJSON<Store> Get(int id)
        {
            Store s = r.Get(id);
            return new ResultJSON<Store>
            {
                Code = 0,
                Data = s
            };
        }
        [HttpPost]
        public ResultJSON<Store> Post([FromBody]Store model)
        {
            r.CurrentUser = UserName;
            return new ResultJSON<Store>
            {
                Code = 0,
                Data = r.Insert(model)
            };
        }
        [HttpPut]
        public ResultJSON<Store> Put([FromBody]Store model)
        {
            r.CurrentUser = UserName;
            return new ResultJSON<Store>
            {
                Code = 0,
                Data = r.InsertOrUpdate(model)
            };
        }
    }
}