using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategy.Clases
{
    public class Cartero:Candidatos
    {
		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public string Cuenta()//El cartero cuenta de par en par.
		{
			return "Uno, tres, cinco, siete, nueve, dos, cuatro, seis, ocho ,diez";
		}

		public Cartero(string nombre)
		{
			Nombre = nombre;
		}
		public String getNombre()
		{
			return Nombre;
		}
	}
}
