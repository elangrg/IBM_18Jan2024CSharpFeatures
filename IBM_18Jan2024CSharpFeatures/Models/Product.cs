using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM_18Jan2024CSharpFeatures.Models
{
    internal partial class Product : IProduct
    {
        public string ProductName { get; set; }
        public string GetProductDetails() { return ProductName; }
        string IProduct.ProductName { 
            get { return "Exp Prd Name Called"; }
             set { ProductName = value; }
        }

        string IProduct.GetProductDetails()
        {
            return  "Explicit GetPrd Method" ;
        }
    }
}
