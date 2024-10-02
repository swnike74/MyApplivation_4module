namespace MyApplivation_4module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int temp = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = j + 1; k < arr.GetLength(1); k++)
                        if (arr[i, j] > arr[i, k])
                        {
                            temp = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = temp;
                        }
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("{0}",arr[i, j]);
                }
            }
        }

                
    }
}
