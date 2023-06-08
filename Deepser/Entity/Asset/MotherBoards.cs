using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Asset
{
    public class MotherBoards : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset motherboards entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/asset_motherboards";
        }
        public static string GetEndpoint()
        {
            return "/asset_motherboards";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset motherboards entities.
        public MotherBoards() : base()
        {
            ENDPOINT = "/asset_motherboards";
            MULTIPLE_ENDPOINT = "/asset_motherboards";
        }
    }
}
