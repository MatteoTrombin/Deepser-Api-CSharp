using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;

namespace Deepser.Framework.Request
{
    //Class that manages filter input
    public class Filter
    {
        internal Dictionary<string, object> filters = new Dictionary<string, object>();
        public const string EqualTo = "eq"; 
        public const string NotEqualTo = "neq"; 
        public const string EqualsAnyOf = "in"; 
        public const string NotEqualsAnyOf = "nin"; 
        public const string GreaterThan = "gt"; 
        public const string LessThan = "lt"; 
        public const string Like = "like"; 
        public const string NotLike = "nlike";

        // Define internal class for filters with range inputs
        internal class FilterFromTo
        {
            public object From { get; set; }
            public object To { get; set; }
        }

        // Define internal class for filters with values or operators
        internal class FilterOrValue
        {
            public object Operator { get; set; }
            public object Value { get; set; }
        }

        // Define internal class for filters with multiple values or operators
        internal class FilterOr
        {
            public object Operator { get; set; }
            public List<FilterOrValue> Values { get; set; } = new List<FilterOrValue>();
        }

        // Define internal class for filters with any other input type
        internal class OtherFilter
        {
            public object Operator { get; set; }
            public object Value { get; set; }
        }

        // Method to add a filter with a range of values
        public Filter addRange(string _attribute, object _from, object _to)
        {
            filters[_attribute] = new FilterFromTo { From = _from, To = _to };
            return this;
        }

        // Method to add a filter with a single value or operator
        public Filter addFilter(string _attribute, string _operator, List<object> _values)
        {
            var filterOrSet = new FilterOr();
            foreach (var _value in _values)
            {
                filterOrSet.Values.Add(new FilterOrValue { Operator = _operator, Value = _value });
            }
            filters[_attribute] = filterOrSet;
            return this;
        }

        // Method to add a filter with multiple values or operators
        public Filter addFilter(string _attribute, string _operator, object _value)
        {
            filters[_attribute] = new OtherFilter { Operator= _operator, Value = _value }; 
            return this;
        }

        // Method to convert filter to string for use in a request URL
        internal string filterToString()
        {
            var text = "";
            int i = 1;

            foreach (var filter in filters)
            {

                if (filter.Value is FilterFromTo filterValue)
                {
                    text += (i == 1 ? "?" : "&") + $"filter[{i}][attribute]={filter.Key}&filter[{i}][from]={filterValue.From}&filter[{i}][to]={filterValue.To}";
                }
                else if (filter.Value is FilterOr filterOr)
                {
                    text += (i == 1 ? "?" : "&") + $"filter[{i}][attribute]={filter.Key}";
                    for (var j = 0; j < filterOr.Values.Count; j++)
                    {
                        text += $"&filter[{i}][{j}][{filterOr.Values[j].Operator}]={filterOr.Values[j].Value}";
                    }
                }
                else if (filter.Value is OtherFilter otherFilter)
                {
                    text += (i == 1 ? "?" : "&") + $"filter[{i}][attribute]={filter.Key}&filter[{i}][{otherFilter.Operator}]={otherFilter.Value}";
                }

                i++;
            }
            return text == "?" ? "" : text;

        }
    }
}


