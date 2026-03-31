using Microsoft.AspNetCore.Mvc;
using Magazine.Core.Models;

namespace Magazine.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service = new ProductService();

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _service.Add(product);
            return Ok(result);
        }

        [HttpDelete("remove/{id}")]
        public IActionResult Remove(Guid id)
        {
            var result = _service.Remove(id);
            return Ok(result);
        }

        [HttpPut("edit")]
        public IActionResult Edit(Product product)
        {
            var result = _service.Edit(product);
            return Ok(result);
        }

        [HttpGet("search")]
        public IActionResult Search(string name)
        {
            var result = _service.Search(name);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}