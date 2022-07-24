namespace Exercise02
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira a quantidade de numeros que serão lidos: ");
            int N = int.Parse(Console.ReadLine());

            int count_in = 0;
            int count_out = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Insira o {i}º numero: ");
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    count_in++;
                }
                else
                {
                    count_out++;
                }
            }
            Console.WriteLine($"\n{count_in} numero(s) dentro.");
            Console.WriteLine($"{count_out} numero(s) fora.");
            Console.ReadKey();
        }
    }
}