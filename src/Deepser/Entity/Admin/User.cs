using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Admin
{
    public class User : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for user entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/users";
        }
        public static string GetEndpoint()
        {
            return "/user";
        }

        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for user entities.
        public User()
        {
            ENDPOINT = "/user";
            MULTIPLE_ENDPOINT = "/users";
        }
    }
}
