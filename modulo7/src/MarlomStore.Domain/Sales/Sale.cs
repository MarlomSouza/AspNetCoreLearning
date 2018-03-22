using System;
using MarlomStore.Domain.Products;

namespace MarlomStore.Domain.Sales
{
    public class Sale : Entity
    {
        public DateTime CreatedOn { get; private set; }
        public decimal Total { get; private set; }
        public SaleItem Item { get; private set; }

        public Sale(string clientName, Product product, int quatity)
        {
            DomainException.When(string.IsNullOrEmpty(clientName), "Client name is required");
            Item = new SaleItem(product, quatity);
            CreatedOn = DateTime.Now;
            Name = clientName;

        }

    }
}