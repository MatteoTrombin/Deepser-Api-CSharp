using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class Scripts : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset script entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_scripts";
        }
        public static string GetEndpoint()
        {
            return "/asset_scripts";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset script entities.
        public Scripts() : base()
        {
            ENDPOINT = "/asset_scripts";
            MULTIPLE_ENDPOINT = "/asset_scripts";
        }
    }
}
