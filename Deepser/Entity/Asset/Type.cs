using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class Type : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset Type entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_types";
        }
        public static string GetEndpoint()
        {
            return "/asset_types";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset Type entities.
        public Type() : base()
        {
            ENDPOINT = "/asset_types";
            MULTIPLE_ENDPOINT = "/asset_types";
        }
    }
}
