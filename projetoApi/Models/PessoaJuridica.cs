using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoApi.Models
{
    public class PessoaJuridica : Cliente
    {
    public string CNPJ { get; set; }
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    public List<string> Socios { get; set; } = new List<string>();
    public DateTime DataAbertura { get; set; }

    public PessoaJuridica(string email, string telefone, string endereco, int numeroConta, List <Transacao> extrato, string cnpj, string razaoSocial, string nomeFantasia, DateTime dataAbertura)
    : base(numeroConta,endereco, telefone, email, extrato)
    {
      CNPJ = cnpj;
      RazaoSocial = razaoSocial;
      NomeFantasia = nomeFantasia;
      DataAbertura = dataAbertura;

    }
    
    public override string ResumoCliente()
    {

        string resumo = $"{NumeroConta}  |  {RazaoSocial}  |  {NomeFantasia}  |  {CNPJ}";
        
        foreach (var socio in Socios)
        {
            resumo += $" |{socio} ";
        }
        
        return resumo;
       
    }

}
}
