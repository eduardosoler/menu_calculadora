string? buffer;

while (true)
{
    Console.Clear();
    Console.WriteLine("Digite uma das opções");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("Digite qualquer outro valor para sair");

    buffer = Console.ReadLine();

    switch (buffer)
    {
        default:
            return;
        case "1":
            Somar();
            break;
        case "2":
            Subtrair();
            break;
        case "3":
            Multiplicar();
            break;
        case "4":
            Dividir();
            break;
    }
}

void Somar()
{
    Console.WriteLine("Digite o primeiro valor");
    buffer = Console.ReadLine();
    int valor1 = Convert.ToInt32(buffer);

    Console.WriteLine("Digite o segundo valor");
    buffer = Console.ReadLine();
    int valor2 = Convert.ToInt32(buffer);

    int resultado = valor1 + valor2;
    Console.WriteLine($"O resultado da soma é {resultado}");
    Console.ReadKey();
}

void Subtrair()
{
    Console.WriteLine("Digite o primeiro valor");
    buffer = Console.ReadLine();
    int valor1 = Convert.ToInt32(buffer);

    Console.WriteLine("Digite o segundo valor");
    buffer = Console.ReadLine();
    int valor2 = Convert.ToInt32(buffer);

    int resultado = valor1 - valor2;
    Console.WriteLine($"O resultado da subtração é {resultado}");
    Console.ReadKey();
}

void Multiplicar()
{
    Console.WriteLine("Digite o primeiro valor");
    buffer = Console.ReadLine();
    int valor1 = Convert.ToInt32(buffer);

    Console.WriteLine("Digite o segundo valor");
    buffer = Console.ReadLine();
    int valor2 = Convert.ToInt32(buffer);

    int resultado = valor1 * valor2;
    Console.WriteLine($"O resultado da multiplicação é {resultado}");
    Console.ReadKey();
}

void Dividir()
{
    Console.WriteLine("Digite o primeiro valor");
    buffer = Console.ReadLine();
    int valor1 = Convert.ToInt32(buffer);

    Console.WriteLine("Digite o segundo valor");
    buffer = Console.ReadLine();
    float valor2 = Convert.ToInt32(buffer);

    float resultado = valor1 / valor2;
    Console.WriteLine($"O resultado da divisão é {resultado}");
    Console.ReadKey();
}
