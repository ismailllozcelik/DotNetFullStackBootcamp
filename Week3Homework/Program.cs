// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using Week3Homework;
using static System.Runtime.InteropServices.JavaScript.JSType;

#region Homework 1
////Ödev: Generic Method ve Class'lar ile İlgili 3 Gerçek Dünya Örneği
////Açıklama: Bu ödevde, generic method ve generic class kavramlarını gerçek dünya senaryolarında nasıl kullanabileceğinizi göstermeniz istenmektedir.

////İstenilenler:

////📂 Veri Depolama(Data Storage):
//Console.WriteLine("Data Storage Example: ");

//var dataStorage = new DataStorage<int>();
//dataStorage.store.Add("number1", 1);
//dataStorage.store.Add("number2", 2);
//var number2 = dataStorage.store["number2"];
//Console.WriteLine($"number2:  {number2}");

//var dataStorage2 = new DataStorage<string>();
//dataStorage2.store.Add("string1", "Hello");
//dataStorage2.store.Add("string2", "World");
//var string2 = dataStorage2.store["string2"];
//Console.WriteLine($"string2: {string2}");

//Console.WriteLine("-------------------------");

////🔢 Algoritmalar (Algorithms):
//Console.WriteLine("Algorithm Example: ");

//var algorithms = new Algorithms<int>();
//var sortedArray = algorithms.Sort(new int[] { 3, 2, 1 });
//Console.WriteLine($"sortedArray: {string.Join(", ", sortedArray)}");

//var algorithms2 = new Algorithms<string>();
//var sortedArray2 = algorithms2.Sort(new string[] { "c", "b", "a" });
//Console.WriteLine($"sortedArray2: {string.Join(", ", sortedArray2)}");

//Console.WriteLine("-------------------------");

////🔄 Veri Dönüşümü (Data Transformation):
//Console.WriteLine("Data Transformation Example: ");

//var dataTransformation = new DataTransformation();
//var convertedList = dataTransformation.ConvertTo<string, int>(new List<string> { "1", "2", "3" });
//Console.WriteLine($"convertedList: {string.Join(", ", convertedList)} type is {convertedList.GetType()}");

#endregion


#region Homework 2
////Ödev: Extension Methodlar ile İlgili Örnekler
////Açıklama: Bu ödevde, verilen sınıflar için çeşitli extension methodlar yazmanız istenmektedir.
////    Extension methodlar, mevcut sınıflara yeni yetenekler eklemek için kullanılır ve mevcut kodu
////    değiştirmeden yeni işlevsellikler sağlar.

////İstenilenler:

////📋 ICollection için Extension Method:
//Console.WriteLine("Collection Extension Example: ");

//var collection = new List<int> { 1, 2, 3 };
//collection.AddRange(new List<int> { 4, 5, 6, 7,8,9,10,11111 });
//Console.WriteLine($"collection: {string.Join(", ", collection)}");

//Console.WriteLine("-------------------------");

////🔍 IEnumerable için Extension Method:
//Console.WriteLine("Enumerable Extension Example: ");

//var enumerable = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//var greaterThan5 = enumerable.WhereGreaterThan(5);
//Console.WriteLine($"greaterThan5: {string.Join(", ", greaterThan5)}");


//Console.WriteLine("-------------------------");

////📜 List için Extension Method:
//Console.WriteLine("List Extension Example: ");

//var list = new List<int> { 1, 2, 3, 4, 5 };
//var reversedList = list.ReverseOrder();
//Console.WriteLine($"reversedList: {string.Join(", ", reversedList)}");

//Console.WriteLine("-------------------------");

////🔑 Dictionary için Extension Method:
//Console.WriteLine("Dictionary Extension Example: ");

//var dictionary = new Dictionary<string, int>
//{
//    { "number1", 1 },
//    { "number2", 2 }
//};
//var number2 = dictionary.GetOrDefault("number2", 0);
//Console.WriteLine($"number2: {number2}");

//var number3 = dictionary.GetOrDefault("number3", 0);
//Console.WriteLine($"number3: {number3}");

#endregion