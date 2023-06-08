using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deepser.Entity.Activity
{
    // This is used to represent an entity activity in the Deepser system.
    // This constructor initialises the 'ENDPOINT' and 'MULTIPLE_ENDPOINT' fields of the class to their respective values for entity activities.
    public class Activity
    {
        public static string ENDPOINT = "/activity";
        public static string MULTIPLE_ENDPOINT = "/activities";
    }
}
