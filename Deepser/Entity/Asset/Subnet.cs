using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class Subnet : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset subnet entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_subnets";
        }
        public static string GetEndpoint()
        {
            return "/asset_subnets";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset subnet entities.
        public Subnet() : base()
        {
            ENDPOINT = "/asset_subnets";
            MULTIPLE_ENDPOINT = "/asset_subnets";
        }
    }
}
