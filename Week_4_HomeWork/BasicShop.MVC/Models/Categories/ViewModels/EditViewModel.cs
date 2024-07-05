using System.ComponentModel.DataAnnotations;

namespace BasicShop.MVC.Models.Category.ViewModels
{
    public class EditViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage = "Kategori adı boş bırakılamaz.")]

        public string Name { get; set; } = default!;

        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
    }
}
