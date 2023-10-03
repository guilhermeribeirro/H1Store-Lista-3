using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace H1Store.Catalogo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaServices _categoriaService;

        public CategoriaController(ICategoriaServices categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpPost(Name = "Adicionar")]
        public IActionResult Post(NovoCategoriaViewModel novoCategoriaViewModel)
        {
            _categoriaService.Adicionar(novoCategoriaViewModel);

            return Ok();
        }


        [HttpGet(Name = "ObterTodos")]
        public IActionResult Get()
        {
            return Ok(_categoriaService.ObterTodos());
        }
    }
}
