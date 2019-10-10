namespace ExercicioFixacaoAbstratos.Entidades {
    abstract class Pessoas {

        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Pessoas(string nome, double rendaAnual) {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
        //aqui como a classe é abstrata, precisamos somente criar 
        //um metodo simples sem retorno de valor.
        public abstract double CalculoImposto();
    }    
}
