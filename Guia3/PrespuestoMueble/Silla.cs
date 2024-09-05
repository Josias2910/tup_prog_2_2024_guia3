using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrespuestoMueble
{
    internal class Silla:Producto
    {
        public Silla(string descripcion, double precioBase, int tipoMaterial) : base(descripcion, precioBase, tipoMaterial)
        {

        }

        public override double CalcularPrecio()
        {
            double precio = (precioBase * (1 + tipoMaterial * 0.25));
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
            return $"Tipo Material: {tipoM} - Precio Base: {precioBase} - Precio: {CalcularPrecio()}";
        }
    }
}
