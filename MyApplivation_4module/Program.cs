namespace MyApplivation_4module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int     A = 1;
            int     B = 2;
            double  X = 2.0;
            double  Y = 4.0;
            bool C;


            C = (A < B) | (X > Y);

            var inv = true;
            var result = !inv;
            Console.WriteLine("result= {0}",result);
        }
    }
}
