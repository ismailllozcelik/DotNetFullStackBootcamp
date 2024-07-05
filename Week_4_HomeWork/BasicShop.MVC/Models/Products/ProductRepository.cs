

namespace BasicShop.MVC.Models.Product
{
    public class ProductRepository : IProductRepository
    {
        private static List<Product> ProductList = new();

        public void Add(Product product)
        {
            ProductList.Add(product);
        }

        public void Delete(int id)
        {
            ProductList.RemoveAll(p => p.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return ProductList;
        }

        public Product GetById(int id)
        {
            var product = ProductList.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new Exception("Product not found");
            }
            return product;
        }

        public void Update(Product product)
        {
            var productToUpdate = ProductList.FirstOrDefault(p => p.Id == product.Id);
            if (productToUpdate == null)
            {
                throw new Exception("Product not found");
            }
            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;
            productToUpdate.Description = product.Description;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ImageUrl = product.ImageUrl;
        }
    }
}
