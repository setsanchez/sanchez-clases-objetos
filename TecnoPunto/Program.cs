namespace TecnoPunto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" SISTEMA DE CONTROL DE INVENTARIO - TECNOPUNTO \n");

            Producto p1 = LeerProducto(1);
            Producto p2 = LeerProducto(2);
            Producto p3 = LeerProducto(3);

            Console.WriteLine(" REPORTE DE INVENTARIO \n");

            p1.MostrarInfo();
            Console.WriteLine();
            p2.MostrarInfo();
            Console.WriteLine();
            p3.MostrarInfo();

            double ValorTotalInventario = p1.ValorTotal + p2.ValorTotal + p3.ValorTotal;
            Console.WriteLine("-------------------------------------------------"); 
            Console.WriteLine($"VALOR TOTAL DEL INVENTARIO: ${ValorTotalInventario:N2}"); 
            Console.WriteLine("=================================================");
        }

        static Producto LeerProducto(int numero)
        {
            Console.WriteLine($"--- REGISTRO DEL PRODUCTO #{numero} ---");

            Console.Write("Ingrese el código: ");
            string codigo = Console.ReadLine();

            string nombre;
            do
            {
                Console.Write("Ingrese el nombre del producto: ");
                nombre = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    Console.WriteLine(" Error: El nombre no puede estar vacío.");
                }
            } while (string.IsNullOrWhiteSpace(nombre));

            double precio;
            while (true)
            {
                Console.Write("Ingrese el precio: ");
                if (double.TryParse(Console.ReadLine(), out precio) && precio > 0)
                {
                    break;
                }
                Console.WriteLine(" Error: Ingrese un precio numérico mayor a 0.");
            }

            int cantidad;
            while (true)
            {
                Console.Write("Ingrese la cantidad en existencia: ");
                if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad >= 0)
                {
                    break;
                }
                Console.WriteLine(" Error: Ingrese un número entero no negativo.");
            }

            Console.WriteLine();
            return new Producto(codigo, nombre, precio, cantidad);
        }
    }
}