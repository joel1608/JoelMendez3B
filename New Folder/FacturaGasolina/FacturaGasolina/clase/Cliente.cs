﻿using System;
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

        private List<Producto> producto;

        public List<Producto> Producto
        {
            get { return producto; }
            set { producto = value; }            
        }

        

        public Cliente(string nombre, int identificacion, string direccion, List<Producto> producto)
        {
            
            Nombre = nombre;
            Identificacion = identificacion;
            Direccion = direccion;
            Producto = producto;
           
        }
    }
}
