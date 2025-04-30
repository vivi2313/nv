class Program
{
    static void Main()
    {
        Console.Write("Digite um número limite: ");
        int limite = int.Parse(Console.ReadLine());

        int contador = 0;

        while (contador <= limite)
        {
            Console.WriteLine(contador);
            contador = contador + 3;
        }
    }
}