using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIntegrador
{
    class Prenda
    {
        protected bool standard, premium;
        protected double precio = 0;
        protected int cantidad = 0;

        public Prenda(bool standard, bool premium, double precio, int cantidad)
        {
            this.standard = standard;
            this.premium = premium;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public void CalcularPrecio()
        {

            if (premium == true)
            {
                precio = precio + (precio * 0.3);
            }

            precio = precio * cantidad;
        }
    }
}