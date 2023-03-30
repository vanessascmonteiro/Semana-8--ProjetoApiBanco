using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoApi.Models;

    public class Transacao
    {
        public DateTime Data {get; set;}
        public double Valor {get; set;}

        public Transacao()
        {

        }
        public Transacao(DateTime data, double valor)
        {
            Data = data;
            Valor = valor;
        }
    }
