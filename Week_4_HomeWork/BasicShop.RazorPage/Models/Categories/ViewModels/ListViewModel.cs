namespace BasicShop.RazorPage.Models.Categories.ViewModels
{
    public class ListViewModel
    {
        public ListViewModel() { }
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
    }
}
