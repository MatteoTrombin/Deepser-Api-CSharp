using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Inventory
{
    public class Movement : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for movement (invetory) entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/inventory/movements";
        }
        public static string GetEndpoint()
        {
            return "/inventory/movement";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for movement (invetory) entities.
        public Movement() : base()
        {
            ENDPOINT = "/inventory/movement";
            MULTIPLE_ENDPOINT = "/inventory/movements";
        }
    }
}
