using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Odevleri
{
    public class Invoice
    {
        public void GenerateInvoice()
        {
            // Fatura oluşturma işlemleri
            Console.WriteLine("Invoice generated.");
        }
    }

    public class EmailSender
    {
        public void SendEmail(string email, string content)
        {
            // Email gönderme işlemleri
            Console.WriteLine($"Email sent to {email} with content: {content}");
        }
    }

    public class InvoiceService(Invoice invoice, EmailSender emailSender)
    {

        public void ProcessInvoice(string email)
        {
            invoice.GenerateInvoice();
            emailSender.SendEmail(email, "Invoice has been generated.");
        }
    }
}
