/*program.cs */
using Banco;

internal class Program
{
    private static void Main(string[] args)
    {

        Conta conta1;
        Console.WriteLine("Numero da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Nome do titular da conta:");
        string nome = Console.ReadLine();
        Console.WriteLine("Havera deposito inicial(S/N)?");       
        string resp = (Console.ReadLine());       
        
        if (resp == "s" || resp == "S")
        {
            Console.WriteLine("entre com o deposito inicial");
            double deposito = double.Parse(Console.ReadLine());
            conta1 = new Conta(numero, nome, deposito);
        }
        else
        {
          conta1 = new Conta (numero, nome);
        }

        Console.WriteLine();
        Console.WriteLine("dados da conta");
        Console.WriteLine(conta1);

        Console.WriteLine();

        Console.WriteLine("entre um valor para deposito: ");
        double quantia = double.Parse(Console.ReadLine());
        conta1.Deposito(quantia);
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(conta1);

        Console.WriteLine();

        Console.WriteLine("entre um valor para saque: ");
        quantia = double.Parse(Console.ReadLine());
        conta1.Saque(quantia);
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(conta1);
    }
}