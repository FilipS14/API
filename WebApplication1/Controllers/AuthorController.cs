using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.Controllers
{
    [Route("get-all")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _autorService;

        public AuthorController(IAuthorService autorService)
        {
            _autorService = autorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var autori = await _autorService.GetAllAuthorsAsync();
            return Ok(autori);
        }
    }
}
