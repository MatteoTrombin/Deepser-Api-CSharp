using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Contract
{
    public class Line : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for line entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/contract_lines";
        }
        public static string GetEndpoint()
        {
            return "/contract_lines";
        }

        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for line entities.
        public Line() : base()
        {
            ENDPOINT = "/contract_lines";
            MULTIPLE_ENDPOINT = "/contract_lines";
        }
    }
}
