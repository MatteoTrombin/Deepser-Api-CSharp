using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Kb
{
    public class KbArticle : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for kb article entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/kb_articles";
        }
        public static string GetEndpoint()
        {
            return "/kb_articles";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for kb article entities.
        public KbArticle() : base()
        {
            ENDPOINT = "/kb_articles";
            MULTIPLE_ENDPOINT = "/kb_articles";
        }
    }
}
