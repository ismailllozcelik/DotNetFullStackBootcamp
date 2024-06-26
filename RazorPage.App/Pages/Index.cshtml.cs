using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage.App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
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

 
         public ProductViewModel Product { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // 👜 ViewBag Kullanımı:
            // Viewbag Razor pagede kullanılmıyormuş :)
            // ViewBag.Message = "ViewBag'den Hello World! Razor Page";

            // 📦 ViewData Kullanımı:
            // ViewData Razor ile kullanılır. ViewData, Controller'dan View'e veri taşımak için kullanılır.
            // ViewBag gibi dinamik bir yapıya sahip değildir. Dictionary yapısını kullanır.
            // boxing ve unboxing işlemleri yapar. Bu sebeple performansı düşüktür.
            ViewData["Message"] = "ViewData'dan Hello World! Razor Page";

            // ⏳ TempData Kullanımı:
            // TempData Razor ile kullanılır. TempData, Controller'dan View'e veri taşımak için kullanılır.
            // TempData, bir sonraki request'e kadar veriyi taşır. TempData, Session'a benzer.
            // Cookie bazlı çalışır. TempData, bir kez okunduktan sonra silinir.
            // şifreli bir şekilde cookie içerisinde tutulur.
            // Benim favorim kesinlikle TempData'dir. :) :) :)
            TempData["Message"] = "TempData'dan Hello World! Razor Page";

            // 📊 ViewModel Kullanımı:
            // ViewModel Razor ile kullanılır. ViewModel, Controller'dan View'e veri taşımak için kullanılır.
            // ViewModel, Controller ve View arasında veri taşımak için kullanılır.
            // ViewModel, Controller'dan View'e birden fazla veri taşımak için kullanılır.
            // ViewModel, Controller ve View arasında güçlü bir bağlantı sağlar.
            // Best pracitce olarak kullanılır.
            Product = new ProductViewModel
            {
                Id = 1,
                Name = "Kalem",
                Price = 5.99M,
                Description = "Kırmızı Kalem"
            };

        }
    }
}
