using Core.Etities;
using Core.Interfaces;

namespace Infrastructure.Data {

    public class ProductRepository : IProductRepository
    {
        public Task<Product> GetProductByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}