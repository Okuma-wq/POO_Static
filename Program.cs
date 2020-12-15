using System;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha = "";
            do{
                Console.WriteLine("Qual conversão deseja realizar?");
                Console.WriteLine("[1] - Real para Dolar");
                Console.WriteLine("[2] - Dolar para Real");
                Console.WriteLine("[3] - Real para Euro");
                Console.WriteLine("[4] - Euro para Real");
                Console.WriteLine("[0] - Sair");
                escolha = Console.ReadLine();
                if(escolha == "1" || escolha == "2" || escolha == "3" || escolha == "4"){
                    Console.Write("Digite um valor: ");
                    Conversor.valorUsuario = float.Parse(Console.ReadLine());
                }
                
                switch (escolha)
                {
                    case "1":
                        Console.WriteLine($"O valor convertido é de R${Conversor.ConverterRealParaDolar()}");
                        break;
                    case "2":
                        Console.WriteLine($"O valor convertido é de ${Conversor.ConverterDolarParaReal()}");
                        break;
                    case "3":
                        Console.WriteLine($"O valor convertido é de €{Conversor.ConverterRealParaEuro()}");
                        break;
                    case "4":
                        Console.WriteLine($"O valor convertido é de R${Conversor.ConverterEuroParaReal()}");
                        break;
                    case "0":
                        Console.WriteLine("Encerrando programa");
                        break;
                    default:
                        Console.WriteLine("Escolha inválida");
                        break;
                }
                


            }while(escolha != "0");
        }
    }
}
