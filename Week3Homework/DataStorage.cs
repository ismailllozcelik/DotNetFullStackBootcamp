using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Homework
{
    //📂 Veri Depolama(Data Storage):

    //Bir generic sınıf oluşturarak, farklı veri tiplerinde elemanları depolayabilen bir yapı tasarlayın. Örneğin, bir DataStore<T> 
    //    sınıfı oluşturun ve bu sınıf ile hem int hem string türünde verileri saklayın.
    //Örnek kod ve açıklama ile birlikte, bu yaklaşımın esnekliğini ve kod tekrarını nasıl azalttığını açıklayın.

    internal class DataStorage<T>
    {
       public Dictionary<string, T> store = new Dictionary<string, T>();
    }

    // Açıklama: Bu örnekte, DataStorage<T> sınıfı oluşturularak, farklı veri tiplerinde elemanları depolayabilen bir yapı tasarlanmıştır.
    //    Bu yapı sayesinde, hem int hem string türünde veriler saklanabilmektedir. Bu sayede, kod tekrarını önlemek ve esneklik sağlamak
    //    mümkün olmuştur.
    //    Örneğin, DataStorage<int> ve DataStorage<string> sınıfları oluşturularak, int ve string türünde veriler saklanabilmektedir.
    //    Bu sayede, aynı işlemi yapmak için ayrı ayrı sınıflar oluşturmak yerine, tek bir sınıf kullanılarak işlem yapılabilmektedir.
    //    Bu durum, kod tekrarını önlemekte ve esneklik sağlamaktadır.
   
}
