using Microsoft.AspNetCore.Mvc;
using ProductAPICRUD.Models;
using ProductAPICRUD.Repository;

namespace ProductAPICRUD.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
           var data = await _repository.GetProducts();
            return data;
        }
    }
}
