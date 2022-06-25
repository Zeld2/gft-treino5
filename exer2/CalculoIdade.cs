namespace exer2
{
    public static class CalculoIdade
    {
        public static int Idade(int anoNascimento)
        {
            var anoAtual = Int32.Parse(DateTime.Now.Year.ToString());

            return anoAtual - anoNascimento;
        }
    }
}