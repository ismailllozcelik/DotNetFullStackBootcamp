﻿namespace BasicShop.RazorPage.Pages.Product
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = default!;
        public int CategoryId { get; set; }
    }
}