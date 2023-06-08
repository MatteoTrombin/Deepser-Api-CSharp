using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Group
{
    public class Group : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for group entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/groups";
        }
        public static string GetEndpoint()
        {
            return "/group";
        }

        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for group entities.
        public Group()
        {
            ENDPOINT = "/group";
            MULTIPLE_ENDPOINT = "/groups";
        }
    }
}
