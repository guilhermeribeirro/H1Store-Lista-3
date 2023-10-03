using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace H1Store.Catalogo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorController(IFornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

        [HttpPost(Name = "Adicionar")]
        public IActionResult Post(NovoFornecedorViewModel novoFornecedorViewModel)
        {
            _fornecedorService.Adicionar(novoFornecedorViewModel);

            return Ok();
        }


        [HttpGet(Name = "ObterTodos")]
        public IActionResult Get()
        {
            return Ok(_fornecedorService.ObterTodos());
        }
    }
}
