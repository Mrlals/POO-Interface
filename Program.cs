// main()
//Faça instâncias de cada classe e teste no método main()
using InterfaceTributavel;

ContaCorrente cc = new ContaCorrente(2000);
Console.WriteLine($"Saldo: R${cc.Saldo} com Tributos de 5% sendo: R$ {cc.CalculaTributos()}");

SeguroDeVida sv = new SeguroDeVida();
Console.WriteLine($"Tributo Seguro de Vida: R${sv.CalculaTributos()}");

Console.WriteLine($"Totalizador dos tributos: R${sv.CalculaTributos() + cc.CalculaTributos()}");