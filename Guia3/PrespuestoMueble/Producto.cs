using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrespuestoMueble
{
    abstract internal class Producto
    {
        private string descripcion;
        protected double precioBase;
        protected int tipoMaterial;

        public Producto(string descripcion, double precioBase, int tipoMaterial)
        {
            this.descripcion = descripcion;
            this.precioBase = precioBase;
            this.tipoMaterial = tipoMaterial;
        }

        abstract public double CalcularPrecio();
        abstract public string VerDetalle();
    }
}
