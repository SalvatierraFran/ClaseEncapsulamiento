using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Changuito Changui = new Changuito();
            Producto prod1 = new Producto(100);

            double precio;

            precio = prod1.PrecioCosto = 200;
            precio = prod1.precioFinal;

            Changui.AgregarProducto(prod1);
            Changui.AgregarProducto(new Producto(150));

            foreach (Producto item in Changui.ListadoDeProductos)
            {
                Console.WriteLine(item.precioFinal);
            }            

            List<Producto> nuevaListaDeProductos;
            nuevaListaDeProductos = new List<Producto>();

            Console.ReadKey();
        }

        /*Crear las funcionalidades necesarias para que retorne
         una ID que no exista en el listado que sea random 
         y que esté dentro de los margenes.*/
    }
}
