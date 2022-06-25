namespace exer2
{
    public class PessoaIMC
    {
        private double Altura { get; set; }
        private double Peso { get; set; }

        public PessoaIMC(double altura, double peso)
        {
            this.Altura = altura;
            this.Peso = peso;
        }

        public double CalculoImc()
        {
            return Peso / Math.Pow(Altura,2);
        }
      
    }
}