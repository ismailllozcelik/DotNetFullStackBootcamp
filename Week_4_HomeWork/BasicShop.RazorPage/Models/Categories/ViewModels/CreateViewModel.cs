using System.ComponentModel.DataAnnotations;

namespace BasicShop.RazorPage.Models.Categories.ViewModels
{
    public class CreateViewModel
    {
        public CreateViewModel()
        {
            
        }

        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage = "Kategori adı boş bırakılamaz.")]
        public string Name { get; set; } = default!;

        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
    }
}
