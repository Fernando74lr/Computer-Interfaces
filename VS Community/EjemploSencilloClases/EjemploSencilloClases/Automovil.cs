using System;

namespace EjemploSencilloClases
{
    class Automovil
    {
        // Atributos del Automóvil.
        private string modelo;
        private string color;
        private int año;

        // Constructor sin parámatros.
        public Automovil()
        {

        }

        // Constructor con parámatros.
        public Automovil(string Modelo, string Color, int Año)
        {
            modelo = Modelo;
            color = Color;
            año = Año;
        }

        // Métodos para asignar valores a los atributos.
        public void AsignarModelo(string Modelo)
        {
            modelo = Modelo;
        }

        public void AsignarColor(string Color)
        {
            color = Color;
        }

        public void AsignarAño(int Año)
        {
            año = Año;
        }

        // Métodos para obtener los atributos.
        public string ObtenerModelo()
        {
            return modelo;
        }

        public string ObtenerColor()
        {
            return color;
        }

        public int ObtenerAño()
        {
            return año;
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Año
        {
            get { return año; }
            set { año = value; }
        }

    }
}
