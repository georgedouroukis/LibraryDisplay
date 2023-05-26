﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace LibraryDisplay
{
    public enum DbTable { Book = 1, Author = 2, Publisher = 3, Genre = 4 }
    internal class GetRequests
    {
        public static async Task<JObject> GetBookById(string id)
        {
            JObject? responceData =new JObject();//to avoid null pointer exception
            try
            {
                using (var client = new HttpClient())
                {
                    Uri endpoint = new Uri("http://localhost:8080/api/books/"+id);
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
            return responceData!;
        }

        public static async Task<JObject> GetPublisherById(string id)
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
            return responceData!;
        }

        public static async Task<JObject> GetAuthorsById(string id)
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
            return responceData!;
        }

        public static async Task<JObject> GetGenresById(string id)
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
            return responceData!;
        }
    }
}
