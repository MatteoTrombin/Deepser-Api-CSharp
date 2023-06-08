using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class Software : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset software entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_softwares";
        }
        public static string GetEndpoint()
        {
            return "/asset_softwares";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset software entities.
        public Software() : base()
        {
            ENDPOINT = "/asset_softwares";
            MULTIPLE_ENDPOINT = "/asset_softwares";
        }
    }
}
