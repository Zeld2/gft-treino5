namespace exer1
{
    public class ColaboradorEnsino : Colaborador
    {
        protected string Escola { get; set; }
        
        
        public ColaboradorEnsino(string nome, string matricula, string escola) : base(nome, matricula)
        {
            this.Escola = escola;
        }

        public override string ToString()
        {
            return Name + ", " + Matricula + ", " + Escola;
        }
    }
}