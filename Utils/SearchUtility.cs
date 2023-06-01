using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDisplay.Utils
{
    internal class SearchUtility
    {
        public static List<ListViewItem> listViewItems = new List<ListViewItem>();

        public static async Task<List<ListViewItem>> Search(string text, bool books, bool authors, bool publishers)
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
            List<JObject> list = await GetRequests.GetAuthors();
            foreach (var item in list)
            {
                string fullName = item["firstName"]!.ToString() + " " + item["lastName"]!.ToString() + " " + item["middleName"]!.ToString();
                if (fullName.Contains(text, StringComparison.CurrentCultureIgnoreCase))
                {
                    ListViewItem searchItem = new ListViewItem(fullName);
                    searchItem.SubItems.Add("Author");
                    searchItem.SubItems.Add(item["id"]!.ToString());
                    listViewItems.Add(searchItem);
                }
            }
        }

        private static async Task bookSearch(string text)
        {
            List<JObject> list = await GetRequests.GetBooks();
            foreach (var item in list)
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

        private static async Task publisherSearch(string text)
        {
            List<JObject> list = await GetRequests.GetPublishers();
            foreach (var item in list)
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
    }
}
