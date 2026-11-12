
using DadosComCSV.Repositories;
using DadosComCSV.Services;

System.Console.WriteLine("Hello, World");

var repository = new JogoRepository();
var service = new JogoService(repository);

bool executando = true;

while (executando)
{
    // Console.Clear();
    Console.WriteLine("==============GESTÃO DE JOGOS===========");
    Console.WriteLine("1- CADASTRAR JOGO");
    Console.WriteLine("2 - LISTAR JOGOS");
    Console.WriteLine("0- SAIR");
    Console.WriteLine("\nESCOLHA UMA OPÇÃO: ");
    string? opcao = Console.ReadLine();

    try
    {
        switch (opcao)
        {
            case "1":
            //Cadastrar();
            break;
            case "2":
             var listaJogos = service.Listar();
             foreach (var item in listaJogos)
             {
                Console.WriteLine($"Nome:{item.Nome} - Preco: {item.Preco:C} ");
             }
            break;
            case "0":
            executando = false;
            break;
            default:
            Console.WriteLine("Opção Inválida");
            break;
        }
    }
    catch (ArgumentException ex )
    {

        Console.WriteLine($"\nErro: {ex.Message}");        
        throw;
    }
}