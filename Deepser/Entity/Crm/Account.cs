using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Crm
{
    public class Account : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for account entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/crm/accounts";
        }
        public static string GetEndpoint()
        {
            return "/crm/account";
        }

        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for account entities.
        public Account() : base()
        {
            ENDPOINT = "/crm/account";
            MULTIPLE_ENDPOINT = "/crm/accounts";
        }
    }
}
