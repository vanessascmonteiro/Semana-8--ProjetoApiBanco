using projetoApi.Interface;
using projetoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace projetoApi.Controllers;

     [Route("cliente")]
    public class ClientesControllers : Controller
    {
        private IClienteService _clienteService; 
        
        public ClientesControllers(IClienteService clienteService)
        {
           _clienteService = clienteService;
        }

     [HttpPost]
     [Route("pessoaFisica")]
     public ActionResult PostPessoaFisica([FromBody] PessoaFisica pessoaFisica)
     {
        _clienteService.CriarConta(pessoaFisica);
        return Created (Request.Path, pessoaFisica);
     }
        
    [HttpPost]
     [Route("pessoaJuridica")]
     public ActionResult PostPessoaJuridica([FromBody] PessoaJuridica pessoaJuridica)
     {
        _clienteService.CriarConta(pessoaJuridica);
        return Created (Request.Path, pessoaJuridica);
     }

    [HttpGet]
    [Route("pessoajuridica")]

    public ActionResult ExibirPessoaJuridica()
    {
        
        return Ok(_clienteService.ExibirClientesPJ());

    } 
    
    [HttpGet]
    [Route("{id}")]
    public ActionResult ObterClienteComId ([FromRoute] int id)
    {
        return  Ok(_clienteService.BuscarCliente(id));
    }

    [HttpPut] 
    [Route ("pessoaFisica/{id}")]
    public ActionResult AtualizarPessoaFisica ([FromBody] PessoaFisica pessoaFisica, int id)
    {
        _clienteService.AtualizarPessoaFisica(pessoaFisica, id);
        return Ok();      
     } 
    
    [HttpPut]
    [Route("pessoajuridica/{id}")]
    public ActionResult AtualizarPessoaJuridica([FromBody] PessoaJuridica pessoaJuridica, int id)
    {
        _clienteService.AtualizarPessoaJuridica(pessoaJuridica, id);
        return Ok();

    }

    [HttpDelete]
    [Route("{id}")]
    public ActionResult DeletarCliente([FromRoute] int id)
    {
        Cliente clienteDeletar = _clienteService.BuscarCliente(id);

        if (clienteDeletar.Saldo != 0)
        {
            return BadRequest($"Não foi possível deletar cliente. Cliente há saldo de: {clienteDeletar.Saldo}");
        }


        _clienteService.DeletarCliente(id);
        return Ok();
   
        
    }
}