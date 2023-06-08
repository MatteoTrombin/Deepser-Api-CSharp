using Deepser.Framework.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Deepser.Framework.Data
{
    public abstract class Data
    {
        // Define dictionaries and lists to store data
        internal Dictionary<string, object> dictobject = new Dictionary<string, object>(); // dictionary to store key-value pairs of objects
        internal Dictionary<string, object> data = new Dictionary<string, object>(); // dictionary to store key-value pairs of data
        internal List<object> listjson = new List<object>(); // list to store JSON objects

        // Method to set data in the data dictionary
        public Data setData(string key, object value)
        {
            this.data.Add(key.ToLower(), value);
            return this;
        }

        // Method to get data from the data dictionary
        public object getData(string key)
        {
            return this.data.ContainsKey(key) ? $"{this.data[key]}" : null;
        }

        public Dictionary<string, object> getAllData()
        { 
            return this.data; 
        }

        // Method to convert data dictionary to JSON string
        internal string toJson()
        {
            return JsonConvert.SerializeObject(this.data, Formatting.Indented);
        }

        //=================================MULITPLECREATE DATA======================================

        // Method to add an object to the dictobject dictionary
        public Data setObject(string key, object value)
        {
            var jsonValue = JsonConvert.SerializeObject(value); // convert the object to a JSON string
            dictobject.Add(key, JToken.Parse(jsonValue)); // parse the JSON string as a JToken and add to the dictobject dictionary
            return this;
        }


        // Method to add a complete JSON object to the listjson list
        public List<object> addObject()
        {
            var obj = JObject.FromObject(dictobject); // create a JSON object from the dictobject dictionary
            listjson.Add(obj); // add the JSON object to the listjson list
            dictobject.Clear(); // clear the dictobject dictionary for the next object
            return listjson;
        }

        // Method to convert the listjson list to a JSON string
        internal string arrtoJson()
        {
            var jsonArray = JArray.FromObject(listjson); // create a JSON array from the listjson list
            return jsonArray.ToString(); // convert the JSON array to a string and return it
        }
    }
}