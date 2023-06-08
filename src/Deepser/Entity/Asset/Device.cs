using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class Device : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset device entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_devices";
        }
        public static string GetEndpoint()
        {
            return "/asset_devices";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset device entities.
        public Device() : base()
        {
            ENDPOINT = "/asset_devices";
            MULTIPLE_ENDPOINT = "/asset_devices";
        }
    }
}
