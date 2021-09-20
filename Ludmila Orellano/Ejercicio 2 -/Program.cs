using System;

namespace Ejercicio_2__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empresa de Viajes - ¡Hola mundo!");
            Console.WriteLine(" ");
            Console.WriteLine("Por hoy obtenes el beneficio de pagar el día de estadia a tan solo $100");

            bool frag = false;
            int Dias;
            do
            {
                Console.WriteLine("¿Cuántos días desea viajar? : ");
                string usuarioDias = Console.ReadLine();

                if (int.TryParse(usuarioDias, out Dias) == true)
                {
                    frag = false;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese sólo un valor númerico.");
                    frag = true;
                }

            } while (frag);


            int precioSinDescuento = Dias * 100;
            float americaDescuento15 = precioSinDescuento * 0.85f; //Descuento inicial del 15% por viajar a América.
            float africaUOceaniaDescuento30 = precioSinDescuento * 0.7f; // Descuento inicial del 30% por viajar a Africa u Oceania.
            float europaDescuento20 = precioSinDescuento * 0.8f; // Descuento inicial del 20% por viajar a Europa.
            float otroContinenteRecargo20 = precioSinDescuento * 1.2f; // Recargo por viajar a la Antártida o Asia.


            Program.MenúContinentes();
            Console.WriteLine(" ");

            string usuarioContinente = Program.Continentes();

            Console.WriteLine(" ");
            Program.MenúFormasDePago();
            Console.WriteLine(" ");

            string usuarioFDP = Program.FormaDePago();

            if (usuarioContinente == "américa")
            {

                if (usuarioFDP == "débito")
                {
                    Console.WriteLine("Por abonar con débito obtenes un 10% más de descuento");
                    Console.WriteLine($"Precio Final por {Dias}: AR${americaDescuento15 * 0.9f}");
                }
                if (usuarioFDP == "cheque")
                {
                    Console.WriteLine("Esta forma de pago tiene un impuesto del 15%");
                    Console.WriteLine($"Precio Final por {Dias}: AR${americaDescuento15 * 1.15}");
                }
                if (usuarioFDP != "débito" && usuarioFDP != "cheque")
                {
                    Console.WriteLine($"Precio Final por {Dias}: AR${americaDescuento15}");
                }
            }

            if (usuarioContinente == "áfrica" || usuarioContinente == "oceanía")
            {

                if (usuarioFDP == "mercado pago" || usuarioFDP == "efectivo")
                {
                    Console.WriteLine("Por elegir este medio de pago obtenes un 15% más de descuento");
                    Console.WriteLine($"Precio Final por {Dias}: {africaUOceaniaDescuento30 * 0.85f}");
                }
                if (usuarioFDP == "cheque")
                {
                    Console.WriteLine("Esta forma de pago tiene un impuesto del 15%");
                    Console.WriteLine($"Precio Final por {Dias}: {africaUOceaniaDescuento30 * 1.15f}");
                }
                if (usuarioFDP != "mercado pago" && usuarioFDP != "efectivo" && usuarioFDP != "cheque")
                {
                    Console.WriteLine($"Precio Final por {Dias}: AR${africaUOceaniaDescuento30}");

                }

            }

            if (usuarioContinente == "europa")
            {
                if (usuarioFDP == "débito")
                {
                    Console.WriteLine("Por abonar con Débito obtenes un 15% más de descuento");
                    Console.WriteLine($"Precio Final por {Dias}: AR${europaDescuento20 * 0.85f}");
                }
                if (usuarioFDP == "mercado pago")
                {
                    Console.WriteLine("Por abonar con Mercado Pago obtenes un 10% más de descuento");
                    Console.WriteLine($"Precio Final por {Dias}: AR${europaDescuento20 * 0.9f}");
                }
                if (usuarioFDP == "cheque")
                {
                    Console.WriteLine("Esta forma de pago tiene un impuesto del 15%");
                    Console.WriteLine($"Precio Final por {Dias}: AR${europaDescuento20 * 1.15f}");
                }
                if (usuarioFDP != "débito" && usuarioFDP != "mercado pago" && usuarioFDP != "cheque")
                {
                    Console.WriteLine("Por elegir este metodo de pago obtenes un 5% más de descuento");
                    Console.WriteLine($"Precio Final por {Dias}: AR${europaDescuento20 * 0.95f}");
                }
            }

            if (usuarioContinente == "asia" || usuarioContinente == "antártida")
            {


                if (usuarioFDP == "cheque")
                {
                    Console.WriteLine("Esta forma de pago tiene un impuesto del 15%");
                    Console.WriteLine($"Precio Final por {Dias}: AR${otroContinenteRecargo20 * 1.15f} ");
                }
                else if (usuarioFDP != "cheque")
                {
                    Console.WriteLine($"Precio Final por {Dias}: AR${otroContinenteRecargo20}");
                }

            }
            Console.ReadKey();
        }

        static void MenúContinentes()
        {
            Console.WriteLine("(*) América - con un 15% de descuento ");
            Console.WriteLine("(*) Europa - con un 20% de descuento ");
            Console.WriteLine("(*) África - con un 30% de descuento ");
            Console.WriteLine("(*) Oceanía - con un 30% de descuento ");
            Console.WriteLine("(*) Asia - con un recargo del 20% ");
            Console.WriteLine("(*) Antártida - con un recargo del 20% ");
        }
        static void MenúFormasDePago()
        {

            Console.WriteLine("Formas de pago disponibles: ");
            Console.WriteLine("(*) Efectivo ");
            Console.WriteLine("(*) Débito");
            Console.WriteLine("(*) Crédito");
            Console.WriteLine("(*) Mercado Pago");
            Console.WriteLine("(*) Cheque ");
            Console.WriteLine("(*) Leliq");
        }
        static string Continentes()
        {
            bool frag = false;
            string usuarioContinente = "Programa Buggeado"; // ayuda para mi
            do
            {
                Console.WriteLine("Ingrese continente a viajar: ");
                usuarioContinente = Console.ReadLine().ToLower().Trim();

                if (usuarioContinente == "américa" || usuarioContinente == "asia" || usuarioContinente == "europa" || usuarioContinente == "áfrica" || usuarioContinente == "oceanía" || usuarioContinente == "antártida")
                {
                    frag = false;
                }
                else
                {
                    Console.WriteLine("Error de dato, por favor verifique que el dato ingresado sea correcto.");
                    frag = true;
                }
            } while (frag);
            return usuarioContinente;
        }

        static string FormaDePago()
        {
            bool frag = false;
            string usuarioFDP = "Programa Buggeado";
            do
            {
                Console.WriteLine("Ingrese forma de pago: ");
                usuarioFDP = Console.ReadLine().ToLower().Trim();
                if (usuarioFDP == "débito" || usuarioFDP == "crédito" || usuarioFDP == "efectivo" || usuarioFDP == "mercado pago" || usuarioFDP == "cheque" || usuarioFDP == "leliq")
                {
                    frag = false;
                }
                else
                {
                    Console.WriteLine("Por favor verifique que la forma de pago ingresada sea válida. Reingrese dato.");
                    frag = true;
                }
            } while (frag);

            return usuarioFDP;
        }
    }
}
