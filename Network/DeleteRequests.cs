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
    internal class DeleteRequests
    {
        public static async Task<string> DeleteEntity<T>(T entity) where T : IRoutable
        {
            string idResponce = string.Empty;
            string requestBody = GenericConverter.EntityToJson(entity);
            try
            {
                using (var client = new HttpClient())
                {
                    string endpoint = $"http://localhost:8080/api/{entity.route}/delete/{entity.id}";
                    HttpResponseMessage responce = await client.DeleteAsync(endpoint);

                    var json = await responce.Content.ReadAsStringAsync();
                    JObject responceObject = JObject.Parse(json);

                    if (responce.IsSuccessStatusCode)
                    {
                        idResponce = responceObject["data"]!.ToString();
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
