using MarlomStore.Domain.Products;

namespace MarlomStore.Domain.Sales
{
    public class SaleItem : Entity
    {
        public Product Product { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
        public decimal Total { get; private set; }

        public SaleItem(Product product, int quantity)
        {
            DomainException.When(product == null, "Product is required");
            DomainException.When(quantity <= 0, "Quantity incorrect");

            Product = product;
            Price = Product.Price;
            Quantity = quantity;
            Total = Price * Quantity;
        }
    }
}