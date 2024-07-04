
namespace BasicShop.MVC.Models.Product
{
    public class ProductService : IProductRepository
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Add(Product product)
        {
            _productRepository.Add(product);
        }

        public void Delete(int id)
        {
            var productToDelete = _productRepository.GetById(id);
            if (productToDelete == null)
            {
                throw new Exception("Product not found");
            }
            _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
           return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            var product = _productRepository.GetById(id);
            if (product == null)
            {
                throw new Exception("Product not found");
            }
            return product;
        }

        public void Update(Product product)
        {
           var produtToUpdate = _productRepository.GetById(product.Id);
            if (produtToUpdate == null)
              {
                throw new Exception("Product not found");
              }
            _productRepository.Update(product);
        }
    }
}
