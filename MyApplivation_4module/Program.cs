namespace MyApplivation_4module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя");

            var name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам: ");

            foreach (var ch in name)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);

            for (int i = name.Length-1; i >= 0; i--)
            {
                Console.Write(name[i] + "");
            }

            Console.ReadKey();
        }
    }
}
