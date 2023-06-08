using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class Ip : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset ip entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_ips";
        }
        public static string GetEndpoint()
        {
            return "/asset_ips";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset ip entities.
        public Ip() : base()
        {
            ENDPOINT = "/asset_ips";
            MULTIPLE_ENDPOINT = "/asset_ips";
        }
    }
}
