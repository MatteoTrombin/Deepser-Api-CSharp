using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Crm
{
    public class ContactType : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for contact type entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/crm/contact_types";
        }
        public static string GetEndpoint()
        {
            return "/crm/contact_type";
        }

        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for contact type entities.
        public ContactType() : base()
        {
            ENDPOINT = "/crm/contact_type";
            MULTIPLE_ENDPOINT = "/crm/contact_type";
        }
    }
}
