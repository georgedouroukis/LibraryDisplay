using LibraryDisplay.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibraryDisplay.Utils.Converters
{
    internal class BookConverter
    {
        public static JObject EntityToJson()
        {
            return null;
        }

        public static Book? JsonToEntity(JObject json)
        {
            return JsonConvert.DeserializeObject<Book>(json.ToString());
        }

        public static HashSet<JObject> EntitySetToJsonSet()
        {
            return new HashSet<JObject>();
        }

        public static HashSet<Book> JsonSetToEntitySet(HashSet<JObject> data)
        {
            HashSet<Book> books = data.Select(x => JsonConvert.DeserializeObject<Book>(x.ToString())).ToHashSet();
            return books;
        }
    }
}
