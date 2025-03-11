using System;
using System.Collections;

namespace Producto
{
    public class Gestor
    {
        private List<Productos> prodcutos;

        public Gestor()
        {
            prodcutos = new List<Productos>();
        }

        public void agregarProducto(Productos producto)
        {
            prodcutos.Add(producto);
        }

        public List<Productos> mostrarProductos()
        {
            return prodcutos;
        }

        public void eliminarProducto(int id)
        {
            prodcutos.RemoveAll(p => p.Id == id);
        }

        public void modificarProducto(int id, string nombre, double precio)
        {
            Productos prodcuto = prodcutos.Find(p => p.Id == id) ?? throw new InvalidOperationException("Producto no encontrado");
            prodcuto.Nombre = nombre;
            prodcuto.Precio = precio;
        }

    }
}