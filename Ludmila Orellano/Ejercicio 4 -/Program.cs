using System;

namespace Ejercicio_4__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contador de autos");
            Console.WriteLine(" ");
            Console.WriteLine(" Colores en stock: Rojo | Verde | Amarillo");
            Console.WriteLine(" ");
            Console.WriteLine("Rango de precios: 0 - 10000");
            Console.WriteLine(" ");

            int rojos = 0;
            int rojosMayor5000 = 0;
            int autosMenor5000 = 0;
            int cantidadDeAutos = 0;
            float sumaTotalPrecioAutos = 0;
            float masCaro = 0;
            string colorCaro = "Bugg";
            string usuarioPreguntar;

            bool nuevoIngresoDeAuto = true;
            do
            {
                string opcionColor = Program.ColorAuto();
                float rangoPrecio = Program.PrecioAuto();
                if (rangoPrecio > masCaro)
                {
                    masCaro = rangoPrecio;
                    colorCaro = opcionColor;
                }
                if (opcionColor == "rojo")
                {
                    rojos++;
                    if (rangoPrecio > 5000)
                    {
                        rojosMayor5000++;
                    }
                    else
                    {
                        autosMenor5000++;
                    }
                }
                if (opcionColor == "verde" || opcionColor == "amarillo")
                {
                    if (rangoPrecio < 5000)
                    {
                        autosMenor5000++;
                    }
                }

                sumaTotalPrecioAutos = sumaTotalPrecioAutos + rangoPrecio;
                cantidadDeAutos++;

                usuarioPreguntar = Program.NuevoDato();

                if (usuarioPreguntar == "si")
                {
                    nuevoIngresoDeAuto = true;
                }
                else if (usuarioPreguntar == "no")
                {
                    nuevoIngresoDeAuto = false;
                }

            } while (nuevoIngresoDeAuto);

            Console.WriteLine("Total de rojos: " + rojos);
            Console.WriteLine("Total de rojos mayores a 5000: " + rojosMayor5000);
            Console.WriteLine("Cantidad de autos menores a 5000: " + autosMenor5000);
            Console.WriteLine("Cantidad total de autos: " + cantidadDeAutos);
            Console.WriteLine("Promedio de todos los autos: " + (sumaTotalPrecioAutos / cantidadDeAutos));
            Console.WriteLine("El más caro sale: " + masCaro + " y es de color: " + colorCaro);
            Console.ReadKey();
        }

        static float PrecioAuto()
        {
            bool validarPrecio = false;
            float precioAuto;
            do
            {
                Console.WriteLine("Por favor, ingrese precio entre 0 y 10000");
                string usuarioPrecio = Console.ReadLine();
                if (float.TryParse(usuarioPrecio, out precioAuto) == true)
                {
                    if (precioAuto < 0 || precioAuto > 10000)
                    {
                        validarPrecio = true;
                    }
                    else
                    {
                        validarPrecio = false;
                    }

                }
                else
                {
                    Console.WriteLine("Dato erróneo, ingrese un dato numérico");
                    validarPrecio = true;

                }
            } while (validarPrecio);

            return precioAuto;
        }

        static string ColorAuto()
        {
            string opcionColor;
            bool ValidarColor = false;
            do
            {
                Console.WriteLine("Ingrese color: Rojo - Verde - Amarillo ");
                opcionColor = Console.ReadLine().ToLower().Trim();

                if (opcionColor == "rojo" || opcionColor == "verde" || opcionColor == "amarillo")
                {
                    ValidarColor = false;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un color válido.");
                    ValidarColor = true;
                }

            } while (ValidarColor);

            return opcionColor;
        }

        static string NuevoDato()
        {
            string usuarioPreguntar = "bugg";
            bool ValidarRespuesta = true;
            do
            {
                Console.WriteLine("¿Desea ingresar nuevo vehiculo? si / no");
                usuarioPreguntar = Console.ReadLine().ToLower().Trim();
                if ((usuarioPreguntar == "si") || (usuarioPreguntar == "no"))
                {
                    ValidarRespuesta = true;
                    return usuarioPreguntar;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese una opción válida");
                    ValidarRespuesta = false;
                }

            } while (ValidarRespuesta);
            return usuarioPreguntar;

        }
    }
}
