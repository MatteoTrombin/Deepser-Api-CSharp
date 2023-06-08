using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class Cpu : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset cpu entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_cpus";
        }
        public static string GetEndpoint()
        {
            return "/asset_cpus";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset cpu entities.
        public Cpu() : base()
        {
            ENDPOINT = "/asset_cpus";
            MULTIPLE_ENDPOINT = "/asset_cpus";
        }
    }
}
