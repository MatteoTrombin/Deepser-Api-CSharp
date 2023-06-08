using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Kb
{
    public class Kb : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for kb entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/kb_kbs";
        }
        public static string GetEndpoint()
        {
            return "/kb_kbs";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for kb entities.
        public Kb() : base()
        {
            ENDPOINT = "/kb_kbs";
            MULTIPLE_ENDPOINT = "/kb_kbs";
        }
    }
}
