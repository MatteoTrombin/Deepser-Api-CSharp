using Deepser.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Service
{
    // This code defines a class called "Operation", which is a subclass of "AbstractEntity".
    // It is used to represent a operation entity in the Deepser system.
    public class Operation : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for operation entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/service/operations";
        }

        public static string GetEndpoint()
        {
            return "/service/operation";
        }

        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for operation entities.
        public Operation()
        {
            ENDPOINT = "/service/operation";
            MULTIPLE_ENDPOINT = "/service/operations";
        }
    }
}
