using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Crm
{
    public class Opportunity : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for opportunity entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/crm/opportunities";
        }
        public static string GetEndpoint()
        {
            return "/crm/opportunity";
        }

        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for opportunity entities.
        public Opportunity() : base()
        {
            ENDPOINT = "/crm/opportunity";
            MULTIPLE_ENDPOINT = "/crm/opportunities";
        }
    }
}
