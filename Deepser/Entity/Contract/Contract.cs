using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Contract
{
    public class Contract : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for Contract entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/contract_contracts";
        }
        public static string GetEndpoint()
        {
            return "/contract_contracts";
        }

        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for Contract entities.
        public Contract() : base()
        {
            ENDPOINT = "/contract_contracts";
            MULTIPLE_ENDPOINT = "/contract_contracts";
        }
    }
}
