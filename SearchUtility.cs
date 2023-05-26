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

        public static  async Task<List<ListViewItem>> Search(string text, bool books, bool authors, bool publishers)
        {
            listViewItems.Clear();
            if (books)
            {
                await bookSearch(text);
            }
            if (authors)
            {
               await authorSearch(text);
            }
            if (publishers)
            {
                await publisherSearch(text);
            }
            return listViewItems;
        }

        private static async Task authorSearch(string text)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    Uri endpoint = new Uri("http://localhost:8080/api/authors");
                    HttpResponseMessage responce = await client.GetAsync(endpoint);
                    var json = await responce.Content.ReadAsStringAsync();
                    JObject responceObject = JObject.Parse(json);

                    if (responce.IsSuccessStatusCode)
                    {
                        foreach (var item in responceObject["data"]!) 
                        {
                            string fullName = item["firstName"]!.ToString() + " "+ item["lastName"]!.ToString() + " " + item["middleName"]!.ToString();
                            if (fullName.Contains(text, StringComparison.CurrentCultureIgnoreCase))
                            {
                                ListViewItem searchItem = new ListViewItem(fullName);
                                searchItem.SubItems.Add("Author");
                                searchItem.SubItems.Add(item["id"]!.ToString());
                                listViewItems.Add(searchItem);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(responceObject["error"]!.ToString(),"Status Code: " + responce.StatusCode.ToString());
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,e.GetType().ToString());
            }
           
        }

        private static async Task bookSearch(string text)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    Uri endpoint = new Uri("http://localhost:8080/api/books");
                    HttpResponseMessage responce = await client.GetAsync(endpoint);
                    var json = await responce.Content.ReadAsStringAsync();
                    JObject responceObject = JObject.Parse(json);

                    if (responce.IsSuccessStatusCode)
                    {
                        foreach (var item in responceObject["data"]!)
                        {
                            if (item["title"]!.ToString().Contains(text, StringComparison.CurrentCultureIgnoreCase))
                            {
                                ListViewItem searchItem = new ListViewItem(item["title"]!.ToString());
                                searchItem.SubItems.Add("Book");
                                searchItem.SubItems.Add(item["id"]!.ToString());
                                listViewItems.Add(searchItem);
                            }
                        }
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
        }

        private static async Task publisherSearch(string text)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    Uri endpoint = new Uri("http://localhost:8080/api/publishers");
                    HttpResponseMessage responce = await client.GetAsync(endpoint);
                    var json = await responce.Content.ReadAsStringAsync();
                    JObject responceObject = JObject.Parse(json);

                    if (responce.IsSuccessStatusCode)
                    {
                        foreach (var item in responceObject["data"]!)
                        {
                            if (item["name"]!.ToString().Contains(text, StringComparison.CurrentCultureIgnoreCase))
                            {
                                ListViewItem searchItem = new ListViewItem(item["name"]!.ToString());
                                searchItem.SubItems.Add("Publisher");
                                searchItem.SubItems.Add(item["id"]!.ToString());
                                listViewItems.Add(searchItem);
                            }
                        }
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
        }
    }
}
