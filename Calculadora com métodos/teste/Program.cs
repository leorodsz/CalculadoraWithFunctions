namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char cont = 's';

            while (cont == 's') 
            {     
            Console.WriteLine("Menu");
            Console.WriteLine("============================");
            Console.WriteLine("[1] Soma");
            Console.WriteLine("[2] Subtração");
            Console.WriteLine("[3] Multiplicação");
            Console.WriteLine("[4] Divisão");
            Console.WriteLine("[5] Sair");

            Console.WriteLine("\nDigite a opção desejada: ");
            int op = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeio numero: ");
            int numone = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo numero: ");
            int numtwo = int.Parse(Console.ReadLine());


            switch (op) {
                case 1:
                    Console.WriteLine("Soma");
                    Teste.basicSum(numone, numtwo);
                    break;

                case 2 :
                    Console.WriteLine("Subtração");
                    Teste.basicSub(numone, numtwo);
                    break;

                case 3:
                    Console.WriteLine("Multiplicação");
                    Teste.basicMult(numone, numtwo);
                    break;

                case 4:
                    Console.WriteLine("Divisão");
                    Teste.basicDiv(numone, numtwo);
                    break;

                case 5:
                    Teste.basicExit();
                    break;
            }
                Console.WriteLine("Deseja continuar? [s/n]");
                cont = char.Parse(Console.ReadLine());
            }
    }
}

    public class Teste
    {
        public static int basicSum(int num1, int num2)
        {
            int soma = num1 + num2;       
            Console.WriteLine("A soma de " + num1 + " + " + num2 + " é igual a: " + soma);
            return soma;
        }

        public static int basicSub(int num1, int num2)
        {
            int sub = num1 - num2;
            Console.WriteLine("A subtração de " + num1 + " - " + num2 + " é igual a: " + sub);
            return sub;
        }

        public static int basicMult(int num1, int num2)
        {
            int mult = num1 * num2;
            Console.WriteLine("A multiplicação de " + num1 + " * " + num2 + " é igual a: " + mult);
            return mult;
        }

        public static int basicDiv(int num1, int num2)
        {
            int div = num1 / num2;
            Console.WriteLine("A divisão de " + num1 + " / " + num2 + " é igual a: " + div);
            return div;
        }

        public static int basicExit()
        {
            Console.WriteLine("Saindo....");
            return 0;
        }
    }
}