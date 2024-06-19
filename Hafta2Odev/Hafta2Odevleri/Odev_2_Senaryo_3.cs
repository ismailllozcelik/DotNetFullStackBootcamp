using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Odevleri
{
    //   Senaryo 3: Finansal Uygulama
    // Açıklama:
    // Bir finansal uygulama, kullanıcıların hesap hareketlerini izlemesine ve belirli 
    // olaylardan haberdar olmasına olanak tanır.Örneğin, belirli bir tutarın üzerinde bir işlem gerçekleştirildiğinde
    // veya bir hesapta belirli bir limitin altına düşüldüğünde bu olaylar için event ve delegate kullanılabilir.

    // Delegate tanımlanması
    public delegate void AccountEventHandler(string message);

    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal Limit { get; set; }

        // Event tanımlanması
        public event AccountEventHandler BalanceChanged;
        public event AccountEventHandler LimitExceeded;

        public void Deposit(decimal amount)
        {
            Balance += amount;
            BalanceChanged?.Invoke($"Deposit: {amount}");
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            BalanceChanged?.Invoke($"Withdraw: {amount}");

            if (Balance < Limit)
            {
                LimitExceeded?.Invoke($"Limit exceeded. Balance: {Balance}");
            }
        }
    }

    public class FinancialApplication
    {
        public void StartApplication()
        {
            Account account = new Account { AccountNumber = "123456", Balance = 1000, Limit = 500 };
            account.BalanceChanged += OnBalanceChanged;
            account.LimitExceeded += OnLimitExceeded;

            account.Deposit(500);
            account.Withdraw(200);
            account.Withdraw(500);
        }

        public void OnBalanceChanged(string message)
        {
            Console.WriteLine($"Balance Changed: {message}");
        }

        public void OnLimitExceeded(string message)
        {
            Console.WriteLine($"Limit Exceeded: {message}");
        }
    }
}
