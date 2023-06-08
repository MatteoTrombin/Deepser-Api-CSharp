using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class NetworkInterface : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset network interface entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_networkinterfaces";
        }
        public static string GetEndpoint()
        {
            return "/asset_networkinterfaces";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset network interface entities.
        public NetworkInterface() : base()
        {
            ENDPOINT = "/asset_networkinterfaces";
            MULTIPLE_ENDPOINT = "/asset_networkinterfaces";
        }
    }
}
