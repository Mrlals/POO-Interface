using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceTributavel
{
    public class SeguroDeVida: ITributavel
    {
        //Crie outra classe chamada de SeguroDeVida e faça com que essa classe implemente a interface Itributavel, 
        //o método CalculaTributos do SeguroDeVida deve devolver um valor constante de 75 reais
        public double CalculaTributos()
        {
            return 75.0;
        }
    }
}