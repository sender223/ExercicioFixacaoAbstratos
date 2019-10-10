
namespace ExercicioFixacaoAbstratos.Entidades {
    class PessoaFisica : Pessoas {

        public double GastoSaude { get; set; }
        //construtor padrao importando a Superclasse para herdar as propriedades
        //nome e renda Anual.
        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) 
            : base(nome, rendaAnual) {
            GastoSaude = gastoSaude;
        }
        //aqui importamos o metodo abstrato da Superclasse e modificamos 
        //conforme necessário. 
        public override double CalculoImposto() {
            double impostoTotal = 0.00;
            if (RendaAnual < 20000.00) {
                impostoTotal = (RendaAnual * 0.15) - (GastoSaude * 0.50);
            }
            else {
                impostoTotal = (RendaAnual * 0.25) - (GastoSaude * 0.50);
            }
            return impostoTotal;
        }
    }
}
