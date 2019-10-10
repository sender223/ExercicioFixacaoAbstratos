namespace ExercicioFixacaoAbstratos.Entidades {
    abstract class Pessoas {

        public string Nome { get; set; }
        public double RendaAnual { get; set; }


        public Pessoas(string nome, double rendaAnual) {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalculoImposto();
    }    
}
