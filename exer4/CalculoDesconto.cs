namespace exer4
{
    public static class CalculoDesconto
    {
        public static void TabelaDesconto(double valorCompra)
        {
            double percentual = 0;
            var valorFinal = valorCompra;
            if(valorCompra<300)
            {
                System.Console.WriteLine($"R${valorCompra} - {percentual*100}% - R${valorFinal}");
            }
            else
            {
                percentual = 0.01+(Math.Floor((valorCompra-300)/100))/100;
                valorFinal = valorCompra * (1-percentual);
                System.Console.WriteLine($"R${valorCompra} - {percentual*100}% - R${valorFinal}");

            }
        }
    }
}