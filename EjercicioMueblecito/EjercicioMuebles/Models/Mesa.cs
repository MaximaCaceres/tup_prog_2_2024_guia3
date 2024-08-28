using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMuebles.Models
{
    class Mesa :Producto
    {
        private double Largo { get; set; }

        public Mesa(string descrip, double PrecioBase, int TipoMateria,double largo):base(descrip, PrecioBase, TipoMateria)
        {
            this.Largo = largo;
        }

        public override double CalcularPrecio()
        {
            double total = (PrecioBase * Largo) * (1 + TipoMaterial*0.33);
            return total;
        }
        public override string VerDetalle()
        {
            string material = "NN";
            if(TipoMaterial == 0)
            {
                material = "Pino";
            }
            else
            {
                if(TipoMaterial == 1)
                {
                    material = "Algarrobo";
                }
                else 
                {
                    material = "Caoba"; 
                }
            }
            string date = $"Tipo de producto: Mesa||{Descripcion}|\n|Precio:{PrecioBase}|\n|Largo:{Largo}|\n|{material}\r\n\r\n";
            return date;
        }
    }
}
