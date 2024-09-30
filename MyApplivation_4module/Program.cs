namespace MyApplivation_4module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(array.Length);


            for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
            {
                for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
                    Console.Write(array[i, k] + " ");

                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
