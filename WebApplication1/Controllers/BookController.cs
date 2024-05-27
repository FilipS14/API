using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Core.Services;
namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _carteService;

        public BookController(IBookService carteService)
        {
            _carteService = carteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var carti = await _carteService.GetAllBooksAsync();
            return Ok(carti);
        }
    }
}
