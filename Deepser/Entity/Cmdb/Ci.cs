using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Cmdb
{
    public class Ci : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for ci entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/cmdb/cies";
        }
        public static string GetEndpoint()
        {
            return "/cmdb/ci";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for ci entities.
        public Ci() : base()
        { 
            ENDPOINT = "/cmdb/ci";
            MULTIPLE_ENDPOINT = "/cmdb/cies";
        }
    }
}
