using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetoApi.Models;

namespace projetoApi.Models
{
    public class PessoaFisica : Cliente
    {
        public string Nome {get; set;}
        public string Cpf {get; set;}

        public DateTime DataNascimento { get; set; }

        public PessoaFisica(int numeroConta, string endereco, string telefone, string email, List<Transacao> extrato,
        string nome, string cpf, DateTime dataNascimento) : base(numeroConta,endereco, telefone, email, extrato)
    {
        Email = email;
        Telefone = telefone;
        Endereco = endereco;
        NumeroConta = numeroConta;
        Extrato = extrato;
        Nome = nome;
        Cpf = cpf;
        DataNascimento = dataNascimento;

    }

        public int Idade { get {return (int)(Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.25)); } private set {}}

        
        public override string ResumoCliente()
        {
           return $"{NumeroConta}     |{Nome}    | {Cpf}        |{DataNascimento}   |{Endereco}  | {Telefone}";

        }
        public bool EhMaior()
        {
            return Idade >= 18;

        }
    }
}