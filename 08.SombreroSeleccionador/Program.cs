using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SombreroSeleccionador
{
    internal class Program
    {

        static Dictionary<string, int> puntajes = new Dictionary<string, int>
        {
            {"Gryffindor", 0},
            {"Hufflepuff", 0},
            {"Ravenclaw", 0},
            {"Slytherin", 0}
        };

        static void SistemaDePuntaje(string eleccionUsuario, Dictionary<string, int>puntajes)
        {
            try
            {
                switch (eleccionUsuario)
                {
                    case "a":
                        puntajes["Gryffindor"]++;
                        break;
                    case "b":
                        puntajes["Hufflepuff"]++;
                        break;
                    case "c":
                        puntajes["Ravenclaw"]++;
                        break;
                    case "d":
                        puntajes["Slytherin"]++;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Elige entre a, b, c o d.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void AsignaciónFinal()
        {
            Console.WriteLine("Puntajes finales:");
            foreach (var puntaje in puntajes)
            {
                Console.WriteLine($"{puntaje.Key} : {puntaje.Value}");
            }
            Console.WriteLine("\n");

            string casaGanadora = null;
            int puntajeMaximo = int.MinValue;

            foreach (var kvp in puntajes)
            {
                if (kvp.Value > puntajeMaximo)
                {
                    puntajeMaximo = kvp.Value;
                    casaGanadora = kvp.Key;
                }
            }

            Console.WriteLine("La casa a la que perteneces es: " + casaGanadora);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Programa que simula el comportamiento del sombrero seleccionador del universo de Harry Potter.");
            Console.WriteLine("La forma en que se seleccionará la casa es a través de preguntas que definirán la personalidad y valores de la persona y acorde a eso se le asiganará una casa con la que sea compatible.\n\n");
            List<Pregunta> preguntas = PreguntasH.obtenerPreguntas();
            foreach (var pregunta in preguntas)
            {
                Console.WriteLine(pregunta.Texto);
                foreach (var opcion in pregunta.Opciones)
                {
                    Console.WriteLine($"{opcion.Key}.{opcion.Value}");                   
                }
                Console.WriteLine("Elige una opción:");
                string eleccionUsuario = Console.ReadLine().ToLower();
                SistemaDePuntaje(eleccionUsuario, puntajes);
                Console.WriteLine("\n");                
            }
            AsignaciónFinal();
            Console.ReadLine(); 
        }
              
    }
}