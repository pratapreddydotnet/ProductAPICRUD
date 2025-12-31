using Microsoft.AspNetCore.Mvc;
using ProductAPICRUD.Models;

namespace ProductAPICRUD.Repository
{
    public interface IProductRepository
    {
        Task<ActionResult<IEnumerable<Product>>> GetProducts();
    }
}
