using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharedModels
{
    public static class Json
    {
        private static JsonSerializerSettings GetSerializationSettings()
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                TypeNameHandling = TypeNameHandling.Objects,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple
            };
            settings.Converters.Add(new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd\\THH:mm:ss.fffK" }); // From Breeze v1.4.11: "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK"
            settings.Converters.Add(new StringEnumConverter());
            return settings;
        }

        public static string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, GetSerializationSettings());
        }

        public static object Deserialize(string jSonString)
        {
            return JsonConvert.DeserializeObject(jSonString, GetSerializationSettings());
        }

        public static T Deserialize<T>(string obj)
        {
            return JsonConvert.DeserializeObject<T>(obj, GetSerializationSettings());
        }

        public static object Deserialize(string obj, Type type)
        {
            return JsonConvert.DeserializeObject(obj, type);
        }
    }
}
