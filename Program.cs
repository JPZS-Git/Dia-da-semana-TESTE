Console.Write("Digite um número de 1 a 7: ");
        string entrada = Console.ReadLine();
        
        if (int.TryParse(entrada, out int numero))
{
    switch (numero)
    {
        case 1:
            Console.WriteLine("Domingo");
            break;
        case 2:
            Console.WriteLine("Segunda-feira");
            break;
        case 3:
            Console.WriteLine("Terça-feira");
            break;
        case 4:
            Console.WriteLine("Quarta-feira");
            break;
        case 5:
            Console.WriteLine("Quinta-feira");
            break;
        case 6:
            Console.WriteLine("Sexta-feira");
            break;
        case 7:
            Console.WriteLine("Sábado");
            break;
        default:
            Console.WriteLine("Erro: o número deve estar entre 1 ---- 7, por favor.");
            break;
    }
}
else
{
    Console.WriteLine("Erro: entrada inválida. Por favor, digite um número inteiro.");
}
    
