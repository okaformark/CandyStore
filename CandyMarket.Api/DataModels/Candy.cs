using System;

namespace CandyMarket.Api.DataModels
{
    public class Candy
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int TypeId { get; set; }
        public decimal Price { get; set; }
    }
}
