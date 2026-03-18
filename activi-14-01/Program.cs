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
}