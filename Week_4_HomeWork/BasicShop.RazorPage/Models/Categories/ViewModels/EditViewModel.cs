namespace BasicShop.RazorPage.Models.Categories.ViewModels
{
    public class EditViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }

        public EditViewModel()
        {
            
        }
    }
}
