using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDisplay.Network
{
    internal class ImageHandler
    {
        public static async Task<Image> GetImageFromUrl(string url)
        {
            byte[] responceData = null;
            try
            {
                using (var client = new HttpClient())
                {
                    Uri endpoint = new Uri(url);
                    HttpResponseMessage responce = await client.GetAsync(endpoint);
                    if (responce.IsSuccessStatusCode)
                    {
                        responceData = await responce.Content.ReadAsByteArrayAsync();
                    }
                    else
                    {
                        MessageBox.Show("Status Code: " + responce.StatusCode.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.GetType().ToString());
            }
            Image image = ByteArrayToImage(responceData);
            return image;
        }

        private static Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
    }
}
