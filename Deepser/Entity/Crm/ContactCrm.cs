using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Crm
{
    public class ContactCrm : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for contact entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/crm/contacts";
        }
        public static string GetEndpoint()
        {
            return "/crm/contact";
        }

        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for contact entities.
        public ContactCrm() : base()
        {
            ENDPOINT = "/crm/contact";
            MULTIPLE_ENDPOINT = "/crm/contacts";
        }
    }
}
