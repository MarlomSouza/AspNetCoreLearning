namespace MarlomStore.Web.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
    }
}
