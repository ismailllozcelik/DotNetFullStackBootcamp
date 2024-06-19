// See https://aka.ms/new-console-template for more information



using Hafta2Odevleri;

// 1. Soru
// Single Responsibility Principle (SRP) tek bir sınıfın sadece bir işi yapmasını önerir.
#region Single Responsibility Princible
//InvoiceService invoiceService = new InvoiceService(new Invoice(), new EmailSender());
//invoiceService.ProcessInvoice("Send by SRP");
#endregion


// 1. Soru
// Open Closed Principle (OCP) bir sınıfın genişletilebilir olması ancak değiştirilemez olması gerektiğini önerir.
#region Open Closed Principle

//var regularSavingAccount = new RegularSavingAccount();
//Console.WriteLine($"Calculated with Regular Saving Account. Interest is {regularSavingAccount.CalculateInterest()}");

//var salarySavingAccount = new SalarySavingAccount();
//Console.WriteLine($"Calculated with Regular Saving Account. Interest is {salarySavingAccount.CalculateInterest()}"); 

#endregion

// 1. Soru
// Liskov Substitution Principle (LSP) bir sınıfın alt sınıflarının üst sınıfın yerine geçebilmesi gerektiğini önerir.
#region Liskov Substitution Principle
//Shape rectangle = new Rectangle();
//Console.WriteLine($"Rectangle Area: {rectangle.Area()}");

//Shape square = new Square();
//Console.WriteLine($"Square Area: {square.Area()}");
#endregion

// 1. Soru
// Interface Segregation Principle (ISP) bir sınıfın ihtiyaç duymadığı metotları içermemesi gerektiğini önerir.
#region Interface Segregation Principle
//var bird = new Bird();
//bird.Fly();
//bird.Swim();
#endregion

// 1. Soru
// Dependency Inversion Principle (DIP) bir sınıfın başka bir sınıfa bağımlı olmaması gerektiğini önerir.
#region Dependency Inversion Principle
//var invoiceService = new InvoiceService(new Invoice(), new EmailSender());
//invoiceService.ProcessInvoice("Send by DIP");
#endregion

// 2. Soru
// Bir e-ticaret sistemi, müşterilerin alışveriş yapmasına ve sipariş vermesine olanak tanır.Bu sistemde, sipariş tamamlandığında müşteriye ve ilgili departmanlara bilgi vermek için event ve delegate kullanılabilir.
//Delegate ve Event Kullanımı:
//Bir delegate tanımlanır ve sipariş tamamlandığında tetiklenecek event için kullanılır.
//Müşteri hizmetleri departmanı, siparişin tamamlandığını bildiren bir e-posta göndermek için bu event'e abone olur.
//Depo yönetim sistemi, stoktan düşülmesi gereken ürünleri güncellemek için aynı event'e abone olur.
//Muhasebe departmanı, fatura oluşturmak için bu event'e abone olur.
#region Event and Delegate

//// Sipariş oluşturma
//Order order = new Order
//{
//    OrderId = 1,
//    CustomerName = "İsmail Özçelik",
//    OrderDate = DateTime.Now,
//    Items = new List<string> { "Laptop", "Mouse", "Keyboard" }
//};

//// Departmanlar
//CustomerService customerService = new CustomerService();
//WarehouseManagement warehouseManagement = new WarehouseManagement();
//Accounting accounting = new Accounting();

//// Event'e abone olma
//order.OrderCompleted += customerService.OnOrderCompleted;
//order.OrderCompleted += warehouseManagement.OnOrderCompleted;
//order.OrderCompleted += accounting.OnOrderCompleted;

//// Sipariş tamamlama
//order.CompleteOrder();

#endregion

// 2. soru
// Senaryo 2: Oyun Geliştirme
// Açıklama:
// Bir oyun geliştirme projesinde, oyun içerisindeki karakterlerin belirli 
// olaylara tepki vermesi gerekmektedir.Örneğin, bir karakterin canı belirli bir
// seviyenin altına düştüğünde veya bir düşman öldüğünde bu olaylara tepki vermek için event ve delegate kullanılabilir.

#region Game Development
//Game game = new Game();
//game.StartGame();
#endregion

// 2. soru
// Senaryo 3: Finansal Uygulama
// Açıklama:
// Bir finansal uygulama, kullanıcıların hesap hareketlerini izlemesine ve belirli
// olaylardan haberdar olmasına olanak tanır.Örneğin, belirli bir tutarın üzerinde bir işlem gerçekleştirildiğinde
// veya bir hesapta belirli bir limitin altına düşüldüğünde bu olaylar için event ve delegate kullanılabilir.

#region Financial Application
FinancialApplication financialApplication = new FinancialApplication();
financialApplication.StartApplication();
#endregion
