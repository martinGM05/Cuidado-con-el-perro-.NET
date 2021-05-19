using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_CuidadoConElPerro.Sesiones
{
    public static class SessionHelper
    {
        public static void SetProductoAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetProductoFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            if (value == null)
            {
                return default(T);
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
        }
    }
}
