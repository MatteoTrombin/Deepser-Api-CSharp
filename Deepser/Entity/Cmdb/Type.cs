using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Cmdb
{
    public class Type : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for type entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/cmdb/types";
        }
        public static string GetEndpoint()
        {
            return "/cmdb/type";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for type entities.
        public Type() : base()
        { 
            ENDPOINT = "/cmdb/type";
            MULTIPLE_ENDPOINT = "/cmdb/types";
        }
    }
}
