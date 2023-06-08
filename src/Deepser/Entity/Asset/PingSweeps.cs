using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class PingSweeps : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset ping sweep entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_pingsweeps";
        }
        public static string GetEndpoint()
        {
            return "/asset_pingsweeps";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset ping sweep entities.
        public PingSweeps() : base()
        {
            ENDPOINT = "/asset_pingsweeps";
            MULTIPLE_ENDPOINT = "/asset_pingsweeps";
        }
    }
}
