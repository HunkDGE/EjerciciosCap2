namespace ejercicio2_4
{
    public class Program
    {

        public static void Main()
        {
            //segundo ejercicio 2.4
            double num1, num2, num3, num4, suma, media, producto;
            Console.WriteLine("Ejercicio2.4");
            Console.WriteLine("Digite los 4 numeros para sacar el producto y media aritmetica");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            num3 = double.Parse(Console.ReadLine());
            num4 = double.Parse(Console.ReadLine());
            suma = num1 + num2 + num3 + num4;
            producto = num1 * num2 * num3 * num4;
            Console.WriteLine("el producto de las cuatro variables es: " + producto);
            Console.WriteLine("la suma de las cuatro variables es: " + suma);
            media = suma / 4;
            Console.WriteLine("la media aritmetica es: " + media);

        }
    }

}