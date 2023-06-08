using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Cmdb
{
    public class Subtype : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for subtype entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/cmdb/subtypes";
        }
        public static string GetEndpoint()
        {
            return "/cmdb/subtype";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for subtype entities.
        public Subtype() : base()
        { 
            ENDPOINT = "/cmdb/subtype";
            MULTIPLE_ENDPOINT = "/cmdb/subtypes";
        }
    }
}
