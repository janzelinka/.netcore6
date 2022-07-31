using Core.Etities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data {

    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext Context;
        public ProductRepository(StoreContext _context)
        {
            Context = _context;
        }


        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await Context.Products.FindAsync(id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await Context.Products.ToListAsync();
        }
    }
}