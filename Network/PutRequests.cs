using LibraryDisplay.Models;
using LibraryDisplay.Utils.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDisplay.Network
{
    internal class PutRequests
    {
        public static async Task<JObject> UpdateEntity<T>(T entity) where T:IRoutable
        {
            JObject idResponce = new JObject();
            string requestBody = GenericConverter.EntityToJson(entity);
            try
            {
                using (var client = new HttpClient())
                {
                    string endpoint = $"http://localhost:8080/api/{entity.route}/save";
                    HttpContent content = new StringContent(requestBody);
                    content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    HttpResponseMessage responce = await client.PutAsync(endpoint, content);

                    var json = await responce.Content.ReadAsStringAsync();
                    JObject responceObject = JObject.Parse(json);

                    if (responce.IsSuccessStatusCode)
                    {
                        idResponce = responceObject["data"]! as JObject;
                    }
                    else
                    {
                        MessageBox.Show(responceObject["error"]!.ToString(), "Status Code: " + responce.StatusCode.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.GetType().ToString());
            }
            return idResponce!;
        }

    }
}
