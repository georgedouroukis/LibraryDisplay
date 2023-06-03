using LibraryDisplay.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDisplay.Utils.Converters
{
    internal class PublisherConverter
    {
        public static JObject EntityToJson()
        {
            return null;
        }

        public static Publisher? JsonToEntity(JObject json)
        {
            return JsonConvert.DeserializeObject<Publisher>(json.ToString());
        }

        public static HashSet<JObject> EntitySetToJsonSet()
        {
            return new HashSet<JObject>();
        }

        public static HashSet<Publisher> JsonSetToEntitySet()
        {
            return new HashSet<Publisher>();
        }
    }
}
