using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndresAcelasFase3Problema4
{
    class Trabajador
    {
        public int NumerodeIdentificacion { get; set; }
        public string Nombre { get; set; }
        public int HorasTrabajadas { get; set; }

        public int ValorHoraTrabajador = 30000;

        private double CalcularHorasTrabajadas(int numeroHoras)
        {
            var Resultado = ValorHoraTrabajador * numeroHoras;
            return Resultado;
        }

        public void ImprimirDatosDelTrabajador ()
        {
            var Total = CalcularHorasTrabajadas(HorasTrabajadas);
            Console.WriteLine("::: RESULTADO DEL TRABAJADOR :::");
            Console.WriteLine("NOMBRE DEL TRABAJADOR: " + Nombre);
            Console.WriteLine("IDENTIDICACIÓN DEL TRABAJADOR: " + NumerodeIdentificacion);
            Console.WriteLine("HORAS TRABAJADAS: " + HorasTrabajadas);
            Console.WriteLine("VALOR A PAGAR: $" +  Total);
        }
    }
}
