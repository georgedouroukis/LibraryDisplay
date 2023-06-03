using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using LibraryDisplay.Models;
using LibraryDisplay.Utils.Converters;

namespace LibraryDisplay.Network
{
    internal class GetRequests
    {
        public static async Task<Book> GetBookById(string id)
        {
            JObject? responceData = new JObject();//to avoid null pointer exception
            try
            {
                using (var client = new HttpClient())
                {
                    Uri endpoint = new Uri("http://localhost:8080/api/books/" + id);
                    HttpResponseMessage responce = await client.GetAsync(endpoint);
                    var json = await responce.Content.ReadAsStringAsync();
                    JObject responceObject = JObject.Parse(json);

                    if (responce.IsSuccessStatusCode)
                    {
                        responceData = responceObject["data"] as JObject;
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
            Book book = BookConverter.JsonToEntity(responceData);
            return book!;
        }

        public static async Task<Publisher> GetPublisherById(string id)
        {
            JObject? responceData = new JObject();
            try
            {
                using (var client = new HttpClient())
                {
                    Uri endpoint = new Uri("http://localhost:8080/api/publishers/" + id);
                    HttpResponseMessage responce = await client.GetAsync(endpoint);
                    var json = await responce.Content.ReadAsStringAsync();
                    JObject responceObject = JObject.Parse(json);

                    if (responce.IsSuccessStatusCode)
                    {
                        responceData = responceObject["data"] as JObject;
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
            Publisher publisher = PublisherConverter.JsonToEntity(responceData);
            return publisher!;
        }

        public static async Task<Author> GetAuthorById(string id)
        {
            JObject? responceData = new JObject();
            try
            {
                using (var client = new HttpClient())
                {
                    Uri endpoint = new Uri("http://localhost:8080/api/authors/" + id);
                    HttpResponseMessage responce = await client.GetAsync(endpoint);
                    var json = await responce.Content.ReadAsStringAsync();
                    JObject responceObject = JObject.Parse(json);

                    if (responce.IsSuccessStatusCode)
                    {
                        responceData = responceObject["data"] as JObject;
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
            Author author = AuthorConverter.JsonToEntity(responceData);
            return author!;
        }

        public static async Task<Genre> GetGenreById(string id)
        {
            JObject? responceData = new JObject();
            try
            {
                using (var client = new HttpClient())
                {
                    Uri endpoint = new Uri("http://localhost:8080/api/genres/" + id);
                    HttpResponseMessage responce = await client.GetAsync(endpoint);
                    var json = await responce.Content.ReadAsStringAsync();
                    JObject responceObject = JObject.Parse(json);

                    if (responce.IsSuccessStatusCode)
                    {
                        responceData = responceObject["data"] as JObject;
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
            Genre genre = GenreConverter.JsonToEntity(responceData);
            return genre!;
        }

        public static async Task<HashSet<Genre>> GetGenres()
        {
            HashSet<JObject> responceData = new HashSet<JObject>();
            try
            {
                using (var client = new HttpClient())
                {
                    Uri endpoint = new Uri("http://localhost:8080/api/genres");
                    HttpResponseMessage responce = await client.GetAsync(endpoint);
                    var json = await responce.Content.ReadAsStringAsync();
                    JObject responceObject = JObject.Parse(json);

                    if (responce.IsSuccessStatusCode)
                    {
                        foreach (var item in responceObject["data"]!)
                        {
                            responceData.Add(item as JObject);
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
            HashSet<Genre> genres = GenreConverter.JsonSetToEntitySet(responceData);
            return genres;
        }

        public static async Task<HashSet<Book>> GetBooks()
        {
            HashSet<JObject> responceData = new HashSet<JObject>();
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
                            responceData.Add(item as JObject);
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
            HashSet<Book> books = BookConverter.JsonSetToEntitySet(responceData);
            return books;
        }

        public static async Task<HashSet<Publisher>> GetPublishers()
        {
            HashSet<JObject> responceData = new HashSet<JObject>();

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
                            responceData.Add(item as JObject);
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
            HashSet<Publisher> publishers = PublisherConverter.JsonSetToEntitySet(responceData);
            return publishers;
        }

        public static async Task<HashSet<Author>> GetAuthors()
        {
            HashSet<JObject> responceData = new HashSet<JObject>();
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
                            responceData.Add(item as JObject);
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
            HashSet<Author> authors = AuthorConverter.JsonSetToEntitySet(responceData);
            return authors;
        }

    }
}
