using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Homework
{
    //🔢 Algoritmalar (Algorithms):

    //Generic method kullanarak, farklı veri tiplerinde çalışan bir sıralama algoritması (sorting algorithm) tasarlayın.
    //    Örneğin, bir Sort<T> methodu yazın ve bu methodun int[], string[] gibi farklı tiplerdeki dizileri sıralayabilmesini sağlayın.
    //Kod örneği ile birlikte, bu metodun tip güvenliği ve kod tekrarını nasıl önlediğini açıklayın.

    internal class Algorithms<T>
    {
        public T[] Sort(T[] array)
        {
            Array.Sort(array);
            return array;
        }

        // Açıklama: Bu metod, farklı veri tiplerinde çalışan bir sıralama algoritmasıdır.
        // Bu metod, int[], string[] gibi farklı tiplerdeki dizileri sıralayabilir.
        // Bu metodun tip güvenliği ve kod tekrarını önlemesi, aynı sıralama algoritmasını farklı veri tipleri için tekrar tekrar yazmamızı engeller.
        // Bu sayede, aynı sıralama algoritmasını farklı veri tipleri için kullanabiliriz.

    }
}
