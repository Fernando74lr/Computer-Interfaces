using System;

namespace EjemploSencilloClases
{
    class Program
    {
        static void Main(string[] args)
        {
            var Audi = new Automovil("R8", "Negro", 2021);
            var VW = new Automovil();

            VW.AsignarModelo("Jetta");
            VW.AsignarColor("Azul");
            VW.AsignarAño(2021);

            //Console.WriteLine($"{VW.getColor()}");
            string miModelo = VW.ObtenerModelo();
            string miColor = VW.ObtenerColor();
            int miAño = VW.ObtenerAño();

            Console.WriteLine($"VW. Modelo: {miModelo}, Color: {miColor}, Año: {miAño}.");
            Console.WriteLine($"Jetta. Modelo: {Audi.Modelo}, Color: {Audi.Color}, Año: {Audi.Año}.");


            Console.Write("Presione cualquier tecla para terminar");
            Console.ReadKey();
        }
    }
}
