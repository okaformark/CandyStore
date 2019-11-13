using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyMarket.Api.DataModels;
using CandyMarket.Api.Dtos;
using CandyMarket.Api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CandyMarket.Api.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUsersRepository _repo;

        public UserController(ILogger<UserController> logger, IUsersRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _repo.GetAllUsers();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public User Get(Guid userId)
        {
            return _repo.GetAllUsers().FirstOrDefault(user => user.Id == userId);
        }

        // POST: api/User
        [HttpPost]
        public void Post(AddUserDto newUser)
        {
            _repo.AddUser(newUser);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(User updatedUser, Guid id)
        {
            _repo.UpdateUser(updatedUser, id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repo.DeleteUser(id);
        }
    }
}
