using ContaAPI.Dtos;
using GestaoFinanceiraAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Spring.Objects.Factory.Attributes;

namespace ContaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaController : ControllerBase
    {
        [Autowired]
        private BuscarPagamentoService buscaPagamentoService = new BuscarPagamentoService();

        [HttpGet("{id}")]
        public IActionResult BuscarContaPorId(int id)
        {
            ContaResponse contaResponse = buscaPagamentoService.BuscarPagamento(id);
            if (contaResponse == null)
            {
                return NotFound();
            }
            return Ok(contaResponse);
        }
        
        //[HttpPost]
        //public IActionResult ValidarGestaoFinanceira([FromBody] DataRequest dataDto)
        //{

            //return CreatedAtAction(); 
        //} 
    }
}
