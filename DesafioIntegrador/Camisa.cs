using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioIntegrador
{
    class Camisa : Prenda
    {
        private bool mangaCorta;

        public Camisa(bool mangaCorta, bool standard, bool premium, double precio, int cantidad) : base(standard, premium, precio, cantidad)
        {
            this.mangaCorta = mangaCorta;
        }

        public double Precio { get => precio; }

        public void CalcularPrecio()

        {
            double precio = 0;

            if (mangaCorta == true)
            {
                precio = precio - (precio * 0.1);
            }

            base.CalcularPrecio();
        }
    }
}