namespace exer4
{
    public static class CalculoDesconto
    {
        public static void TabelaDesconto(double valorCompra)
        {
            int percentual = 0;
            var valorFinal = valorCompra;
            if(valorCompra<300)
            {
                System.Console.WriteLine($"R${valorCompra} - {percentual}% - R${valorFinal}");
            }
            else
            {
                percentual = 1+(((int)valorCompra)-300)/100;
                valorFinal = valorCompra * (1-((double)percentual/100));
                System.Console.WriteLine($"R${valorCompra} - {percentual}% - R${valorFinal}");

            }
        }
    }
}