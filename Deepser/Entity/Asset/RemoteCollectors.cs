using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class RemoteCollectors : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset remote collector entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_remotecollectors";
        }
        public static string GetEndpoint()
        {
            return "/asset_remotecollectors";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset remote collector entities.
        public RemoteCollectors() : base()
        {
            ENDPOINT = "/asset_remotecollectors";
            MULTIPLE_ENDPOINT = "/asset_remotecollectors";
        }
    }
}
