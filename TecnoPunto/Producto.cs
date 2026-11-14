using System;
using System.Collections.Generic;
using System.Text;

namespace TecnoPunto
{
    public class Producto
    {
        private string _codigo;
        private string _nombre;
        private double _precio;
        private int _cantidad;

        public string Codigo
        {
            get { return _codigo;  }
            set { _codigo = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Advertencia: El nombre no puede estar vacío.");
                }
                else
                {
                    _nombre = value;
                }
            }
        }

        public double Precio
        {
            get { return _precio;  }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Advertencia: El precio debe ser mayor a 0.");
                }
                else
                {
                    _precio = value;
                }
            }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Advertencia: La cantidad no puede ser negativa.");
                }
                else
                {
                    _cantidad = value;
                }
            }
        }

        public double ValorTotal
        {
            get { return _precio * _cantidad; }
        }
    }
}
