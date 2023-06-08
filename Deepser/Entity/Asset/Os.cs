using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class Os : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset os entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_oses";
        }
        public static string GetEndpoint()
        {
            return "/asset_oses";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset os entities.
        public Os() : base()
        {
            ENDPOINT = "/asset_oses";
            MULTIPLE_ENDPOINT = "/asset_oses";
        }
    }
}
