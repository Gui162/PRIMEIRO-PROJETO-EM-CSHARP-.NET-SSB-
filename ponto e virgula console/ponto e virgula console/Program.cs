List<string> numeros = new List<string>();

while (true)
{
    Console.WriteLine("Por favor, digite um número (ou 'fim' para encerrar): ");
    string num = Console.ReadLine();
    if (num.ToLower() == "fim")
        break;
    numeros.Add(num);
}

List<string> listacomvirgula = new List<string>();

foreach (string num in numeros)
{
    listacomvirgula.Add(num+",");
}

string numerosString = string.Concat(listacomvirgula);
Console.WriteLine(numerosString);
