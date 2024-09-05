using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrespuestoMueble
{
    internal class Presupuesto
    {
        public int CantidadProductos { get; private set; }
        public double CostoTotal { get; private set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        private ArrayList presupuestados = new ArrayList();
        public Presupuesto(string cliente, string direccion)
        {
            Cliente = cliente;
            Direccion = direccion;
        }

        public void AgregarProducto(Producto producto)
        {
            presupuestados.Add(producto);
        }

        public Producto VerProducto(int idx)
        {
            return (Producto)presupuestados[idx];
        }
    }
}
