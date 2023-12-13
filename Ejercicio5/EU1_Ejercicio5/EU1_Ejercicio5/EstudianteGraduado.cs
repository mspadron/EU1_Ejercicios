
using System;

namespace EU1_Ejercicio5
{
	internal class EstudianteGraduado : Estudiante
	{
		// Nueva propiedad para el estudiante graduado
		public string Titulo { get; set; }

		public EstudianteGraduado(string nombre, int edad, double calificacion, string titulo) : base(nombre, edad, calificacion)
		{
			Titulo = titulo;
		}

		public override void MostrarInformacion()
		{
			base.MostrarInformacion();
			Console.WriteLine("Título: " + Titulo);
		}
	}
}
