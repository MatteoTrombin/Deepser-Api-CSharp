using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Company
{
    public class Company : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for company entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/companies";
        }
        public static string GetEndpoint()
        {
            return "/company";
        }

        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for company entities.
        public Company() : base()
        {
            ENDPOINT = "/company";
            MULTIPLE_ENDPOINT = "/companies";
        }
    }
}
