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

        public Pantalon(int cantidad, double precio) : base(cantidad, precio)
        {

        }

        public Pantalon(bool bermuda, int cantidad, double precio, bool standard, bool premium) : base(cantidad, precio, standard, premium)
        {

        }

        override
        public double CalcularPrecioFinal()
        {
            double precioFinal = precio;

            if (bermuda)
            {
                precioFinal = (precioFinal * 0.8);
            }

            if (premium)
            {
                precioFinal = (precioFinal * 1.3);
            }

            precioFinal = (precioFinal * cantidad);

            return precioFinal;
        }
    }
}