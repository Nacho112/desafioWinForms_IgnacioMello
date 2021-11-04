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

        public Camisa(int cantidad, double precio) : base(cantidad, precio)
        {

        }

        public Camisa(bool mangaCorta, int cant, double precio, bool calStandard, bool premium) : base(cant, precio, calStandard, premium)
        {

        }

        override
        public double CalcularPrecioFinal()
        {
            double precioFinal = precio;

            if (mangaCorta == true)
            {
                precioFinal = precioFinal * 0.9;
            }

            if (premium == true)
            {
                precioFinal = precioFinal * 1.3;
            }

            precioFinal = (precioFinal * cantidad);

            return precioFinal;
        }
    }
}