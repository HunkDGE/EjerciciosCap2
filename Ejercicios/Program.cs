namespace ejercicio2_3
{
    public class Program
    {
        
           public static void Main()
            {
              //primer ejercicio 
              int numero, resultado, doble;
              Console.WriteLine("Ejercicio2.3");
              Console.WriteLine("digite un numero");
              numero = int.Parse(Console.ReadLine());
              doble = numero * 2;
              resultado = (numero * 2) * 25;
              Console.WriteLine("su numero doblado es: " + doble);
              Console.WriteLine("su numero final " + resultado);

            }
    }

}
