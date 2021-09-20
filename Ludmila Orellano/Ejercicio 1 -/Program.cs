using System;

namespace Ejercicio_1__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[---] Ejercicio 1 [---]");
            Console.WriteLine(" ");


            bool verificaciónNumero1 = false;
            float numero1;
            do
            {
                Console.WriteLine("Ingrese el primer número: ");
                string usuarioNumero1 = Console.ReadLine();


                if (float.TryParse(usuarioNumero1, out numero1) == true)
                {
                    verificaciónNumero1 = false;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un valor númerico.");
                    verificaciónNumero1 = true;
                }
            } while (verificaciónNumero1);

            bool verificaciónNúmero2 = false;
            float numero2;
            do
            {
                Console.WriteLine("Ingrese el segundo número: ");
                string usuarioNumero2 = Console.ReadLine();

                if (float.TryParse(usuarioNumero2, out numero2) == true)
                {
                    verificaciónNúmero2 = false;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un valor númerico.");
                    verificaciónNúmero2 = true;
                }

            } while (verificaciónNúmero2);



            if (numero2 == 0)
            {
                Console.WriteLine("No se puede dividir por cero");
            }

            else
            {
                if (numero1 == numero2) //CONDICIONAL PARA MOSTRAR EL PUNTO A
                {
                    Console.WriteLine("El cuadrado del número ingresado es: " + numero1 * numero2);
                }
                if (numero1 != numero2) //CONDICIONAL PARA EL PUNTO B
                {
                    if (numero1 % numero2 == 0) // SI EL PRIMERO ES DIVISIBLE POR EL SEGUNDO
                    {
                        Console.WriteLine($"{numero1} es divisible por {numero2}");
                        Console.WriteLine($"La resta de ambos es: {numero1 - numero2}");
                    }
                    else // SI EL PRIMERO NO ES DIVISIBLE POR EL SEGUNDO
                    {

                        if (numero1 % numero2 > 3) //EL PRIMERO NO ES DIVISIBLE POR EL SEGUNDO,   EL RESTO ES MAYOR A 3, SOLO LO MUESTRO
                        {
                            Console.WriteLine($"El resto de dividir a {numero1} por {numero2} es mayor a 3");
                        }
                        else // EL PRIMERO NO ES DIVISIBLE POR EL SEGUNDO, Y SU RESTO ES MENOR A 3.
                        {
                            Console.WriteLine($"{numero1} no es divisible por {numero2}");
                            Console.WriteLine($"El resto de esa división es: {numero1 % numero2}");
                        }
                    }
                }
                
            }
            Console.ReadKey();


        }
    }
}
