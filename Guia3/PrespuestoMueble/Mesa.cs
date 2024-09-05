using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrespuestoMueble
{
    internal class Mesa:Producto
    {
        private double largo;

        public Mesa(string descripcion, double precioBase, int tipoMaterial, double largo) : base(descripcion, precioBase, tipoMaterial)
        {
            this.largo = largo;
        }

        public override double CalcularPrecio()
        {
            double precio = (precioBase * largo) * (1 + tipoMaterial * 0.33);
            return precio;
        }

        public override string VerDetalle()
        {
            string tipoM = "";
            if (tipoMaterial == 0)
            {
                tipoM = "Pino";
            }
            else if (tipoMaterial == 1)
            {
                tipoM = "Algarrobo";
            }
            else if (tipoMaterial == 2)
            {
                tipoM = "Caoba";
            }
            return $"Tipo Material: {tipoM} - Precio Base: {precioBase} - Largo {largo} - Precio: {CalcularPrecio()}";
        }
    }
}
