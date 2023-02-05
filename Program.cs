using System;

namespace ValorXReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] quartos = new string[10];
            for (int i = 0; i < quartos.Length; i++)
            {
                Console.WriteLine("*Bem vindo ao atendimento*");
                Console.WriteLine("-----Informe seu nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("-----Informe seu email: ");
                string email = Console.ReadLine();
                Console.WriteLine($" Tudo certo {nome}!!");
                for (int j = 0; j < quartos.Length; j++)
                    if (quartos[j] == null)
                    {
                        Console.WriteLine($"Quarto: {j + 1} está livre.");
                    }
                Console.WriteLine("------");
                Console.WriteLine("Diante da lista, você deseja ficar em qual quarto?(Informe o número, por favor)");
                int quarto = int.Parse(Console.ReadLine());
                if (quartos[quarto - 1] != null)
                {
                    do
                    {
                        Console.WriteLine("Quarto já ocupado, selecione outro");
                        quarto = int.Parse(Console.ReadLine());
                    } while (quartos[quarto - 1] != null);
                    quartos[quarto - 1] = $"O(a) {nome}, de email {email}";
                    Console.WriteLine($"----\nPerfeito {nome}, você está no quarto {quarto}\n");
                }
                else
                {
                    quartos[quarto - 1] = $"O(a) {nome}, de email {email}";
                    Console.WriteLine($"\nPerfeito {nome}, você está no quarto {quarto}\n--");
                }
            }

            for (int i = 0; i < quartos.Length; i++)
            {
                Console.WriteLine($"\nQuarto {i+1} está ocupado por {quartos[i]}\n------");
            }
        }
    }
}
