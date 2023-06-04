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
    internal class PublisherConverter
    {
        public static string EntityToJson(Publisher publisher)
        {
            return JsonConvert.SerializeObject(publisher);
        }

        public static Publisher? JsonToEntity(JObject json)
        {
            return JsonConvert.DeserializeObject<Publisher>(json.ToString());
        }

        public static HashSet<JObject> EntitySetToJsonSet()
        {
            return new HashSet<JObject>();
        }

        public static HashSet<Publisher> JsonSetToEntitySet(HashSet<JObject> data)
        {
            HashSet<Publisher> publishers = data.Select(x => JsonConvert.DeserializeObject<Publisher>(x.ToString())).ToHashSet();
            return publishers;
        }
    }
}
