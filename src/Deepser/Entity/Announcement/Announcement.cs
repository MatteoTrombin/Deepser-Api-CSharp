using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Announcement
{
    public class Announcement : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for announcement entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/announcement/announcements";
        }
        public static string GetEndpoint()
        {
            return "/announcement/announcement";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for announcement entities.
        public Announcement() : base()
        {
            ENDPOINT = "/announcement/announcement";
            MULTIPLE_ENDPOINT = "/announcement/announcements";
        }
    }
}
