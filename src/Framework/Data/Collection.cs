using Deepser.Entity;
using Deepser.Entity.Service;
using Deepser.Framework.Data.Entity;
using Deepser.Framework.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;


namespace Deepser.Framework.Data
{
    public class Collection : Data
    {
        // Define class properties
        public Dictionary<object, object> collection = new Dictionary<object, object>();
        public List<Dictionary<string, object>> jsonlist = new List<Dictionary<string, object>>();
        protected Filter filter = new Filter();
        protected Request.Parameter parameter = new Request.Parameter();
        protected System.Type MainModel = null;
        protected Factory entityFactory = null;
        internal string endpoint;
        internal string activityEndpoint;
        internal string Filter;
        internal string Parameter;
        internal object field;
        internal object id;
        internal HttpClient client = new HttpClient();
            
        public Collection()
        {
            // Set HTTP headers for authentication and response format
            client.DefaultRequestHeaders.Authorization = Authentication.AutomaticAuth.AuthorizationHeader;
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public Dictionary<object, object> GetCollection() => collection;

        public Filter GetFilter() => filter;

        public Request.Parameter GetParameter() => parameter;

        // Set the main model for the collection
        public Collection SetMainModel(System.Type type)
        {
            MainModel = type;
            return this;
        }

        public object GetSingleData(string attribute)
        {
            string text = $"These are all the {attribute.ToLower()} of items \r\n \r\n ID   :   {attribute.ToLower()} \r\n";

            if (attribute.ToLower() == "entity_id")
            {
                foreach (var item in jsonlist)
                {
                    text += $"\r\n{item["entity_id"]}";
                }
            }
            else
            {
                foreach (var item in jsonlist)
                {
                    if (item.ContainsKey(attribute))
                    {
                        if (item.ContainsKey("entity_id"))
                        {
                            text += $"\r\n{item["entity_id"]}   :   {item[attribute]}";
                        }
                        else if (item.ContainsKey("user_id"))
                        {
                            text += $"\r\n{item["user_id"]}   :   {item[attribute]}";
                        }
                        else
                        {
                            return "Key not found";
                        }
                    }
                    else
                    {
                        return "Attribute not found";
                    }
                }
            }
            return text;
        }

        // Get the endpoint for loading multiple items
        public string GetMultipleEndpoint()
        {
            var _host = Authentication.AutomaticAuth.GetHost();
            var _endpoint = $"{(string.IsNullOrEmpty($"{id}") ? $"{this.endpoint}" : $"{activityEndpoint}/{id}{field}{Deepser.Entity.Activity.MULTIPLE_ENDPOINT}")}{filter.filterToString()}{(parameter.parameters.Count > 0 ? "&" + parameter.GetParameter().Substring(1) : parameter.GetParameter())}";
            return $"{_host}/api/rest{_endpoint}";
        }

        // Load multiple items
        public async Task<Dictionary<object, object>> LoadMultiple()
        {
            // Get the endpoint URL with System.Reflection 
            var multipleEndpoint = MainModel.GetMethod(nameof(GetMultipleEndpoint));
            this.endpoint = multipleEndpoint?.Invoke(null, null)?.ToString() ?? "";
            var response = await client.GetAsync(GetMultipleEndpoint());
            response.EnsureSuccessStatusCode();

            // Parse response content and add items to collection
            var responseContent = await response.Content.ReadAsStringAsync();
            dynamic obj = JsonConvert.DeserializeObject(responseContent);
            if (obj.items is JArray itemsArray)
            {
                foreach (var item in itemsArray)
                {

                    if (item is JObject itemObject && itemObject.TryGetValue("entity_id", out JToken entityId))
                    {
                        collection.Add(entityId.ToString(), item);
                        JObject myJObject = JObject.Parse(item.ToString());
                        jsonlist.Add(JsonConvert.DeserializeObject<Dictionary<string, object>>(myJObject.ToString(Newtonsoft.Json.Formatting.None)));
                    }
                    else if (item is JObject _itemObject && _itemObject.TryGetValue("user_id", out JToken userId))
                    {
                        collection.Add(userId.ToString(), item);
                        JObject myJObject = JObject.Parse(item.ToString());
                        jsonlist.Add(JsonConvert.DeserializeObject<Dictionary<string, object>>(myJObject.ToString(Newtonsoft.Json.Formatting.None)));
                    }
                    else
                    {
                        throw new Exception("Error key not found");
                    }
                }
            }
            return collection;
        }

        // Create multiple items
        public async Task<Dictionary<object, object>> MultipleCreate()
        {
            // Get the endpoint URL with System.Reflection 
            var multipleEndpoint = MainModel.GetMethod(nameof(GetMultipleEndpoint));
            this.endpoint = multipleEndpoint?.Invoke(null, null)?.ToString() ?? "";
            var content = new StringContent(arrtoJson(), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(GetMultipleEndpoint(), content);
            response.EnsureSuccessStatusCode();

            // Parse response content and add items to collection
            var responseContent = await response.Content.ReadAsStringAsync();
            dynamic jsonObject = JsonConvert.DeserializeObject(responseContent);
            JArray arraySuccess = jsonObject.success;
            foreach (JObject item in arraySuccess)
            {
                if (item.TryGetValue("item", out JToken entity))
                {
                    var entityId = entity.Value<int>("entity_id");
                    collection[entityId] = entity as JObject;
                    JObject myJObject = JObject.Parse(entity.ToString());
                    jsonlist.Add(JsonConvert.DeserializeObject<Dictionary<string, object>>(myJObject.ToString(Newtonsoft.Json.Formatting.None)));
                }
                else
                {
                    throw new Exception("Key 'item' not found in JSON response.");
                }
            }
            return collection;
        }


        //================================================================ACTIVITY==============================================================================

        

        // Load multiple activities
        public async Task<Dictionary<object, object>> LoadMultipleActivity(object _id, string _field = null)
        {
            if (_field != null) { field = $"/{_field}"; } else { field = ""; }
            id = _id;
            // Get the endpoint URL with System.Reflection 
            activityEndpoint = MainModel.GetMethod("GetEndpoint").Invoke(null, null).ToString();
            var response = await client.GetAsync(GetMultipleEndpoint());
            response.EnsureSuccessStatusCode();

            // Parse response content and add items to collection
            var responseContent = await response.Content.ReadAsStringAsync();
            dynamic obj = JsonConvert.DeserializeObject(responseContent);
            if (obj.items is JArray itemsArray)
            {
                foreach (var item in itemsArray)
                {
                    if (item is JObject itemObject && itemObject.TryGetValue("entity_id", out JToken entityId))
                    {
                        collection.Add(entityId.ToString(), item);
                        JObject myJObject = JObject.Parse(item.ToString());
                        jsonlist.Add(JsonConvert.DeserializeObject<Dictionary<string, object>>(myJObject.ToString(Newtonsoft.Json.Formatting.None)));
                    }
                    else
                    {
                        throw new Exception("Error key not found");
                    }
                }
            }
            return collection;
        }

        // Create multiple activities
        public async Task<Dictionary<object, object>> MultipleCreateActivity(object _id, string _field = null)
        {
            if (_field != null) { field = $"/{_field}"; } else { field = ""; }
            id = _id;

            // Get the endpoint URL with System.Reflection 
            activityEndpoint = MainModel.GetMethod("GetEndpoint").Invoke(null, null).ToString();
            var content = new StringContent(arrtoJson(), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(GetMultipleEndpoint(), content);
            response.EnsureSuccessStatusCode();

            // Parse response content and add items to collection
            var responseContent = await response.Content.ReadAsStringAsync();
            dynamic jsonObject = JsonConvert.DeserializeObject(responseContent);
            foreach (var item in jsonObject.success)
            {
                if (item is JObject itemObject && itemObject.TryGetValue("entity_id", out JToken entityId))
                {
                    collection.Add(entityId, item);
                }
                else
                {
                    throw new Exception($"After deserialisation of the JSON and manipulation, a 'Key not found' error occurred.");
                }
            }
            return collection;
        }
    }
}