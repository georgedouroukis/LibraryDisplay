using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDisplay
{
    internal class SearchUtility
    {
        public static List<ListViewItem> listViewItems = new List<ListViewItem>();

        public static  List<ListViewItem> Search(string text, bool books, bool authors, bool publishers)
        {
            listViewItems.Clear();
            if (books)
            {
                 bookSearch(text);
            }
            if (authors)
            {
                authorSearch(text);
            }
            if (publishers)
            {
                publisherSearch(text);
            }
            return listViewItems;
        }

        private static void  bookSearch(string text)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    Uri endpoint = new Uri("http://localhost:8080/api/books");
                    HttpResponseMessage responce =  client.GetAsync(endpoint).Result;
                    var json =  responce.Content.ReadAsStringAsync().Result;
                    JObject responceObject = JObject.Parse(json);

                    if (responce.IsSuccessStatusCode)
                    {
                        foreach (var item in responceObject["data"]) 
                        {
                            if (item["title"].ToString().Contains(text, StringComparison.CurrentCultureIgnoreCase))
                            {
                                ListViewItem searchItem = new ListViewItem("Book");
                                searchItem.SubItems.Add(item["title"].ToString());
                                searchItem.SubItems.Add(item["id"].ToString());
                                listViewItems.Add(searchItem);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(responceObject["error"].ToString(),"Status Code: " + responce.StatusCode.ToString());
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,e.GetType().ToString());
            }
           
        }

        private static void authorSearch(string text)
        {

        }

        private static void publisherSearch(string text)
        {

        }
    }
}
