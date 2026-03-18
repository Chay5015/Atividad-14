using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activi_14_01
{


    class Estudiante
    {
        public string Nombre;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcularPromedio()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public string ObtenerEstado()
        {
            if (CalcularPromedio() >= 61)
                return "Aprobado";
            else
                return "Reprobado";
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre} | Promedio: {CalcularPromedio():F2} | Estado: {ObtenerEstado()}");
        }
    }
        class program
    {
        static void Main()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            Console.WriteLine("Cuantos Estudiantes desea Ingresar ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) // Registro de Datos 
            {
                Estudiante e = new Estudiante();
                Console.WriteLine($"\nEstudiante {i + 1}");
                Console.Write("Nombre: ");
                e.Nombre = Console.ReadLine();
                Console.Write("Nota 1: ");
                e.Nota1 = double.Parse(Console.ReadLine());

                Console.Write("Nota 2: ");
                e.Nota2 = double.Parse(Console.ReadLine());

                Console.Write("Nota 3: ");
                e.Nota3 = double.Parse(Console.ReadLine());

                estudiantes.Add(e);
            }
                
            double sumaPromedios = 0;
            Estudiante mejor = estudiantes[0];

            Console.WriteLine(" LISTADO DE ESTUDIANTES ");

            foreach( Estudiante e in estudiantes ) // Mejor promedio 
            {
                e.MostrarDatos();
               sumaPromedios += e.CalcularPromedio();

                if (e.CalcularPromedio ()>mejor.CalcularPromedio ())
                {
                    mejor = e;
                }
            }
            Console.WriteLine($"\nPromedio general del grupo: {sumaPromedios / estudiantes.Count:F2}");

            Console.WriteLine("\nMejor estudiante:");
            mejor.MostrarDatos();


        }

    }





    
}