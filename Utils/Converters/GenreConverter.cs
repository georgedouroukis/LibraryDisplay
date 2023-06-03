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
    internal class GenreConverter
    {
        public static JObject EntityToJson()
        {
            return null;
        }

        public static Genre? JsonToEntity(JObject json)
        {
            return JsonConvert.DeserializeObject<Genre>(json.ToString());
        }

        public static HashSet<JObject> EntitySetToJsonSet()
        {
            return new HashSet<JObject>();
        }

        public static HashSet<Genre> JsonSetToEntitySet(HashSet<JObject> data)
        {
            HashSet<Genre> genres = data.Select(x => JsonConvert.DeserializeObject<Genre>(x.ToString())).ToHashSet();
            return genres;
        }
    }
}
