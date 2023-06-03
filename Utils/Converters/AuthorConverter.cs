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
    internal class AuthorConverter
    {
        public static JObject EntityToJson()
        {
            return null;
        }

        public static Author? JsonToEntity(JObject json)
        {
            return JsonConvert.DeserializeObject<Author>(json.ToString());
        }

        public static HashSet<JObject> EntitySetToJsonSet()
        {
            return new HashSet<JObject>();
        }

        public static HashSet<Author> JsonSetToEntitySet(HashSet<JObject> data)
        {
            HashSet<Author> authors = data.Select(x => JsonConvert.DeserializeObject<Author>(x.ToString())).ToHashSet();
            return authors;
        }
    }
}
