namespace ejercicio2
{
    public class clase
    {
        public static void Main()
        {
            int num1;
            int num2;
            int num3;
            int num4;
            int sum;
            double media;
            int prod;
            Console.WriteLine("Ingrese el primer número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto número");
            num4 = Convert.ToInt32(Console.ReadLine());
            prod = num1 * num2 + num3 * num4;
            sum = num1 + num2 + num3 + num4;
            media = sum / 4;
            Console.WriteLine($"El resultado de la suma es {sum}, del producto es {prod} y de la medua es {media}");
        }
    }
}