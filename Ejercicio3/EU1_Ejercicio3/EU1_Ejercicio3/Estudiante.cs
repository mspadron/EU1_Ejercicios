using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU1_Ejercicio3
{
	internal class Estudiante
	{
		public string Nombre { get; set; }
		public int Edad { get; set; }
		public double Calificacion { get; set; }

		// Constructor 
		public Estudiante(string nombre, int edad, double calificacion)
		{
			Nombre = nombre;
			Edad = edad;
			Calificacion = calificacion;
		}

	}
}
