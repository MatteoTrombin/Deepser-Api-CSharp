using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class SystemChassiss : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset System Chassiss entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_systemchassiss";
        }
        public static string GetEndpoint()
        {
            return "/asset_systemchassiss";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset System Chassiss entities.
        public SystemChassiss() : base()
        {
            ENDPOINT = "/asset_systemchassiss";
            MULTIPLE_ENDPOINT = "/asset_systemchassiss";
        }
    }
}
