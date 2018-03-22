using System.Collections;
using System.Collections.Generic;

namespace MarlomStore.Web.ViewModels
{
    public class SaleViewModel
    {
        public string ClientName { get; set; }
        public int Quantity { get; set; }
        public IEnumerable<ProductViewModel> ProductViewModel { get; set; }

    }
}