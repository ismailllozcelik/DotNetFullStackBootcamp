// See https://aka.ms/new-console-template for more information
using Week3Homework;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");


//Ödev: Generic Method ve Class'lar ile İlgili 3 Gerçek Dünya Örneği
//Açıklama: Bu ödevde, generic method ve generic class kavramlarını gerçek dünya senaryolarında nasıl kullanabileceğinizi göstermeniz istenmektedir.

//İstenilenler:

//📂 Veri Depolama(Data Storage):
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

