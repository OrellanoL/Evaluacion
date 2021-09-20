using System;

namespace Ejercicio_3__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingreso de datos para Bolsas de Alimentos");

            int contadorDeBolsas = 0;
            float kilosTotales = 0;
            float bolsaMásLiviana = 1000;
            string saborMásLiviana = "bugg";
            int cantidadDeCarne = 0;
            float sumaKilosDeCarne = 0;
            string sabor;

            while (contadorDeBolsas < 10)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"[---] Bolsa n° {contadorDeBolsas + 1} [---]");
                Console.WriteLine(" ");
                float kilos;
                bool validaciónKilos = false;
                do
                {
                    Console.WriteLine("Kilogramos: ");
                    string usuarioKilos = Console.ReadLine();

                    if (float.TryParse(usuarioKilos, out kilos) == true)
                    {
                        validaciónKilos = false;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese un valor númerico");
                        validaciónKilos = true;
                    }

                } while (validaciónKilos);

                bool validarKilosRango = true;
                do
                {

                    if (kilos < 0 || kilos > 500)
                    {
                        Console.WriteLine("Reingrese dato. Verifique que lo ingresado este dentro del rango (0 - 500)");
                        validarKilosRango = true;
                    }
                    else
                    {
                        kilosTotales = kilosTotales + kilos;

                        Console.WriteLine("Sabor: ");

                        bool validarSabor = true;
                        do
                        {
                            sabor = Console.ReadLine().ToLower().Trim();

                            if (sabor == "carne" || sabor == "pollo" || sabor == "vegetales")
                            {
                                if (sabor == "carne")
                                {
                                    cantidadDeCarne++;
                                    sumaKilosDeCarne = sumaKilosDeCarne + kilos;

                                }
                                validarSabor = false;
                            }
                            else
                            {
                                Console.WriteLine("Dato erróneo, ingrese nuevamente. | Opciones:  carne - pollo - vegetales |");
                                validarSabor = true;
                            }
                        } while (validarSabor);

                        if (kilos < bolsaMásLiviana)
                        {
                            bolsaMásLiviana = kilos;
                            saborMásLiviana = sabor;
                        }
                        validarKilosRango = false;
                    }

                } while (validarKilosRango);

                contadorDeBolsas++;
            }
            Console.WriteLine("Kilos Totales: " + kilosTotales + " y su promedio es: " + kilosTotales / 10);
            Console.WriteLine("La bolsa más liviana pesa: " + bolsaMásLiviana + "  y es de sabor: " + saborMásLiviana);
            Console.WriteLine("Cantidad de bolsas de carne: " + cantidadDeCarne + " - Promedio: " + sumaKilosDeCarne / cantidadDeCarne);
            Console.ReadKey();
        }
    }
}
