

using System;

namespace EU1_Ejercicio3
{
	class Program
	{
		static void Main()
		{
			// Creación objeto estudiante1
			Estudiante estudiante1 = new Estudiante("Adrian Padrón", 17, 75.5);

			// Impresión en consola del estudiante1
			Console.WriteLine("Información del Estudiante 1:");
			Console.WriteLine("Nombre: " + estudiante1.Nombre);
			Console.WriteLine("Edad: " + estudiante1.Edad);
			Console.WriteLine("Calificación: " + estudiante1.Calificacion);
		}
	}
}
