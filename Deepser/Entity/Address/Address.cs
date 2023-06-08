using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Address
{
    public class Address : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for address entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/address/addresses";
        }
        public static string GetEndpoint()
        {
            return "/address/address";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for address entities.
        public Address() : base()
        {
            ENDPOINT = "/address/address";
            MULTIPLE_ENDPOINT = "/address/addresses";
        }
    }
}
