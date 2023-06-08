using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class Update : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset update entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_updates";
        }
        public static string GetEndpoint()
        {
            return "/asset_updates";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset update entities.
        public Update() : base()
        {
            ENDPOINT = "/asset_updates";
            MULTIPLE_ENDPOINT = "/asset_updates";
        }
    }
}
