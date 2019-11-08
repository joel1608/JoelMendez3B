using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaGasolina.clase
{
    class Gasolina
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set {tipo = value;}

        }

        private int galones;

        public int Galones
        {
            get { return galones; }
            set { galones = value; }
        }

        private float precio;

        public float Precio
        {
            get
            {
                if (Tipo=="Extra")
                    {
                        precio=1.5f;
                    }
                    if (Tipo=="Super")
                    {
                        precio = 2;
                    }
               
                    return precio;
             }
           
        }
         
        public float Subtotal ()
        {
            return Precio * Galones;
        }

       public float Iva ()
        {
            return Subtotal() * 0.12f;
        }

        public float Total()
        {
            return Iva() + Subtotal();
        }

        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }


        public Gasolina(string tipo, int galones)
        {
            Tipo = tipo;
            Galones = galones;
        
        }
    }
}
