using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategy.Clases
{
    public class Ideal:Candidatos
    {
		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public string Cuenta()//Así lo haría una persona normal.
		{
			return "Uno, dos, tres, cuatro, cinco, seis, siete, ocho, nueve, diez";
		}

		public Ideal(string nombre)
		{
			Nombre = nombre;
		}
		public String getNombre()
		{
			return Nombre;
		}
	}
}
