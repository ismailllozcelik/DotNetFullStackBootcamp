using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Homework
{
    //📜 List için Extension Method:

    //List türündeki bir koleksiyona, elemanları tersine çeviren veya belirli bir sıraya göre sıralayan
    //    bir extension method yazın. Örneğin, ReverseOrder adlı bir method ile listeyi ters sıraya çevirin.

    internal static class ListExtension
    {
        public static List<T> ReverseOrder<T>(this List<T> list)
        {
            list.Reverse();
            return list;
        }
    }
}
