using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEncapsulamiento
{
    class Changuito
    {
        public int numero = 0;
        private List<Producto> listadoDeProductos;

        public List<Producto> ListadoDeProductos
        {
            get { return this.listadoDeProductos; }
        }

        public Changuito()
        {
            this.listadoDeProductos = new List<Producto>();
        }

        public void AgregarProducto(Producto Prod)
        {
            this.listadoDeProductos.Add(Prod);
        }


    }
}
