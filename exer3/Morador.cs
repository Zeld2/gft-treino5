namespace exer3
{
    public class Morador
    {
        private string Telefone { get; set; }

        private int NumeroResidencia { get; set; }

        public bool Cachorro { get; set; }

       public int Correspondencias { get; set; }


        public Morador(string telefone, int numeroResidencia, bool cachorro)
        {
            this.Telefone = telefone;
            this.Cachorro = cachorro;
            this.NumeroResidencia = numeroResidencia;
        }

        public override string ToString()
        {
            
            return "Telefone: " + Telefone + "| Número da residência: " + NumeroResidencia;
        }

        public string TemCachorro()
        {
            string temCachorro = "";
            if(Cachorro) temCachorro = "Sim";
            else temCachorro = "Não"; 
            return temCachorro;
        }
        public void EntregarCorrespondencia()
        {
            Correspondencias ++;
        }

        public bool ParOuImpar()
        {
            if(NumeroResidencia%2==0) return true;
            else return false;
        }
    }
}