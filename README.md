# CRUD Básico en C# (Sin Base de Datos)

Este es un CRUD básico desarrollado con C# y .NET, funcionando de manera local sin base de datos, almacenando los datos en memoria.

## 🚀 Sobre mí

Soy un apasionado del desarrollo de software con un enfoque integral en backend, frontend y DevOps. Me encanta diseñar y construir sistemas escalables, optimizados y seguros, aplicando las mejores prácticas en arquitectura de microservicios. Disfruto trabajando con tecnologías modernas para crear soluciones eficientes y bien estructuradas, siempre buscando la automatización y la mejora continua. Mi objetivo es desarrollar software robusto y mantenerme en constante aprendizaje en este mundo en evolución. 🚀

---

## 📌 Requisitos

1. **Visual Studio 2022** o **Visual Studio Code** con la extensión de C#.
2. **.NET SDK (versión 6.0 o superior)** → [Descargar aquí](https://dotnet.microsoft.com/en-us/download).

---

## ⚙ Instalación y configuración

### 1️⃣ Clonar el repositorio

```bash
git clone <URL_DEL_REPOSITORIO>
cd <NOMBRE_DEL_PROYECTO>
```

### 2️⃣ Restaurar dependencias

```bash
dotnet restore
```

### 3️⃣ Compilar y ejecutar

```bash
dotnet run
```

---

## 🚀 Uso del CRUD

### 📌 Funcionalidades:

Este CRUD permite:

✅ Agregar productos  
✅ Listar productos  
✅ Modificar productos  
✅ Eliminar productos  

Los datos se almacenan en una lista en memoria, por lo que se perderán al reiniciar la aplicación.

---

## 📜 Código base (Ejemplo)

Este CRUD se basa en la siguiente estructura:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static List<Producto> productos = new List<Producto>();

    static void Main()
    {
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\n1. Agregar producto");
            Console.WriteLine("2. Listar productos");
            Console.WriteLine("3. Modificar producto");
            Console.WriteLine("4. Eliminar producto");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AgregarProducto();
                    break;
                case "2":
                    ListarProductos();
                    break;
                case "3":
                    ModificarProducto();
                    break;
                case "4":
                    EliminarProducto();
                    break;
                case "5":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void AgregarProducto()
    {
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());

        productos.Add(new Producto(nombre, precio));
        Console.WriteLine("Producto agregado correctamente.");
    }

    static void ListarProductos()
    {
        Console.WriteLine("\nLista de productos:");
        foreach (var producto in productos)
        {
            Console.WriteLine($"ID: {producto.Id} - Nombre: {producto.Nombre} - Precio: {producto.Precio:C}");
        }
    }

    static void ModificarProducto()
    {
        Console.Write("Ingrese el ID del producto a modificar: ");
        int id = int.Parse(Console.ReadLine());
        var producto = productos.Find(p => p.Id == id);

        if (producto != null)
        {
            Console.Write("Nuevo nombre: ");
            producto.Nombre = Console.ReadLine();
            Console.Write("Nuevo precio: ");
            producto.Precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Producto modificado correctamente.");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    static void EliminarProducto()
    {
        Console.Write("Ingrese el ID del producto a eliminar: ");
        int id = int.Parse(Console.ReadLine());
        productos.RemoveAll(p => p.Id == id);
        Console.WriteLine("Producto eliminado correctamente.");
    }
}

class Producto
{
    private static int contadorId = 1;
    public int Id { get; }
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Producto(string nombre, double precio)
    {
        Id = contadorId++;
        Nombre = nombre;
        Precio = precio;
    }
}
```

---

## 🛠 Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** .NET Console App
- **Base de datos:** Ninguna (almacenamiento en memoria)

---

## 📌 Notas

- Este CRUD almacena los datos en una lista en memoria, lo que significa que se perderán al cerrar la aplicación.
- Puede ser utilizado como base para futuros proyectos con almacenamiento persistente.

---

## 📝 Autor

- **Luis Figuereo**  
- [GitHub](https://www.github.com/luchan63)

---
