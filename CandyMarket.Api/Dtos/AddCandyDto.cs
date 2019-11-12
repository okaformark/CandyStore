namespace CandyMarket.Api.Dtos
{
    public class AddCandyDto
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int TypeId { get; set; }
        public decimal Price { get; set; }
        public string UserId { get; set; }
    }
}