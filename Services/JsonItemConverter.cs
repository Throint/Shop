using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;

namespace TestEFC.Services
{
    public class JsonItemConverter
    {
        public static List<long> GetId(string JSON)
        {
            return (List<long>)JsonSerializer.Deserialize(JSON, typeof(List<long>));
        }
        public static string GetJsonString(List<long> list)
        {
            return JsonSerializer.Serialize(list);
        }
    }
}
