using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğitimKampi501.Dtos
{
    public class ProductDto
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public int productStock { get; set; }
        public decimal productPrice { get; set; }
        public string productCategory { get; set; }
    }
}
