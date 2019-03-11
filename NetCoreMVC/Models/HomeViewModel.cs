using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVC.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }
    }

    public class CategoryDTO
    {
        public string Name { get; set; }
    }
    public class HomeViewModel
    {
        public CategoryDTO Category { get; set; }
        public List<ProductDTO> Products { get; set; }

    }
}
