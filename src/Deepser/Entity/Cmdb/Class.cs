using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Cmdb
{
    public class Class : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for class entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/cmdb/classes";
        }
        public static string GetEndpoint()
        {
            return "/cmdb/class";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for class entities.
        public Class() : base()
        { 
            ENDPOINT = "/cmdb/class";
            MULTIPLE_ENDPOINT = "/cmdb/classes";
        }
    }
}
