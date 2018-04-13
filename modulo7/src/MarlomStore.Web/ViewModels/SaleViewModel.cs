using System.Collections;
using System.Collections.Generic;

namespace MarlomStore.Web.ViewModels
{
    public class SaleViewModel
    {
        public string ClientName { get; set; }
        public int Quantity { get; set; }

        public ProductViewModel Product { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }

    }
}