using System;

namespace EU1_Ejercicio4
{
	class Program
	{
		static void Main()
		{
			// Creación objeto estudiante1
			Estudiante estudiante1 = new Estudiante("Matias Padrón", 18, 85.5);

			// Impresión en consola del estudiante1 por metodo
			estudiante1.ImprimirInformacion();
		}
	}
}
