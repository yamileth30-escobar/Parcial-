using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion1G2
{
    public class Moto : Vehiculo
    {
        public int Cilindraje { get; set; }

        public Moto(string marca, string modelo, int anio, int cilindraje)
            : base(marca, modelo, anio)
        {
            Cilindraje = cilindraje;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Cilindraje: " + Cilindraje);
        }

        public override void Encender()
        {
            Console.WriteLine("La moto se enciende con arranque eléctrico.");
        }
    }
}
