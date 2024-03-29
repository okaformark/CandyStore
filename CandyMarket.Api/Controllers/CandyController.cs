﻿using System;
using System.Collections.Generic;
using System.Linq;
using CandyMarket.Api.DataModels;
using CandyMarket.Api.Dtos;
using CandyMarket.Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
// first commit
//second commit

namespace CandyMarket.Api.Controllers
{
    [ApiController]
    [Route("api/candy")]
    public class CandyController : ControllerBase
    {
        private readonly ILogger<CandyController> _logger;
        private readonly ICandyRepository _repo;

        public CandyController(ILogger<CandyController> logger, ICandyRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Candy> GetAll()
        {
            return _repo.GetAllCandy();
        }

        [HttpGet("{candyId}")]
        public Candy Get(Guid candyId)
        {
            return _repo.GetAllCandy().FirstOrDefault(candy => candy.Id == candyId);
        }

        [HttpPost]
        public void Add(AddCandyDto newCandy)
        {
            _repo.AddCandy(newCandy);
        }

        [HttpDelete("{candyIdToDelete}/eat")]
        public void Delete(Guid candyIdToDelete)
        {
            _repo.EatCandy(candyIdToDelete);
        }

        [HttpPut("{candyIdToUpdate}/change")]
        public void Update(Candy candyToChange, Guid candyIdToUpdate)
        {
   
            _repo.ChangeCandy(candyToChange,candyIdToUpdate);
        }

        //[HttpPost]
        public void Trade()
        {
           
        }
    }
}
