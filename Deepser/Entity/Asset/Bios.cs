using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class Bios : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset bios entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_bioss";
        }
        public static string GetEndpoint()
        {
            return "/asset_bioss";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset bios entities.
        public Bios() : base()
        {
            ENDPOINT = "/asset_bioss";
            MULTIPLE_ENDPOINT = "/asset_bioss";
        }
    }
}
