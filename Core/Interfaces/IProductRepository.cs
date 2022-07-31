using Core.Etities;

namespace Core.Interfaces {
    public interface IProductRepository {
        Task<Product> GetProductByIdAsync();
        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}