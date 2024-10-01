namespace MyApplivation_4module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int numpos = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > 0) numpos++;
                }
            }

            int numpos1 = 0;
            foreach(var item in arr)
            {
                if (item > 0) numpos1++;
            }

            Console.WriteLine("first={0}, second={1}",numpos,numpos1);

           


        }
    }
}
