using System;
using Newtonsoft.Json;

namespace blockchain.utils
{
    public class GenericJSON
    {
        public static T JsonToObject<T>(string json) where T : class
        {
            try
            {
                T values = JsonConvert.DeserializeObject<T>(json);
                return values;
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}
