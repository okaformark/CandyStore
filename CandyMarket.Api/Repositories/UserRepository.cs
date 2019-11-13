using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyMarket.Api.DataModels;
using CandyMarket.Api.Dtos;
using System.Data.SqlClient;
using Dapper;
namespace CandyMarket.Api.Repositories
{
    public class UserRepository : IUsersRepository
    {
        string _connectionString = "Server=localhost; Database=CandyMarket; Trusted_Connection=True";
        public bool AddUser(AddUserDto newUser)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(Guid userToDeleteId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            using var db = new SqlConnection(_connectionString);
            var users = db.Query<User>(@"select * from Users");
            return users.ToList();
        }

        public string getOneUser()
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User userToUpdate, Guid userToUpdateId)
        {
            throw new NotImplementedException();
        }
    }
}
