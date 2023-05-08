using Deepser.Entity;
using Deepser.Entity.Service;
using Deepser.Framework;
using Deepser.Framework.Request;
using Deepser.Framework.Data;
using Newtonsoft.Json;
using System.Text;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Reflection.Metadata;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Net.Http.Headers;

namespace Deepser
{
    // This is an abstract class that contains the basic functionality for CRUD (create, read, update, delete) operations
    public abstract class AbstractEntity :Data
    {
        // Define the endpoint and multiple_endpoint for the entity
        protected string ENDPOINT;
        protected string MULTIPLE_ENDPOINT;

        // Internal fields for the entity
        internal string? field;
        internal object? activity_id;
        internal HttpClient client = new HttpClient();
        internal object? id;
        internal AbstractEntity entity = null;

        public AbstractEntity()
        {
            client.DefaultRequestHeaders.Authorization = Authentication.AutomaticAuth.AuthorizationHeader;
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        // Get the ID of the entity
        public string GetId()
        {
            return $"/{id}";
        }

        // Get the field of the entity
        public string GetField()
        {
            return (field != null) ? $"/{field}" : field;
        }

        // Get the endpoint of the entity
        public string GetEndpoint()
        {
            return $"{Authentication.AutomaticAuth.GetHost()}/api/rest{ENDPOINT}{GetId()}{GetField()}";
        }

        // Get the activity endpoint of the entity
        public string GetActivityEndpoint()
        {
            return $"/activity/{activity_id}";
        }

        // Get the multiple endpoint of the entity
        public string GetMultipleEndpoint()
        {
            return $"{Authentication.AutomaticAuth.GetHost()}/api/rest{MULTIPLE_ENDPOINT}";
        }

        // Load an entity 
        public async Task<AbstractEntity> Load(object _id, string _field = null)
        {
            this.id = _id;
            this.field= _field;
            var response = await client.GetAsync($"{GetEndpoint()}");
            var responseContent = await response.Content.ReadAsStringAsync();
            if (responseContent != null && response.IsSuccessStatusCode)
            {
                this.data = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);
            }
            else
            {
                dynamic responseConvert = JsonConvert.DeserializeObject(responseContent);
                string errorMessage = responseConvert["messages"]["error"][0]["message"];
                throw new Exception($"Loading failed, error description: \"{errorMessage}\"");
            }
            return this;
        }

        // Create an entity
        public async Task<AbstractEntity> Create()
        {
            var content = new StringContent(toJson(), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(GetMultipleEndpoint(), content);
            var responseContent = await response.Content.ReadAsStringAsync();
            if (responseContent != null && response.IsSuccessStatusCode)
            {
                this.data = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);
            }
            else
            {
                dynamic responseConvert = JsonConvert.DeserializeObject(responseContent);
                string errorMessage = responseConvert["messages"]["error"][0]["message"];
                throw new Exception($"Creation failed, error description: \"{errorMessage}\"");
            }
            return this;
        }

        // Update an entity
        public async Task<AbstractEntity> Update(object _id, string _field = null)
        {
            this.id = _id;
            this.field = _field;
            var content = new StringContent(toJson(), Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{GetEndpoint()}", content);
            var responseContent = await response.Content.ReadAsStringAsync();
            if (responseContent != null && response.IsSuccessStatusCode)
            {
                this.data = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);
            }
            else 
            {
                dynamic responseConvert = JsonConvert.DeserializeObject(responseContent);
                string errorMessage = responseConvert["messages"]["error"][0]["message"];
                throw new Exception($"Update failed, error description: \"{errorMessage}\"");
            }
            return this;
        }

        //Delete an Entity
        public async Task<string> Delete(object _id, string _field = null)
        {
            this.id = _id;
            this.field = _field;
            var response = await client.DeleteAsync(GetEndpoint());
            var responseContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return $"Executed deletion: item({_id}) deleteted";
            }
            else
            {
                dynamic responseConvert = JsonConvert.DeserializeObject(responseContent);
                string errorMessage = responseConvert["messages"]["error"][0]["message"];
                throw new Exception($"Deletion failed, error description: \"{errorMessage}\"");
            }
        }


        //  ========================================ACTIVITY===========================================

        //Load an activity
        public async Task<AbstractEntity> LoadActivity(object _id, object _activity_id, string _field = null)
        {
            this.id = _id;
            this.field = _field;
            this.activity_id = _activity_id;
            string url = $"{GetEndpoint()}{GetActivityEndpoint()}";
            var response = await client.GetAsync(url);
            var responseContent = await response.Content.ReadAsStringAsync();
            if (responseContent != null && response.IsSuccessStatusCode)
            {
                this.data = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);
            }
            else 
            {
                dynamic responseConvert = JsonConvert.DeserializeObject(responseContent);
                string errorMessage = responseConvert["messages"]["error"][0]["message"];
                throw new Exception($"Loading activity failed, error description: \"{errorMessage}\"");
            }

            return this;
        }

        //Create an activity
        public async Task<AbstractEntity> CreateActivity(int _id, string _field = null)
        {
            this.id = _id;
            this.field = _field;
            string url = $"{GetEndpoint()}{Entity.Activity.MULTIPLE_ENDPOINT}";
            var content = new StringContent(toJson(), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);
            var responseContent = await response.Content.ReadAsStringAsync();
            if (responseContent != null && response.IsSuccessStatusCode)
            {
                this.data = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);
            }
            else
            {
                dynamic responseConvert = JsonConvert.DeserializeObject(responseContent);
                string errorMessage = responseConvert["messages"]["error"][0]["message"];
                throw new Exception($"Activity creation failed, error description: \"{errorMessage}\"");
            }
            return this;
        }

        //Update an activity
        public async Task<AbstractEntity> UpdateActivity(object _id, object _activity_id, string _field = null)
        {
            this.id = _id;
            this.field = _field;
            this.activity_id = _activity_id;
            string url = $"{GetEndpoint()}{GetActivityEndpoint()}";
            var content = new StringContent(toJson(), Encoding.UTF8, "application/json");
            var response = await client.PutAsync(url, content);
            var responseContent = await response.Content.ReadAsStringAsync();
            if (responseContent != null && response.IsSuccessStatusCode)
            {
                this.data = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);
            }
            else
            {
                dynamic responseConvert = JsonConvert.DeserializeObject(responseContent);
                string errorMessage = responseConvert["messages"]["error"][0]["message"];
                throw new Exception($"Failed activity update, error description: \"{errorMessage}\"");
            }
            return this;

        }

        //Delete an activity
        public async Task<string> DeleteActivity(int _id,  int _activity_id, string _field = null)
        {
            this.id = _id;
            this.field = _field;
            this.activity_id = _activity_id;
            string url = $"{GetEndpoint()}{GetActivityEndpoint()}";
            var response = await client.DeleteAsync(url);
            var responseContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return $"Executed Activity deletion: activity ({_activity_id}) of item({_id}) deleteted";
            }
            else
            {
                dynamic responseConvert = JsonConvert.DeserializeObject(responseContent);
                string errorMessage = responseConvert["messages"]["error"][0]["message"];
                throw new Exception($"Deleting activity failed, error description: \"{errorMessage}\"");
            }
        }
    }
}

