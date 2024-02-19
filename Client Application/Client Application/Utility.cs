using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client_Application
{
    internal static class Utility
    {
        public static DT GetOriginalData<DT>(this string jsonData)
        {
            return JsonSerializer.Deserialize<DT>(jsonData);
        }
    }
}
