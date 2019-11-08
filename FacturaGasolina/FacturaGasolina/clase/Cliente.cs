using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaGasolina.clase
{
    class Cliente
    {
       
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int identidicacion;

        public int Identificacion
        {
            get { return identidicacion; }
            set { identidicacion = value; }
        }

       
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private List<Gasolina> gasolina;

        public List<Gasolina> Gasolina
        {
            get { return gasolina; }
            set { gasolina = value; }            
        }

        

        public Cliente(string nombre, int identificacion, string direccion, List<Gasolina> gasolina)
        {
            
            Nombre = nombre;
            Identificacion = identificacion;
            Direccion = direccion;
            Gasolina = gasolina;
           
        }
    }
}
