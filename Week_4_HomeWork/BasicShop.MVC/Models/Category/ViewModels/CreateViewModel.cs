using System.ComponentModel.DataAnnotations;

namespace BasicShop.MVC.Models.Category.ViewModels
{
    public class CreateViewModel
    {
        [Display(Name = "Kategori Adı : ")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Kategori adı boş bırakılamaz.")]
        [StringLength(50, ErrorMessage = "Kategori adı en fazla 50 karakter olabilir.")]
        [MinLength(3, ErrorMessage = "Kategori adı en az 3 karakter olabilir.")]
        public string Name { get; set; } = default!;

        [Display(Name = "Kategori Açıklaması : ")]
        public string? Description { get; set; }
    }
}
