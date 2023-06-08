using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Sales
{
    public class Quote : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for quote (sales) entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/sales/quotes";
        }
        public static string GetEndpoint()
        {
            return "/sales/quote";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for quote (sales) entities.
        public Quote() : base()
        {
            ENDPOINT = "/sales/quote";
            MULTIPLE_ENDPOINT = "/sales/quotes";
        }
    }
}
