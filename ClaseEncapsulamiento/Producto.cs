using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEncapsulamiento
{
    class Producto
    {
        public int id = 0;
        private double _precioCosto;

        //Propiedad PrecioCosto
        public double PrecioCosto
        {
            set { this._precioCosto = value; }
        }
        
        //Propiedad
        public double precioFinal 
        {
            //set { value } //Me asigna algo
            get { return this.CalcularPrecioFinal(); } //Retorna algo
        }

        //Metodo
        public double CalcularPrecioFinal()
        {
            return this._precioCosto * 1.25;
        }

        //Constructor
        public Producto(double PrecioCosto)
        {
            this._precioCosto = PrecioCosto;
        }

        public Producto(int ID)
        {
            this.id = ID;
        }
    }
}
