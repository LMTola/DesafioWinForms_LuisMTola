using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIntegrador
{
    class Pantalon : Prenda
    {
        private bool bermuda;

        public Pantalon(bool bermuda, bool standard, bool premium, double precio, int cantidad) : base(standard, premium, precio, cantidad)
        {
            this.bermuda = bermuda;
        }

        public double Precio { get => precio; }

        public void CalcularPrecio()
        {
            double precio = 0;

            if (bermuda == true)
            {
                precio = precio - (precio * 0.2);
            }
            base.CalcularPrecio();
        }
    }
}
