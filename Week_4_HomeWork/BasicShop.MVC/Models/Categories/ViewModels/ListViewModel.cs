namespace BasicShop.MVC.Models.Category.ViewModels
{
    public class ListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
    }
}
