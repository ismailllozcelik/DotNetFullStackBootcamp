using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Homework
{
    //📋 ICollection için Extension Method:

    //ICollection türündeki bir koleksiyona, eleman ekleme veya çıkarma işlemlerini daha kolay hale
    //    getiren bir extension method yazın. Örneğin, AddRange<T> adlı bir method ile birden fazla
    //    elemanı tek seferde ekleyin.
    public static class CollectionExtension
    {
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                collection.Add(item);
            }
        }
    }
}
