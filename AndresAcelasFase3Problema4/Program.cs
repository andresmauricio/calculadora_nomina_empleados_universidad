using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndresAcelasFase3Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInformationStudent();
            CrearTrabajador();
            Console.ReadLine();

        }

        public static void CrearTrabajador()
        {
            Trabajador trabajador = new Trabajador();
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Ingrese el Nombre del trabajor");
            trabajador.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la identificación del trabajor");
            trabajador.NumerodeIdentificacion = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de horas trabajadas");
            trabajador.HorasTrabajadas = Int32.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            trabajador.ImprimirDatosDelTrabajador();
        }

        public static void PrintInformationStudent()
        {
            Console.WriteLine("::: FASE 3 - MÉTODOS Y CLASES :::");
            Console.WriteLine();
            Console.WriteLine("NOMBRE DEL CURSO -> INTRODUCCION A LA PROGRAMACIÓN");
            Console.WriteLine("NÚMERO DE FASE -> FASE 3 CLASES Y MÉTODOS");
            Console.WriteLine("CÓDIGO DEL ESTUDIANTE -> 1052412239");
            Console.WriteLine("NOMBRE DEL ESTUDIANTE -> ANDRÉS MAURICIO ACELAS AREVALO");
            Console.WriteLine();
            Console.WriteLine("DESCRIPCIÓN DE LA ACTIVIDAD - PROBLEMA 4");
            Console.WriteLine("Solucionar el problema de una empresa que contrata diseñadores por horas ocacionalmete y le reañizan el pago por horas.");
            Console.WriteLine();
        }
    }
}
