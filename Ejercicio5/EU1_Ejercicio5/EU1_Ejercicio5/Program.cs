using System;

namespace EU1_Ejercicio5
{
	class Program
	{
		static void Main()
		{
			// Creación de un EstudianteGraduado 
			EstudianteGraduado graduado1 = new EstudianteGraduado("Ana Rueda", 25, 90.2, "Licenciatura en Gerencia Deportiva");

			// Utilizar el método MostrarInformacion para mostrar la información del estudiante graduado
			graduado1.MostrarInformacion();
		}
	}
}
