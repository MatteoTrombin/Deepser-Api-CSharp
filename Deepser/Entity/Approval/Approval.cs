using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Approval
{
    public class Approval : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for asset approval entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/approval_approvals";
        }
        public static string GetEndpoint()
        {
            return "/approval_approvals";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for asset approval entities.
        public Approval() : base()
        {
            ENDPOINT = "/approval_approvals";
            MULTIPLE_ENDPOINT = "/approval_approvals";
        }
    }
}
