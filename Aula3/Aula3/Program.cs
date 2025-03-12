// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

List<Produto> listaProduto = new List<Produto>();

while(true)
{ 

Console.Clear();
Console.WriteLine("SELECIONE UMA OPÇÃO");
Console.WriteLine("1 - PARA EXECUTAR LOOPS");
Console.WriteLine("2 - PARA ADICIONAR PRODUTOS");
Console.WriteLine("3 - PARA LER PRODUTOS");
Console.WriteLine("4 - PARA SAIR");
Console.WriteLine("DIGITE OPÇÃO DESEJADA");

string escolha = Console.ReadLine();

switch (escolha)
{
    case "1":
        ExecutarLoops();
        break;
    case "2":
        CadastrarProdutos();
        break;
    case "3":
        lerProdutos();
        break;
    case "4":
        Console.WriteLine("SAINDO");
        return;
    default:
        Console.WriteLine("Você digitou uma opção inválida");
        break;
}

//executarloops();
//cadastrarprodutos();
Console.ReadKey();
}

static void ExecutarLoops()
{
    Console.WriteLine("Executando exemplos de loops...");

    Console.WriteLine("\nExemplo de FOR:");
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine($"Número: {i}");
    }

    Console.WriteLine("\nExemplo de WHILE:");
    int contadorWhile = 1;
    while (contadorWhile <= 5)
    {
        Console.WriteLine($"Número: {contadorWhile}");
        contadorWhile++;
    }

    string[] cores = { "Vermelho", "Azul", "Verde", "Amarelo" };
    foreach (string cor in cores)
    {
        Console.WriteLine($"Cor: {cor}");
    }
    
}

void lerProdutos()
{
    if (listaProduto.Count == 0)
    {
        Console.WriteLine("Ainda não existem produtos;");
    }
    else
    {

        foreach (Produto item in listaProduto)
        {
            Console.WriteLine($"\n Nome Produto: {item.nome}");
            Console.WriteLine($"\n Nome Produto: {item.preco}");
        }
    }
}

void CadastrarProdutos()
{
    Produto item1 = new Produto();
    item1.nome = "Big Mac";
    item1.preco = 13.50;

    listaProduto.Add(item1);

    Produto item2 = new Produto();
    item2.nome = "Batata";
    item2.preco = 8;

    listaProduto.Add(item2);

}
class Produto
{
    public string nome { get; set; }

    public double preco { get; set; }

}