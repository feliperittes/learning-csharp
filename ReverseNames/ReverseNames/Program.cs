namespace ReverseNames
{
    class Program
    {
        public static void Main(string[] args)
        {
            SelectMode();
        }
        static void SelectMode()
        {
            Console.Clear();
            Console.WriteLine("-------------Insira os nomes para serem invertidos-------------\n");

            Console.Write("Selecione a opção 1 ou 2 (mesma coisa só que fiz diferente)\n>");
            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FirstMode();
                    break;
                case 2:
                    SecondMode();
                    break;
                default:
                    Console.Write("Opção invalida.\nAguarde o programa reiniciar....");
                    Thread.Sleep(3000);
                    SelectMode();
                    break;
            }
            Console.Write("\n-------------------------Fim Do Programa-------------------------");
            Console.ReadKey();
        }

        static void FirstMode()
        {
            string firstName, secondName, thirdName, quarterName, auxiliary;

            Console.Write("\nInsira o nome #1: ");
            firstName = Console.ReadLine();

            Console.Write("Insira o nome #2: ");
            secondName = Console.ReadLine();

            Console.Write("Insira o nome #3: ");
            thirdName = Console.ReadLine();

            Console.Write("Insira o nome #4: ");
            quarterName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("\n-------------Nomes Inseridos em sequência invertida-------------\n");

            #region Macanism Reverse Names
            auxiliary = firstName;
            firstName = quarterName;
            quarterName = auxiliary;
            auxiliary = secondName;
            secondName = thirdName;
            thirdName = auxiliary;
            auxiliary = thirdName;
            thirdName = auxiliary;
            #endregion

            Console.WriteLine(firstName);
            Console.WriteLine(secondName);
            Console.WriteLine(thirdName);
            Console.WriteLine(quarterName);
        }

        static void SecondMode()
        {
            string firstName, secondName, thirdName, quarterName;

            Console.Write("\nInsira o nome #1: ");
            firstName = Console.ReadLine();

            Console.Write("Insira o nome #2: ");
            secondName = Console.ReadLine();

            Console.Write("Insira o nome #3: ");
            thirdName = Console.ReadLine();

            Console.Write("Insira o nome #4: ");
            quarterName = Console.ReadLine();

            Console.WriteLine("\n-------------Nomes Inseridos em Sequência Invertida-------------\n");

            #region Macanism Reverse Names
            string[] arrayNames = new string[] { firstName, secondName, thirdName, quarterName };
            Array.Reverse(arrayNames);

            int i = 4;
            foreach (string name in arrayNames)
            {
                Console.WriteLine($"Nome #{i}: {name}");
                i--;
            }
            #endregion
        }
    }
}