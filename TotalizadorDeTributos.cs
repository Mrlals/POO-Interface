using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class TotalizadorDeTributos
    {
        //Crie outra classe chamada TotalizadorDeTributos , que será responsável por acumular os impostos das diferentes classes tributáveis, 
        public double TotalImposto{ get; private set; } = 0;
        public void TotalTributacao(ContaCorrente contaCorrente)
        {
            this.TotalImposto = contaCorrente.CalculaTributos();
        }
        public void TotalTributacao(SeguroDeVida seguroDeVida)
        {
            this.TotalImposto = seguroDeVida.CalculaTributos();
        }

    }
}