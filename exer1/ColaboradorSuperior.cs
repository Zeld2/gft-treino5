namespace exer1
{
    public class ColaboradorSuperior : ColaboradorEnsino
    {
        protected string Universidade { get; set; }
        
        
        public ColaboradorSuperior(string nome, string matricula, string escola, string universidade) : base(nome, matricula, escola)
        {
            this.Universidade = universidade;
        }

        public override string ToString()
        {
            return Name + ", " + Matricula + ", " + Escola + ", " + Universidade;
        }
    }
}