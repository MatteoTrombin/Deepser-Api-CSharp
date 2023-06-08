using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Crm
{
    public class PaymentCondition : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for payment condition entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/crm/paymentconditions";
        }
        public static string GetEndpoint()
        {
            return "/crm/paymentcondition";
        }

        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for payment condition entities.
        public PaymentCondition() : base()
        {
            ENDPOINT = "/crm/paymentcondition";
            MULTIPLE_ENDPOINT = "/crm/paymentconditions";
        }
    }
}
