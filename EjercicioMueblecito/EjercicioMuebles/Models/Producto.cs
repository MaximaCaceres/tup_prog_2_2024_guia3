using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMuebles.Models
{
    abstract class Producto
    {
        private protected string Descripcion { get; set; }
       protected double PrecioBase { get; set; }
        protected int TipoMaterial { get; set; }

        public Producto(string descr, double preBase,int Tmaterial)
        {
            Descripcion = descr;
            PrecioBase = preBase;
            TipoMaterial = Tmaterial;
        }
        public abstract double CalcularPrecio();
        public abstract string VerDetalle();
    }
}
