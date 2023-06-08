using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Category
{
    public class Category : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset category entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/category_categories";
        }
        public static string GetEndpoint()
        {
            return "/category_categories";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset category entities.
        public Category() : base()
        {
            ENDPOINT = "/category_categories";
            MULTIPLE_ENDPOINT = "/category_categories";
        }
    }
}
