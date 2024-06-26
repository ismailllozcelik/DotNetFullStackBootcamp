using Microsoft.AspNetCore.Mvc;
using Mvc.App.Models;
using System.Diagnostics;

namespace Mvc.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //Ödev: MVC ve Razor Pages Projeleri için Veri Taşıma Örnekleri
        //Açıklama: Bu ödevde, hem MVC hem de Razor Pages projelerinde
        //    veri taşımak için kullanılan ViewBag, ViewData, TempData ve ViewModel yapılarını
        //    anlamanız ve kullanmanız istenmektedir. Her bir yapının nasıl kullanıldığını ve hangi 
        //    durumlarda tercih edildiğini örneklerle açıklayın.

        //İstenilenler:

        //👜 ViewBag Kullanımı
        //📦 ViewData Kullanımı:
        //⏳ TempData Kullanımı:
        //📊 ViewModel Kullanımı: 

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //👜 ViewBag Kullanımı:
            // Açıklama : ViewBag, Controller'dan View'e veri taşımak için kullanılır.
            // ViewBag, dinamik bir yapıya sahiptir ve her türlü veri taşınabilir.
            // boxing ve unboxing işlemleri yapar. Bu sebeple performansı düşüktür.
            ViewBag.Message = "ViewBag'den Hello World!";


            //📦 ViewData Kullanımı:
            // Açıklama : ViewData, Controller'dan View'e veri taşımak için kullanılır.
            // ViewBag gibi dinamik bir yapıya sahip değildir. Dictionary yapısını kullanır.
            // boxing ve unboxing işlemleri yapar. Bu sebeple performansı düşüktür.
            ViewData["Message"] = "ViewData'dan Hello World!";

            //⏳ TempData Kullanımı:
            // Açıklama : TempData, Controller'dan View'e veri taşımak için kullanılır.
            // TempData, bir sonraki request'e kadar veriyi taşır. TempData, Session'a benzer.
            // Cookie bazlı çalışır. TempData, bir kez okunduktan sonra silinir.
            // şifreli bir şekilde cookie içerisinde tutulur.
            // Benim favorim kesinlikle TempData'dir. :) :) :)
            TempData["Message"] = "TempData'dan Hello World!";

            //📊 ViewModel Kullanımı:
            // Açıklama : ViewModel, Controller'dan View'e veri taşımak için kullanılır.
            // ViewModel, Controller ve View arasında veri taşımak için kullanılır.
            // ViewModel, Controller'dan View'e birden fazla veri taşımak için kullanılır.
            // ViewModel, Controller ve View arasında güçlü bir bağlantı sağlar.
            // Best pracitce olarak kullanılır.

           var viewModel = new ProductViewModel
            {
                Id = 1,
                Name = "Kalem",
                Price = 10,
                Description = "Kırmızı Kalem"
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
