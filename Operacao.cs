namespace aula3
{
    public class Operacao
    {
        public string Somar(int valorUm, int valorDois){
            int somar = valorUm + valorDois;
            return $"A soma é: {somar}";
        }

        public string Subtrair(int valorUm, int valorDois)
        {
            int subtrair = valorUm - valorDois;
            return $"O resultado da subtração é {subtrair}";
        }

        public string Multiplicar(int valorUm, int valorDois){
            int result = valorUm * valorDois;
            return $"Resultado: {result}";
        }
    }
}