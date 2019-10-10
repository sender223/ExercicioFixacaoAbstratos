namespace ExercicioFixacaoAbstratos.Entidades {
    class PessoaJuridica : Pessoas{

        public int NumeroFunci { get; set; }
        //construtor padrao importando a Superclasse para herdar as propriedades
        //nome e renda Anual.
        public PessoaJuridica(string nome, double rendaAnual, int numeroFunci) 
            : base (nome, rendaAnual ) {
            NumeroFunci = numeroFunci;
        }
        //aqui importamos o metodo abstrato da Superclasse e modificamos 
        //conforme necessário. 
        public override double CalculoImposto() {
            double impostoTotal = 0.00;
            if (NumeroFunci > 10) {
                impostoTotal = RendaAnual * 0.14;
            }
            else {
                impostoTotal = RendaAnual * 0.16;
            }
            return impostoTotal;
        }
    }
}
