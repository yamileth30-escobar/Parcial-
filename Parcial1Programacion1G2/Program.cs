using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion1G2
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        public Vehiculo(string marca, string modelo, int anio)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Vehículo:");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Año: " + Anio);
        }

        public virtual void Encender()
        {
            Console.WriteLine("El vehículo se está encendiendo...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("   SISTEMA DE VEHICULOS - PARCIAL   ");
            Console.WriteLine("====================================");
            Console.WriteLine();

            // TODO: Crear una lista de tipo Vehiculo
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            // TODO: Crear al menos DOS objetos de clases hijas
            Carro carro1 = new Carro("Toyota", "Corolla", 2022, 4);
            Moto moto1 = new Moto("Yamaha", "R15", 2021, 150);

            // TODO: Agregar los objetos a la lista
            vehiculos.Add(carro1);
            vehiculos.Add(moto1);

            // TODO: Recorrer la lista usando foreach
            foreach (Vehiculo v in vehiculos)
            {
                // TODO: Llamar a los métodos
                // MostrarInformacion()
                v.MostrarInformacion();

                // Encender()
                v.Encender();

                Console.WriteLine();
            }

            Console.WriteLine("Programa finalizado.");
            Console.ReadKey();
        }
    }
}
