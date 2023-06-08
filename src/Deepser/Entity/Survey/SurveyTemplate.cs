using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Survey
{
    public class SurveyTemplate : AbstractEntity
    {
        // These method returns the endpoint and the multiple endpoint for survey template entities in the Deepser system (Reflection).
        public static string GetMultipleEndpoint()
        {
            return "/survey/survey_template";
        }
        public static string GetEndpoint()
        {
            return "/survey/survey_template";
        }
        // This constructor initializes the "ENDPOINT" and "MULTIPLE_ENDPOINT" fields of the class to their respective values for survey template entities.
        public SurveyTemplate() : base()
        {
            ENDPOINT = "/survey/survey_template";
            MULTIPLE_ENDPOINT = "/survey/survey_template";
        }
    }
}
