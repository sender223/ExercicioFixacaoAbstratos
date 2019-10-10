using System;
using System.Globalization;
using ExercicioFixacaoAbstratos.Entidades;
using System.Collections.Generic;

namespace ExercicioFixacaoAbstratos {
    class Program {
        static void Main(string[] args) {

            List<Pessoas> lista = new List<Pessoas>();

            Console.WriteLine("Entre com a quantidade de tarifas a ser calculado: ");
            int qnt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qnt; i++) {
                Console.WriteLine($"Dados do {i}º Imposto: ");
                Console.Write("Pessoal ou Empresa? p/e: ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipo == 'p') {
                    Console.Write("Gasto com Saúde: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new PessoaFisica(nome, renda, gastoSaude));
                }
                else {
                    Console.Write("Quantidade de Empregados: ");
                    int qntFunci = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(nome, renda, qntFunci));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Taxas a serem Pagas: ");
            foreach (Pessoas pesso in lista) {
                Console.WriteLine("Nome: " + pesso.Nome 
                    + " $ " + pesso.CalculoImposto().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
