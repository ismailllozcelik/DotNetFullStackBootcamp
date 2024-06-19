// See https://aka.ms/new-console-template for more information


// 1. Soru
// Single Responsibility Principle (SRP) tek bir sınıfın sadece bir işi yapmasını önerir.
using Hafta2Odevleri;

InvoiceService invoiceService = new InvoiceService(new Invoice(), new EmailSender());
invoiceService.ProcessInvoice("Send by SRP");
