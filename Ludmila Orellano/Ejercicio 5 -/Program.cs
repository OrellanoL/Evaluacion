using System;

namespace Ejercicio_5__
{
    class Program
    {
        // MAYORES DE EDAD : >= 18
        // ADOLESCENTES : >=13 y <18
        //Menores de edad: <18
        // NOTA de 0 al 10 - APROBADO CON >= 7

        static void Main(string[] args)
        {
            Console.WriteLine("Base de datos - Alumnos");
            Console.WriteLine(" ");
            int varonesAprobados = 0;

            float notasMenoresDeEdad = 0;
            int cantidadDeMenoresDeEdad = 0;

            float notasAdolescentes = 0;
            int cantidadDeAdolescentes = 0;

            float notasMayores = 0;
            int cantidadDeMayores = 0;

            float notasGeneroM = 0;
            int cantidadGeneroM = 0;

            float notasGeneroF = 0;
            int cantidadGeneroF = 0;

            float notasGeneroX = 0;
            int cantidadGeneroX = 0;

            bool IngresoDeDatos = true;
            do
            {
                Console.WriteLine("Ingrese nombre del alumno: ");
                string nombre = Console.ReadLine();

                int edad = Program.Edad();
                string genero = Program.Genero();
                float nota = Program.NotaFinal();

                if (edad >= 18)
                {
                    cantidadDeMayores++;
                }
                if (edad >= 13 && edad <= 17)
                {
                    cantidadDeAdolescentes++;
                }
                if (edad >= 6 && edad <= 17)
                {
                    cantidadDeMenoresDeEdad++;
                }
                if (genero == "m")
                {
                    cantidadGeneroM++;
                }
                if (genero == "f")
                {
                    cantidadGeneroF++;
                }
                if (genero == "x")
                {
                    cantidadGeneroX++;
                }
                if (nota >= 7 && genero == "m")
                {
                    varonesAprobados++;
                }

                if (edad < 18)
                {
                    notasMenoresDeEdad = notasMenoresDeEdad + nota;
                }
                if (edad >= 13 && edad < 18)
                {
                    notasAdolescentes = notasAdolescentes + nota;
                }
                if (edad >= 18)
                {
                    notasMayores = notasMayores + nota;
                }
                if (genero == "m")
                {
                    notasGeneroM = notasGeneroM + nota;
                }
                if (genero == "f")
                {
                    notasGeneroF = notasGeneroF + nota;
                }
                if (genero == "x")
                {
                    notasGeneroX = notasGeneroX + nota;
                }

                if (Program.NuevoAlumno() == "si")
                {
                    IngresoDeDatos = true;
                }
                else
                {
                    IngresoDeDatos = false;
                }

            } while (IngresoDeDatos);

            Console.WriteLine("Cantidad de varones aprobados: " + varonesAprobados);
            Console.WriteLine("Promedio de mayores: " + notasMayores / cantidadDeMayores);
            Console.WriteLine("Promedio de Adolescentes: " + notasAdolescentes / cantidadDeAdolescentes);
            Console.WriteLine("Promedio de menores de edad: " + notasMenoresDeEdad / cantidadDeMenoresDeEdad);
            Console.WriteLine("Promedio de Género Masculino: " + notasGeneroM / cantidadGeneroM);
            Console.WriteLine("Promedio de Género Femenino: " + notasGeneroF / cantidadGeneroF);
            Console.WriteLine("Promedio de Género Binario: " + notasGeneroX / cantidadGeneroX);
            Console.ReadKey();
        }

        // MÉTODO PARA VERIFICAR GENERO ----------------------------------------------------------------------------------------
        static string Genero()
        {
            bool generoValidar = true;
            string generoDelAlumno;
            do
            {
                Console.WriteLine("Ingrese género del alumno: f (femenino) - m (masculino) - x (no binario)");
                generoDelAlumno = Console.ReadLine().ToLower().Trim();
                if (generoDelAlumno == "f" || generoDelAlumno == "m" || generoDelAlumno == "x")
                {
                    generoValidar = false;
                }
                else
                {
                    Console.WriteLine("Por favor, verifique que el dato sea correcto.");
                    generoValidar = true;
                }
            } while (generoValidar);
            return generoDelAlumno;
        }
        // MÉTODO PARA VERIFICAR NOTA--------------------------------------------------------------------------------------
        static float NotaFinal()
        {
            bool notaValidar = true;
            float notaFinal;
            do
            {
                Console.WriteLine("Ingrese nota final: ");
                string usuarioNota = Console.ReadLine();
                if (float.TryParse(usuarioNota, out notaFinal) == true)
                {
                    if (notaFinal >= 0 && notaFinal <= 10)
                    {
                        notaValidar = false;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una nota entre 0 y 10");
                        notaValidar = true;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, verifique que el dato sea correcto");
                    notaValidar = true;
                }
            } while (notaValidar);

            return notaFinal;
        }

        // MÉTODO PARA VERIFICAR EDAD--------------------------------------------------------------------------------------
        static int Edad()
        {
            bool edadValidar = true;
            int edad;
            do
            {
                Console.WriteLine("Ingrese edad: ");
                string usuarioEdad = Console.ReadLine();
                if (int.TryParse(usuarioEdad, out edad) == true)
                {
                    if (edad >= 1 && edad <= 110)
                    {
                        edadValidar = false;
                    }
                    else
                    {
                        Console.WriteLine("Verifique que la edad sea correcta");
                        edadValidar = true;
                    }
                }
                else
                {
                    Console.WriteLine("Verifique que el dato sea correcto");
                    edadValidar = true;
                }
            } while (edadValidar);

            return edad;
        }

        // MÉTODO PARA AÑADIR NUEVO ALUMNO -------------------------------------------------------------------------------------
        static string NuevoAlumno()
        {
            bool verificarRespuesta = true;
            string usuarioRespuesta;
            do
            {
                Console.WriteLine("¿Desea ingresar un nuevo alumno? si / no");
                usuarioRespuesta = Console.ReadLine();
                if (usuarioRespuesta == "si" || usuarioRespuesta == "no")
                {
                    verificarRespuesta = false;
                }
                else
                {
                    Console.WriteLine("Por favor, verifique que la respuesta sea una opción correcta");
                    verificarRespuesta = true;
                }
            } while (verificarRespuesta);

            return usuarioRespuesta;
        }
    }
}
