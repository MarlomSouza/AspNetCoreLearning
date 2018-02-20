namespace MarlomStore.Domain.Dtos
{
    public class ProductDto
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryId { get; set; }

    }
}
