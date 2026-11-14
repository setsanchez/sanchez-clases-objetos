using System;
using System.Collections.Generic;
using System.Text;

namespace TecnoPunto
{
    public class Producto
    {
        //Atributos
        private string _codigo;
        private string _nombre;
        private double _precio;
        private int _cantidad;

        // Propiedades de acceso (get y set) y validaciones
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

        //Constructor
        public Producto(string codigo, string nombre, double precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Codigo: {Codigo,-8} \nNombre: {Nombre,-15} \nPrecio: ${Precio,8:N2} \nCantidad: {Cantidad,4} \nTotal: ${ValorTotal,10:N2}");
        }
    }
}
