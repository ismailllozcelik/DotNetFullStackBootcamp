using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Homework
{
    //🔍 IEnumerable için Extension Method:

    //IEnumerable türündeki bir koleksiyondan, belirli bir koşula göre filtreleme yapabilen bir extension
    //    method yazın. Örneğin, WhereGreaterThan adlı bir method ile belirli bir değerden büyük olan elemanları
    //    filtreleyin.

    internal static class EnumerableExtension
    {
        public static IEnumerable<T> WhereGreaterThan<T>(this IEnumerable<T> source, T value) where T : IComparable
        {
            foreach (var item in source)
            {
                if (item.CompareTo(value) > 0)
                {
                    // burada yield return kullanıldığı için, bu metot çağrıldığında, bu döngüye girmeyecek.

                    yield return item;
                }
            }
        }
    }
}
