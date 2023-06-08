using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Catalog.Product
{
    public class Product : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for product (catalog) entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/catalog/products";
        }
        public static string GetEndpoint()
        {
            return "/catalog/product";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for product (catalog) entities.
        public Product() : base()
        {
            ENDPOINT = "/catalog/product";
            MULTIPLE_ENDPOINT = "/catalog/products";
        }
    }
}
