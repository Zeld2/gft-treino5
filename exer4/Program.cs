using static exer4.CalculoDesconto;

Console.WriteLine("Olá, qual o valor da compra na nossa loja de peças 3D?");

var valor = Double.Parse(Console.ReadLine());

TabelaDesconto(valor);
