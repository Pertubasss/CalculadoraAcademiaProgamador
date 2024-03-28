// See https://aka.ms/new-console-template for more information


public class Program
{
    static void Main(string[] args)
    {
        //Calculadora!

        int operacao;

        do
        {
            Console.WriteLine(">>>>Calculadora<<<<\n");

            Console.WriteLine("1 - Soma\n" 
                + "2 - Subtração\n"
                + "3 - Divisão\n"
                + "4 - Multiplicação\n"
                + "5 - Sair\n");

            Console.Write("Escolha a operação que deseja realizar: ");

            operacao = Convert.ToInt32(Console.ReadLine());

            if (operacao < 0 || operacao > 5)
            {
                Console.WriteLine("Operação invalida. Por favor, digite uma operação válida!");
            }
            else if (operacao == 5)
            {
                break;
            }

            Console.Write("\nDigite o primeiro numero: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    Console.WriteLine($"Soma = {(firstNum + secondNum):F2}");
                    break;

                case 2:
                    Console.WriteLine($"Subtração = {(firstNum - secondNum):F2}");
                    break;

                case 3:
                    if (secondNum == 0)
                    {
                        Console.WriteLine("\nNão é possivel dividir por zero");
                        break;
                    }

                    Console.WriteLine($"Divisão = {(firstNum / secondNum):F2}");
                    break;

                case 4:
                    Console.WriteLine($"Multiplicação = {(firstNum * secondNum):F2}");
                    break;

                default:
                    break;
            }

            Console.WriteLine("\nDeseja realizar outra operação?\n");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");

            int stop = Convert.ToInt16(Console.ReadLine());

            if (stop == 2)
                operacao = 5;

            Console.Clear();

        } while (operacao != 5);
    }
}