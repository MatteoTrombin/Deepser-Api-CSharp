using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System;
using System.Security.Claims;

namespace Deepser.Framework.Request
{
    //Class that manages parameter input
    public class Parameter
    {
        // dictionary to store parameters and constants for sorting
        public Dictionary<string, object> parameters = new Dictionary<string, object>();
        public const string Ascending = "asc";
        public const string Descending = "desc";

        // method to set the sorting order
        public Parameter SetOrder(string field, string order)
        {
            parameters.Add(field, order);
            return this;
        }

        // method to set the number of records to receive (limit)
        public Parameter SetLimit(int value)
        {
            parameters.Add("limit", value);
            return this;
        }

        // method to set the page number
        public Parameter SetPage(int value)
        {
            parameters.Add("page", value);
            return this;
        }

        // method to get the parameters in query string format
        public string GetParameter()
        {
            var query = "";
            var i = 0;
            
            foreach (var parameter in parameters)
            {
                if (parameter.Value.ToString() == Descending || parameter.Value.ToString() == Ascending)
                {
                    query += $"order={parameter.Key}&dir={parameter.Value}&";
                }
                else if (parameter.Key == "page" || parameter.Key == "limit")
                {
                    query += $"{parameter.Key}={parameter.Value}&";
                }

                i++;
            }
            // trim the last character (&) because otherwise the endpoint is wrong
            var corrertquery = "";
            if (query.Length > 0)
            {
                corrertquery = query.Remove(query.Length - 1, 1);
            }
            else
            {
                return corrertquery;
            }

            // if the query string is just a ? because it did not add any parameters, it returns an empty string instead
            return corrertquery == "?" || corrertquery == "&" ? corrertquery = "" : corrertquery;
        }
    }
}