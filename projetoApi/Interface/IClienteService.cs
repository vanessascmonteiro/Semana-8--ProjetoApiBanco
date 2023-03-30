using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetoApi.Models;

namespace projetoApi.Interface
{
    public interface IClienteService
    {
        void CriarConta(Cliente cliente);
        List<PessoaFisica> ExibirClientesPF();
        List<PessoaJuridica> ExibirClientesPJ();
        Cliente BuscarCliente(int id);
        Cliente AtualizarPessoaFisica(PessoaFisica pessoaFisica, int id);
        Cliente AtualizarPessoaJuridica(PessoaJuridica pessoaJuridica, int id);
        void DeletarCliente(int id);
        void AdicionarTransacao(Transacao transacao, int idCliente);
        List<Transacao> ListarTransacao(int idCliente);

    }
}