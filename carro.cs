using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion1G2
{
    public class Carro : Vehiculo
    {
        public int NumeroPuertas { get; set; }

        public Carro(string marca, string modelo, int anio, int numeroPuertas)
            : base(marca, modelo, anio)
        {
            NumeroPuertas = numeroPuertas;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Numero de puertas: " + NumeroPuertas);
        }

        public override void Encender()
        {
            Console.WriteLine("El carro se enciende con llave o botón.");
        }
    }
}
