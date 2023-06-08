using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Inventory
{
    public class WarehouseType : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for warehouse type (invetory) entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/inventory/warehouses_type";
        }
        public static string GetEndpoint()
        {
            return "/inventory/warehouse_type";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for warehouse type (invetory) entities.
        public WarehouseType() : base()
        {
            ENDPOINT = "/inventory/warehouse_type";
            MULTIPLE_ENDPOINT = "/inventory/warehouses_type";
        }
    }
}
