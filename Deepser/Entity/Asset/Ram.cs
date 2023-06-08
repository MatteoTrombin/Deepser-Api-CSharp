using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class Ram : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset ram entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_rams";
        }
        public static string GetEndpoint()
        {
            return "/asset_rams";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset ram entities.
        public Ram() : base()
        {
            ENDPOINT = "/asset_rams";
            MULTIPLE_ENDPOINT = "/asset_rams";
        }
    }
}
