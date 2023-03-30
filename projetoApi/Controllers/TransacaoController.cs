using projetoApi.Interface;
using projetoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace projetoApi.Controllers;


[Route("transacao")]

    public class TransacaoController : Controller
    {
        private IClienteService _clienteService;
        private TransacaoController(IClienteService clienteServices)
        {
            _clienteService = clienteServices;
        }    
       
        
    [HttpPost]
    [Route("{idCliente}")]
    public ActionResult AdicionarTransacao([FromBody] Transacao transacao, [FromRoute] int idCliente)
    {
        _clienteService.AdicionarTransacao(transacao, idCliente);
        return Created(Request.Path, transacao);
    }

    [HttpGet]
    [Route("{idCliente}")]
    public ActionResult ConsultarExtrato([FromRoute] int idCliente)
    {
        return Ok(_clienteService.ListarTransacao(idCliente));
    }

    }
