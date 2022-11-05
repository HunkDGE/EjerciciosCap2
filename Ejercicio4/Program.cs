namespace ejercicio2_15
{
    public class Program
    {

        public static void Main()
        {
            //cuarto ejercicio 2.16
            int contador, limite,sumatoria;
            contador = 1;
            limite = 10;
            sumatoria = 0;
            for (contador = 1; contador <= limite; contador++)
            {
                sumatoria=sumatoria+contador;
            }
            Console.WriteLine($"el resultado de la suma de 1 hasta 10 es: "[sumatoria]);
        }
    }

}