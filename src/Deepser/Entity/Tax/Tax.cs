using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Tax
{
    public class Tax : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for tax entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/tax/taxes";
        }
        public static string GetEndpoint()
        {
            return "/tax/tax";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for tax entities.
        public Tax() : base()
        {
            ENDPOINT = "/tax/tax";
            MULTIPLE_ENDPOINT = "/tax/taxes";
        }
    }
}
