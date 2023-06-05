using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2_programenu
{
    internal class Program
    {
        public static string[] estudiantes = { "Adrian", "Josue", "Alondra", "Damian" };
        public static float[] notas = { 90, 70, 80, 50 };
        static void Main(string[] args)

        {
            mostrarmenu();
        }

        private static void mostrarmenu()
        {
            int opcion = 0;
            Console.WriteLine("Deseas ingresar al Menú? si/no ");
            string respuesta = Console.ReadLine();

            while (respuesta == "si")
            {
                Console.Clear();
                Console.WriteLine("*******Opciones del menu*******");
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("1. Ingresar notas");
                Console.WriteLine("2. Consultar notas");
                Console.WriteLine("3. Modificar notas");
                Console.WriteLine("4. Borrar estudiante");
                Console.WriteLine("5. Reporte Detallado de notas");
                Console.WriteLine("6. Limpiar datos");
                Console.WriteLine("7. salir ");
                Console.WriteLine("*******************************");
                opcion = int.Parse(Console.ReadLine());


                if (opcion == 1)
                {
                    Ingresarnotas();
                }
                if (opcion == 2)
                {
                    consultarnotas();
                }
                if (opcion == 3)
                {
                    modificarestudiante();
                }
                if (opcion == 4)
                {
                    borrarestudiante();
                }
                if (opcion == 5)
                {
                    Reporte();
                }
                if (opcion == 6)
                {
                    Limpiardatos();
                }
                else Console.WriteLine("Presione enter para volver al Menú");
                Console.ReadLine();
            }
        }
        public static void Ingresarnotas()
        {

            int largo = estudiantes.Length;
            Console.Write("Digite el nombre del estudiante: ");
            string nuevoestudiante = Console.ReadLine();
            estudiantes = estudiantes.Concat(new string[] { nuevoestudiante }).ToArray();
            Console.Write("Digite la nota: ");
            float nuevanota = float.Parse(Console.ReadLine());
            notas = notas.Concat(new float[] { nuevanota }).ToArray();


        }
        public static void consultarnotas()
        {
            string nombreestudiante = "";
            Boolean Existe = false;
            Console.WriteLine("Digite el nombre del estudiante");
            nombreestudiante = Console.ReadLine();
            int largo = estudiantes.Length;
            if (largo == 0)
            {
                Console.WriteLine("No hay estudiantes");
            }
            else
            {
                for (int i = 0; i < largo; i++)
                {
                    if (estudiantes[i].Equals(nombreestudiante))
                    {
                        Console.WriteLine("La nota del estuidante es: " + notas[i]);
                        Existe = true;
                        break;
                    }


                }
            }

        }
        public static void modificarestudiante()
        {
            String nombreestudiante = "";
            Boolean Existe = false;
            Console.Write("Digite un nombre del estudiante: ");
            nombreestudiante = Console.ReadLine();
            int largo = estudiantes.Length;

            for (int i = 0; i < largo; i++)
            {
                if (estudiantes[i].Equals(nombreestudiante))
                {
                    Console.Clear();
                    Console.Write("Actualice el nombre del estudiante:");
                    estudiantes[i] = Console.ReadLine();
                    Console.Write("Actualice la nota :");
                    notas[i] = float.Parse(Console.ReadLine());
                    Existe = true;
                    break;
                }
            }
            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("El Estudiante no existe en la lista");
            }
        }
        public static void Reporte()
        {
            Console.Clear();
            Console.WriteLine("********** Reporte de notas segun estudiante *************");
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"Nombre del estudiante: {estudiantes[i]} su nota es: {notas[i]}");
            }
            Console.WriteLine("********** Fin del reporte*************");
            Console.WriteLine("Presione enter para volver al menú");
            Console.ReadLine();
        }
        public static void borrarestudiante()
        {

            String nombreestudiante = "";
            Console.Write("Digite un nombre del estudiante: ");
            nombreestudiante = Console.ReadLine();
            int posicion = Array.IndexOf(estudiantes, nombreestudiante);
            estudiantes = estudiantes.Where(n => n != estudiantes[posicion]).ToArray();
            notas = notas.Where(n => n != notas[posicion]).ToArray();
            
        }
        public static void Limpiardatos()
        {
            int largo = estudiantes.Length;
            //for (int i = largo; i > 0;)
            while (largo > 0)
            {
                estudiantes = estudiantes.Where(n => n != estudiantes[largo - 1]).ToArray();
                notas = notas.Where(n => n != notas[largo - 1]).ToArray();    
                largo = largo - 1;

            }
            Console.WriteLine("Presione enter para volver al menú");
            Console.ReadLine();


        }
    }

}
