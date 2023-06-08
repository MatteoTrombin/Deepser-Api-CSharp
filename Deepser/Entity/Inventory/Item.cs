using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Inventory
{
    public class Item : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for item (invetory) entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/inventory/items";
        }
        public static string GetEndpoint()
        {
            return "/inventory/item";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for item (invetory) entities.
        public Item() : base()
        {
            ENDPOINT = "/inventory/item";
            MULTIPLE_ENDPOINT = "/inventory/items";
        }
    }
}
