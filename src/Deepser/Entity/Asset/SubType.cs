using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class SubType : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset SubType entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_subtypes";
        }
        public static string GetEndpoint()
        {
            return "/asset_subtypes";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset SubType entities.
        public SubType() : base()
        {
            ENDPOINT = "/asset_subtypes";
            MULTIPLE_ENDPOINT = "/asset_subtypes";
        }
    }
}
