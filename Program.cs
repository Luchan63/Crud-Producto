using System;
using Producto; // Asegúrate de que el namespace correcto está definido en la clase Producto.

class Program
{
    public static Gestor g = new Gestor();

    static void Main()
    {
        try
        {
            bool salir = false;
            int opcion;
            do
            {
                menu();
                string? input = Console.ReadLine();

                if (!int.TryParse(input, out opcion))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        agregarProducto();
                        break;
                    case 2:
                        listarProductos();
                        break;
                    case 3:
                        modificarProducto();
                        break;
                    case 4:
                        eliminarProducto();
                        break;
                    case 5:
                        agregarProductosDeEjemplo();
                        break;
                    case 6:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (!salir);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }

    private static void menu()
    {
        Console.WriteLine("1. Agregar producto");
        Console.WriteLine("2. Mostrar productos");
        Console.WriteLine("3. Modificar producto");
        Console.WriteLine("4. Eliminar producto");
        Console.WriteLine("5. agregar productos de ejemplo");
        Console.WriteLine("6. Salir");
    }

    private static void agregarProducto()
    {
        Console.WriteLine("Ingrese el id del producto:");
        string? inputId = Console.ReadLine();
        if (!int.TryParse(inputId, out int id))
        {
            Console.WriteLine("ID inválido. Inténtelo de nuevo.");
            return;
        }

        Console.WriteLine("Ingrese el nombre del producto:");
        string nombre = Console.ReadLine() ?? "Nombre por defecto"; // Evita `null`

        Console.WriteLine("Ingrese el precio del producto:");
        string? inputPrecio = Console.ReadLine();
        if (!double.TryParse(inputPrecio, out double precio))
        {
            Console.WriteLine("Precio inválido. Inténtelo de nuevo.");
            return;
        }

        Productos p = new Productos(id, nombre, precio);
        g.agregarProducto(p);

        pausa();
    }

    private static void eliminarProducto()
    {
        Console.WriteLine("Ingrese el id del producto a eliminar:");
        string? inputId = Console.ReadLine();
        if (!int.TryParse(inputId, out int id))
        {
            Console.WriteLine("ID inválido. Inténtelo de nuevo.");
            return;
        }

        g.eliminarProducto(id);
        pausa();
    }

    private static void listarProductos()
    {
        Console.WriteLine("\n\n          Listado de Productos");
        Console.WriteLine("====================================================");
        Console.WriteLine("ID     Nombre                 Precio");
        Console.WriteLine("====================================================");

        foreach (Productos producto in g.mostrarProductos())
        {
            Console.WriteLine($"{producto}");
        }

        pausa();
    }

    private static void modificarProducto()
    {
        Console.WriteLine("Ingrese el id del producto a modificar:");
        string? inputId = Console.ReadLine();
        if (!int.TryParse(inputId, out int id))
        {
            Console.WriteLine("ID inválido. Inténtelo de nuevo.");
            return;
        }

        Console.WriteLine("Ingrese el nombre del producto:");
        string nombre = Console.ReadLine() ?? "Nombre por defecto"; // Evita `null`

        Console.WriteLine("Ingrese el precio del producto:");
        string? inputPrecio = Console.ReadLine();
        if (!double.TryParse(inputPrecio, out double precio))
        {
            Console.WriteLine("Precio inválido. Inténtelo de nuevo.");
            return;
        }

        g.modificarProducto(id, nombre, precio);
        pausa();
    }

    private static void agregarProductosDeEjemplo()
    {
        g.agregarProducto(new Productos(1, "Samsung Galaxy S22 Ultra", 1000));
        g.agregarProducto(new Productos(2, "iPhone 13", 1200));
        g.agregarProducto(new Productos(3, "Xiaomi Redmi Note 10", 300));
        g.agregarProducto(new Productos(4, "Huawei P40", 400));
        g.agregarProducto(new Productos(5, "Motorola G9", 500));
        g.agregarProducto(new Productos(6, "Nokia 3310", 600));
        pausa();
    }

    private static void pausa()
    {
        Console.WriteLine("\nPresione ENTER para continuar...");
        Console.ReadLine();
    }
}