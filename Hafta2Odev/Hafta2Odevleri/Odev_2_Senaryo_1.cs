using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Odevleri
{
    //    Senaryo 1: E-Ticaret Sistemi

    //Açıklama:
    //Bir e-ticaret sistemi, müşterilerin alışveriş yapmasına ve sipariş vermesine olanak tanır.Bu sistemde, sipariş tamamlandığında müşteriye ve ilgili departmanlara bilgi vermek için event ve delegate kullanılabilir.

    //Delegate ve Event Kullanımı:
    //Bir delegate tanımlanır ve sipariş tamamlandığında tetiklenecek event için kullanılır.
    //Müşteri hizmetleri departmanı, siparişin tamamlandığını bildiren bir e-posta göndermek için bu event'e abone olur.
    //Depo yönetim sistemi, stoktan düşülmesi gereken ürünleri güncellemek için aynı event'e abone olur.
    //Muhasebe departmanı, fatura oluşturmak için bu event'e abone olur.

    // Delegeta tanımlanması
    public delegate void OrderCompletedEventHandler(string message);

    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public List<string> Items { get; set; }
        // Event tanımlanması
        public event OrderCompletedEventHandler OrderCompleted;

        public void CompleteOrder()
        {
            // Sipariş tamamlandığında event tetiklenir
            OrderCompleted?.Invoke($"Order {OrderId} completed. Customer: {CustomerName}");
        }

    }

    public class CustomerService
    {
        public void OnOrderCompleted(string message)
        {
            Console.WriteLine($"Customer Service Notification: {message}");
            // E-posta gönderme işlemleri yapılır
        }
    }

    public class WarehouseManagement
    {
        public void OnOrderCompleted(string message)
        {
            Console.WriteLine($"Warehouse Management Notification: {message}");
            // Stok güncelleme işlemleri yapılır
        }
    }

    public class Accounting
    {
        public void OnOrderCompleted(string message)
        {
            Console.WriteLine($"Accounting Notification: {message}");
            // Fatura oluşturma işlemleri yapılır
        }
    }
}