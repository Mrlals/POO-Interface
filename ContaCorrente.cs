using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class ContaCorrente : ITributavel
    {
        //Crie a classe chamada de ContaCorrente que implemente a interface Itributavel, que pagará 5% de seu saldo como imposto
       public double Saldo {get; set;}
       public ContaCorrente(double saldo)
       {
            Saldo = saldo;
       }
       public double CalculaTributos()
       {
            return Saldo * 0.05;
       }

    }
}