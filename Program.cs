using System;

namespace aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno objAula = new Aluno();

            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            string result = objAula.Mensagem(nome);
            Console.WriteLine(result);

            Console.WriteLine("1- Fazer operações");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Operacao objOper = new Operacao();
                    Console.WriteLine("Favor informar o valor um (inteiro): ");
                    int valorUm = int.Parse(Console.ReadLine());

                    Console.WriteLine("Favor informar o valor dois (inteiro): ");
                    int valorDois = int.Parse(Console.ReadLine());

                    result = objOper.Somar(valorUm, valorDois);
                    Console.WriteLine(result);

                    result = objOper.Subtrair(valorUm, valorDois);
                    Console.WriteLine(result);

                    break;

            }

            Console.ReadKey();
        }
    }
}
