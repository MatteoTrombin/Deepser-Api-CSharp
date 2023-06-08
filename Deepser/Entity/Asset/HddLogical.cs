using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class HddLogical : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset hdd entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_hddlogicals";
        }
        public static string GetEndpoint()
        {
            return "/asset_hddlogicals";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset hdd entities.
        public HddLogical() : base()
        {
            ENDPOINT = "/asset_hddlogicals";
            MULTIPLE_ENDPOINT = "/asset_hddlogicals";
        }
    }
}
