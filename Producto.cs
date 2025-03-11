using System;

namespace Producto
{
    public class Productos
    {
        private int id;
        private string nombre;
        private double precio;

        public Productos(int id, string nombre, double precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public void Mostrar()
        {
            Console.WriteLine("Id: " + id + " Nombre: " + nombre + " Precio: " + precio);
        }

        public override string ToString()
        {
            return "Id: " + id + " Nombre: " + nombre + " Precio: " + precio;
        }
    }
}