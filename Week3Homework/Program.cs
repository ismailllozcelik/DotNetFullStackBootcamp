﻿// See https://aka.ms/new-console-template for more information
using Week3Homework;
using static System.Runtime.InteropServices.JavaScript.JSType;


//Ödev: Generic Method ve Class'lar ile İlgili 3 Gerçek Dünya Örneği
//Açıklama: Bu ödevde, generic method ve generic class kavramlarını gerçek dünya senaryolarında nasıl kullanabileceğinizi göstermeniz istenmektedir.

//İstenilenler:

//📂 Veri Depolama(Data Storage):
Console.WriteLine("Data Storage Example: ");

var dataStorage = new DataStorage<int>();
dataStorage.store.Add("number1", 1);
dataStorage.store.Add("number2", 2);
var number2 = dataStorage.store["number2"];
Console.WriteLine($"number2:  {number2}");

var dataStorage2 = new DataStorage<string>();
dataStorage2.store.Add("string1", "Hello");
dataStorage2.store.Add("string2", "World");
var string2 = dataStorage2.store["string2"];
Console.WriteLine($"string2: {string2}");

Console.WriteLine("-------------------------");

//🔢 Algoritmalar (Algorithms):
Console.WriteLine("Algorithm Example: ");

var algorithms = new Algorithms<int>();
var sortedArray = algorithms.Sort(new int[] { 3, 2, 1 });
Console.WriteLine($"sortedArray: {string.Join(", ", sortedArray)}");

var algorithms2 = new Algorithms<string>();
var sortedArray2 = algorithms2.Sort(new string[] { "c", "b", "a" });
Console.WriteLine($"sortedArray2: {string.Join(", ", sortedArray2)}");


//🔄 Veri Dönüşümü (Data Transformation):

//Generic method kullanarak, bir veri tipinden başka bir veri tipine dönüşüm yapan bir yapı tasarlayın.
//    Örneğin, bir ConvertTo<T> methodu ile List<string> türündeki bir veriyi List<int> türüne dönüştürün.
//Kod örneği ile birlikte, bu dönüşümün nasıl yapıldığını ve generic methodların bu süreçteki avantajlarını açıklayın.