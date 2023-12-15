using Exemplodefundamentos.Models;


List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("RJ");

//Percorrendo o array com o FOR

for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}

//Percorrendo o array com o FOREACH

int contadorforeach = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição N° {contadorforeach} - {item}");
    contadorforeach++;
}















/*int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

//Percorrendo o array com o FOR
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}

//Percorrendo o array com o FOREACH

int contadorforeach = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição N° {contadorforeach} - {valor}");
    contadorforeach++;
}*/













/*string opcao;

while(true)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;
        case "2":
            Console.WriteLine("Busca de Cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            break;
            
        default:
            Console.WriteLine("Opção inválida");
    }
}

Console.WriteLine("O programa se encerrou");*/










/*Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2);*/


/*Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Buta";
pessoa1.Idade = 26;
pessoa1.Apresentar(); */
