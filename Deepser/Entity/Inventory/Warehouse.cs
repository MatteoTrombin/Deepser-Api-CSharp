using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Inventory
{
    public class Warehouse : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for warehouse (invetory) entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/inventory/warehouses";
        }
        public static string GetEndpoint()
        {
            return "/inventory/warehouse";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for warehouse (invetory) entities.
        public Warehouse() : base()
        {
            ENDPOINT = "/inventory/warehouse";
            MULTIPLE_ENDPOINT = "/inventory/warehouses";
        }
    }
}
