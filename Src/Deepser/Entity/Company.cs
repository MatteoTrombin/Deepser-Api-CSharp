using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity
{
    // This code defines a class called "Company", which is a subclass of "AbstractEntity".
    // It is used to represent a company entity in the Deepser system.
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
