using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMuebles.Models
{
     class Silla: Producto
    {
        public Silla(string descrip, double PrecioBase, int TipoMateria) : base(descrip, PrecioBase, TipoMateria)
        {

        }
        public override double CalcularPrecio()
        {
            double total = PrecioBase * (1 + TipoMaterial * 0.25);
            return total;   
        }
        public override string VerDetalle()
        {
            string material = "NN";
            if (TipoMaterial == 0)
            {
                material = "Pino";
            }
            else
            {
                if (TipoMaterial == 1)
                {
                    material = "Algarrobo";
                }
                else
                {
                    material = "Caoba";
                }
            }
            string date = $"Tipo de producto: Silla||{Descripcion}|\r|Precio:{PrecioBase}|\r|{material}";
            return date;
        }
    }
}
