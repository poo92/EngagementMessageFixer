using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedModels;

namespace Services.Util
{
    public static class ObjectExtensions
    {
        public static string ToJsonString(this object obj)
        {
            return Json.Serialize(obj);
        }

        public static Stream ToJsonStream(this object obj)
        {
            var json = obj.ToJsonString();
            return new MemoryStream(Encoding.UTF8.GetBytes(json));
        }
    }
}
