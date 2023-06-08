using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Survey
{
    public class Survey : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for survey entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/survey/surveys";
        }
        public static string GetEndpoint()
        {
            return "/survey/survey";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for survey entities.
        public Survey() : base()
        {
            ENDPOINT = "/survey/survey";
            MULTIPLE_ENDPOINT = "/survey/surveys";
        }
    }
}
