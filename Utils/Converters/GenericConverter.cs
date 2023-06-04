using LibraryDisplay.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDisplay.Utils.Converters
{
    internal class GenericConverter
    {
        public static string EntityToJson<T>(T entity)
        {
            return JsonConvert.SerializeObject(entity);
        }

        public static T? JsonToEntity<T>(JObject json)
        {
            return JsonConvert.DeserializeObject<T>(json.ToString());
        }

        public static HashSet<JObject> EntitySetToJsonSet()
        {
            return new HashSet<JObject>();
        }

        public static HashSet<T> JsonSetToEntitySet<T>(HashSet<JObject> data)
        {
            HashSet<T> entities = data.Select(x => JsonConvert.DeserializeObject<T>(x.ToString())).ToHashSet();
            return entities;
        }
    }
}
