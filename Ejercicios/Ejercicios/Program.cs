namespace ejercicio1
{
    public class Program
    {
        public static void Main()
        {
            int numero;
            int resultado;
            int doblado;
            Console.WriteLine("Coloca un número mamañema");
            numero = Convert.ToInt32(Console.ReadLine());
            doblado = numero * 2;
            resultado = doblado * 25;
            Console.WriteLine($"mamañema, el resultado de eso es:{resultado}");
        }
    }
}