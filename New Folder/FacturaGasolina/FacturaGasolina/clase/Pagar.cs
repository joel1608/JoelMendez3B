using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaGasolina.clase
{
    public class Pagar
    {
        private float subtotal;

        public float Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        private float iva;

        public float Iva
        {
            get
            {
                    iva = Subtotal * 0.12f;
                    return iva;
            }
            
        }

        private float total;

        public float Total
        {
            get
            {
                total = Subtotal + Iva;
                return total;
            }
            
        }


    }
}
