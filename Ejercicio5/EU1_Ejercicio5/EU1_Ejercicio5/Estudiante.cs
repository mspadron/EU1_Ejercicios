using System;

namespace EU1_Ejercicio5
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

		// Método para imprimir la información del estudiante
		public virtual void MostrarInformacion()
		{
			Console.WriteLine("Información del Estudiante:");
			Console.WriteLine("Nombre: " + Nombre);
			Console.WriteLine("Edad: " + Edad);
			Console.WriteLine("Calificación: " + Calificacion);
		}
	}
}
