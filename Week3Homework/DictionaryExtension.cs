using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Homework
{
    //🔑 Dictionary için Extension Method:

    //Dictionary türündeki bir koleksiyona, belirli bir anahtar-değer çiftini arama veya
    //    çıkartma işlemlerini kolaylaştıran bir extension method yazın.
    //    Örneğin, GetOrDefault adlı bir method ile belirtilen
    //    anahtarın değerini bulun, yoksa varsayılan bir değer döndürün.
    internal static class DictionaryExtension
    {
        public static TValue GetOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
        {
            TValue value;
            // out value nedir? ne işe yarar? 
            // out value, dictionary.TryGetValue(key, out value) metodu ile dictionary
            // içerisindeki key değerini arar ve bulursa value değişkenine atar.
            return dictionary.TryGetValue(key, out value) ? value : defaultValue;
        }
    }
}
