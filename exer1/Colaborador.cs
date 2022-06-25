namespace exer1
{
    public class Colaborador
    {
        protected string Name { get; set; }
        protected string Matricula { get; set; }

        public Colaborador(string nome, string matricula)
        {
            this.Name = nome;

            this.Matricula = matricula;
        }

        public override string ToString()
        {
            return Name + ", " + Matricula;
        }
    }
}