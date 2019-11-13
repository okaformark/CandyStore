using CandyMarket.Api.DataModels;
using CandyMarket.Api.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyMarket.Api.Repositories
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetAllUsers();
        string getOneUser();
        bool AddUser(AddUserDto newUser);
        bool DeleteUser(Guid userToDeleteId);
        bool UpdateUser(User userToUpdate, Guid userToUpdateId);
    }
}
