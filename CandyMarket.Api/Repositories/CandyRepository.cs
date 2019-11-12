using System;
using System.Collections.Generic;
using CandyMarket.Api.DataModels;
using CandyMarket.Api.Dtos;
using System.Data.SqlClient;
using Dapper;
namespace CandyMarket.Api.Repositories
{
    public class CandyRepository : ICandyRepository
    {
        string _connectionString = " Server=localhost;Database=CandyMarket;Trusted_Connection=True";
        public IEnumerable<Candy> GetAllCandy()
        {
            using var db = new SqlConnection(_connectionString);
            var candies = db.Query<Candy>("select * from Candy");
            return candies;
        }

        public bool AddCandy(AddCandyDto newCandy)
        {
            using var db = new SqlConnection(_connectionString);
            var sql = @"INSERT INTO [dbo].[Candy]
                                       ([Name]
                                       ,[Type]
                                       ,[TypeId]
                                       ,[Price]
                                       ,[UserId])
                                 VALUES
                                       (
                                       @name
                                       ,@type
                                       ,@typeId
                                       ,@price
                                       ,@UserId)";
            return db.Execute(sql, newCandy) == 1;
        }

        public bool EatCandy(Guid candyIdToDelete)
        {
            using var db = new SqlConnection(_connectionString);
            var sql = @"delete
                            from Candy
                            where Id = @candyIdToDelete";
            return db.Execute(sql, new { candyIdToDelete }) == 1;
        }

        public bool ChangeCandy(Candy CandyToChange, Guid candyIdToChange)
        {
            using var db = new SqlConnection(_connectionString);
            var sql = @"UPDATE [dbo].[Candy]
                           SET [Name] = @name
                              ,[Type] = @type
                              ,[TypeId] = @typeId
                              ,[Price] = @price
                         WHERE Id = @id";
            CandyToChange.Id = candyIdToChange;
            var candy = db.Execute(sql, CandyToChange) == 1;
            return candy;
        }
    }
}