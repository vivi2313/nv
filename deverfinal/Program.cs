class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        int contador = 1;
        int resultado = 0;

        
        while (contador <= 10)
        {
            resultado = resultado + numero; 
            contador = contador + 1;
        }

        Console.WriteLine($"O número multiplicado por 10 é: {resultado}");
    }
}