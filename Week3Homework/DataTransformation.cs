using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Homework
{
    //🔄 Veri Dönüşümü (Data Transformation):

    //Generic method kullanarak, bir veri tipinden başka bir veri tipine dönüşüm yapan bir yapı tasarlayın.
    //    Örneğin, bir ConvertTo<T> methodu ile List<string> türündeki bir veriyi List<int> türüne dönüştürün.
    //Kod örneği ile birlikte, bu dönüşümün nasıl yapıldığını ve generic methodların bu süreçteki avantajlarını açıklayın.
    internal class DataTransformation
    {
        public List<T2> ConvertTo<T, T2>(List<T> list)
        {
            List<T2> convertedList = new List<T2>();
            foreach (var item in list)
            {
                convertedList.Add((T2)Convert.ChangeType(item, typeof(T2)));
            }
            return convertedList;
        }
    }

    // Açıklama: Bu örnekte, generic method kullanarak, bir veri tipinden başka bir veri tipine dönüşüm yapan bir yapı tasarladım.
    // Örneğin, bir ConvertTo<T> methodu ile List<string> türündeki bir veriyi List<int> türüne dönüştürdüm.
    // Bu dönüşümü yaparken, Convert.ChangeType methodunu kullandım. Bu method, bir nesneyi belirtilen türe dönüştürür.
    // Bu örnekte, generic methodların, farklı veri tipleri arasında dönüşüm yaparken, kod tekrarını önlediğini ve kodun daha okunabilir ve bakımı daha kolay hale getirdiğini görebiliriz.
    // Ayrıca, generic methodlar, kodun daha esnek ve genel kullanıma uygun olmasını sağlar.
    // Bu örnekte, ConvertTo methodunu kullanarak, List<string> türündeki bir veriyi List<int> türüne dönüştürdüm.
}