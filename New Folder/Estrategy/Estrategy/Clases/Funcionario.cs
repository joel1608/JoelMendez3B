using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategy.Clases
{
    public class Funcionario:Candidatos
    {
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public string Cuenta()///El Funcionario remplaza tres números por cartas.
		{
			return "Uno, dos, tres, cuatro, cinco, seis, siete, sota, caballo, rey";
		}

		public Funcionario(string nombre)
		{
			Nombre = nombre;
		}
		public String getNombre()
		{
			return Nombre;
		}
	}
}
