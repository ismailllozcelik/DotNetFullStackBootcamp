namespace BasicShop.RazorPage.Models.Products
{
    public class ProductService : IProductService
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
            var deleteToProduct = _productRepository.GetById(id);
            if (deleteToProduct == null)
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
            var updateToProduct = _productRepository.GetById(product.Id);
            if (updateToProduct == null)
            {
                throw new Exception("Product not found");
            }
            _productRepository.Update(product);
        }
    }
}
