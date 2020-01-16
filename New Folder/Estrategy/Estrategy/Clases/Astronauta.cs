using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategy.Clases
{
	public class Astronauta : Candidatos
	{
		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public string Cuenta()//Defino que el astronauna cuenta de manera inversa.
		{
			return "Diez, nueve, ocho, siete, seis, cinco, cuatro, tres dos, uno";
		}

		public Astronauta(string nombre)
		{
			Nombre = nombre;
		}
		public String getNombre()//Aquí le pasamos el nombre del astronauta a la interface. 
		{
			return Nombre;
		}
	}
}
