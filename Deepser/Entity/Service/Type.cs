using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Service
{
    public class Type : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for type entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/service/types";
        }
        public static string GetEndpoint()
        {
            return "/service/type";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for type entities.
        public Type()
        {
            ENDPOINT = "/service/type";
            MULTIPLE_ENDPOINT = "/service/types";
        }
    }
}
