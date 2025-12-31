
using Microsoft.AspNetCore.Mvc;
using ProductAPICRUD.Models;

namespace ProductAPICRUD.Services
{
    public interface IProductService
    {
        Task<ActionResult<IEnumerable<Product>>> GetProducts();
    }
}
