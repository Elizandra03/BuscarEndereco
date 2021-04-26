using System;
using Newtonsoft.Json.Linq;

namespace BuscaEndereco.Util
{
    public static class Extension
    {
        public static T Parse<T>(this string token)
        {
            try
            {
                return (T)Activator.CreateInstance(typeof(T), token);
            }
            catch (Exception)
            {
                return default;
            }
        }
    }
}