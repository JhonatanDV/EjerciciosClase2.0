namespace ejercicio5
{
    public class program
    {
        public static void Main()
        {
            double numero = 1, numero2 = 0;
            for (int i = 0; i < 10; i++)
            {
                numero2 = Math.Pow(numero, 2);
                numero++;
                Console.WriteLine(numero2);
            }
        }
    }
}
