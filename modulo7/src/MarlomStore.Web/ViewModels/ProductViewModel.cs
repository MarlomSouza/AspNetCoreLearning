using System.Collections;
using System.Collections.Generic;

namespace MarlomStore.Web.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Categories = new HashSet<CategoryViewModel>();
            Category = new CategoryViewModel();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public CategoryViewModel Category { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; }

    }
}
