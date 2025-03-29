using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoEjemplo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Crear instancias de las clases
			Persona persona = new Persona();
			Mesero mesero = new Mesero();
			Futbolista futbolista = new Futbolista();

			// Llamar al método Actividad en cada instancia
			persona.Actividad();
			mesero.Actividad();
			futbolista.Actividad();

			Console.ReadKey(); // Mantener la consola abierta
		}

		// Clase padre
		class Persona
		{
			// Método virtual para permitir la sobreescritura
			public virtual void Actividad()
			{
				Console.WriteLine("Viendo TV.");
			}
		}

		// Clase hija Mesero
		class Mesero : Persona
		{
			// Sobrescribe el método Actividad
			public override void Actividad()
			{
				Console.WriteLine("Sirviendo comida.");
			}
		}

		// Clase hija Futbolista
		class Futbolista : Persona
		{
			// Sobrescribe el método Actividad
			public override void Actividad()
			{
				Console.WriteLine("Jugando un partido.");
			}
		}
	}
}


