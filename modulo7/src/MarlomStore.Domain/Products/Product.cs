namespace MarlomStore.Domain.Products
{
    public class Product : Entity
    {
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public Category Category { get; set; }

        public Product(string name, decimal price, int stockQuantity, Category category)
        {
            ValidadeValues(name, price, category);

            SetProperties(name, price, stockQuantity, category);
        }

        private void ValidadeValues(string name, decimal price, Category category)
        {
            ValidadeName(name);
            DomainException.When(price < 0, "Price can't be lower than 0");
            DomainException.When(StockQuantity < 0, "Stock minimun is 0");
            DomainException.When(category == null, "Category is required");
        }

        private void SetProperties(string name, decimal price, int stockQuantity, Category category)
        {
            this.Name = name;
            this.Price = price;
            this.StockQuantity = stockQuantity;
            this.Category = category;
        }

        public void Update(string name, decimal price, int stockQuantity, Category category)
        {
            ValidadeValues(name, price, category);

            SetProperties(name, price, stockQuantity, category);

        }

    }
}
