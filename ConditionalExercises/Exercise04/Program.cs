namespace Exercise01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite inicio do jogo e final (mesma linha separe com a tecla espaço): ");
            string[] array = Console.ReadLine().Split(' ');
            int beginningGame = int.Parse(array[0]);
            int endGame = int.Parse(array[1]);

            int duration;
            if (beginningGame < endGame)
            {
                duration =  beginningGame - endGame;
            }
            else
            {
                duration = 24 - endGame + beginningGame;
            }

            Console.WriteLine($"O JOGO DUROU {Math.Abs(duration)} HORA(S)");

            Console.ReadKey();
        }
    }
}
