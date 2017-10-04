using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace consumerApi.Models
{
    public class Funcionario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public string Turno { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorDaHora { get; set; }

        public double SalarioFinal { get; set; }

        public double ValorVenda { get; set; }

        public double getSalarioFinal()
        {
            if (this.Funcao.Equals("Vendedor"))
            {
                SalarioFinal = (HorasTrabalhadas * ValorDaHora);
                if (ValorVenda > 0)
                {
                    return SalarioFinal = SalarioFinal + (ValorVenda * 0.20);
                }
            } else if (this.Funcao.Equals("Faxineiro") && this.Turno.Equals("noturno"))
            {
                SalarioFinal = (HorasTrabalhadas * ValorDaHora);
                return SalarioFinal = SalarioFinal + (SalarioFinal * 0.05);
            } else
            {
                return SalarioFinal = (HorasTrabalhadas * ValorDaHora);
            }
            return SalarioFinal;
        }

        public double getValorVenda()
        {
            if (this.Funcao.Equals("Vendedor"))
            {
                ValorVenda = 200.00;
            }
            else
            {
                ValorVenda = 0;
            }
            return ValorVenda;
        }
       
        
    }
}