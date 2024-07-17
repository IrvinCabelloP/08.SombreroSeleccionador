using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SombreroSeleccionador
{
    internal class PreguntasH
    {
        //Se crea una lista en la que se almacenan las preguntas y las posibles opciones que puede elegir el usuario, esto usando la clase pregunta 
        public static List<Pregunta> obtenerPreguntas()
        {
            return new List<Pregunta>()
            {
                new Pregunta()
                {
                    Texto = "¿Qué valoras más en un amigo/a?",
                    Opciones = new Dictionary<string, string>
                    {
                        {"a", "Valentía"},
                        {"b", "Lealtad"},
                        {"c", "Inteligencia"},
                        {"d", "Ambición"}
                    }
                },

               new Pregunta()
                {
                    Texto = "¿Qué cualidad valoras más en ti mismo/a?",
                    Opciones = new Dictionary<string, string>
                    {
                        {"a", "Valentía"},
                        {"b", "Lealtad"},
                        {"c", "Inteligencia"},
                        {"d", "Ambición"}
                    }
                },

                new Pregunta()
                {
                    Texto = "¿Qué tipo de aventuras prefieres?",
                    Opciones = new Dictionary<string, string>
                    {
                        {"a", "Las más emocionantes y arriesgadas"},
                        {"b", "Las que disfruto con amigos y son memorables"},
                        {"c", "Las que me enseñen algo nuevo y desafiantes intelectualmente"},
                        {"d", "Las que me lleven al éxito y poder"}
                    }
                },

                new Pregunta()
                {
                    Texto = "¿Qué animal te gusta más?",
                    Opciones = new Dictionary<string, string>
                    {
                        {"a", "León"},
                        {"b", "Tejón"},
                        {"c", "Águila"},
                        {"d", "Serpiente"}
                    }
                },

               new Pregunta()
                {
                    Texto = "¿Qué tipo de habilidades te gustaría desarrollar?",
                    Opciones = new Dictionary<string, string>
                    {
                        {"a", "Valientes y audaces"},
                        {"b", "Amistosas y empáticas"},
                        {"c", "Intelectuales y sabias"},
                        {"d", "Astutas y ambiciosas"}
                    }
                },

               new Pregunta()
                {
                    Texto = "¿Qué te motiva más en la vida?",
                    Opciones = new Dictionary<string, string>
                    {
                        {"a", "La justicia y la valentía"},
                        {"b", "La lealtad y la amistad"},
                        {"c", "El conocimiento y la curiosidad"},
                        {"d", "El poder y el prestigio"}
                    }
                },

               new Pregunta()
                {
                    Texto = "¿Qué tipo de persona admiras más?",
                    Opciones = new Dictionary<string, string>
                    {
                        {"a", "Los que actúan con coraje"},
                        {"b", "Los que son leales y confiables"},
                        {"c", "Los que tienen sabiduría y conocimiento"},
                        {"d", "Los que son astutos y ambiciosos"}
                    }
                },

               new Pregunta()
                {
                    Texto = "¿Cómo te describirían tus amigos más cercanos?",
                    Opciones = new Dictionary<string, string>
                    {
                        {"a", "Valiente y decidido/a"},
                        {"b", "Leal y confiable/a"},
                        {"c", "Inteligente y curioso/a"},
                        {"d", "Astuto/a y ambicioso/a"}
                    }
                },

               new Pregunta()
                {
                    Texto = "¿Qué tipo de libro prefieres leer?",
                    Opciones = new Dictionary<string, string>
                    {
                        {"a", "Aventuras llenas de acción"},
                        {"b", "Historias de amistad y superación"},
                        {"c", "Libros de ciencia o historia"},
                        {"d", "Estrategias y poder"}
                    }
                },

               new Pregunta()
                {
                    Texto = "¿Con coraje y decisión?",
                    Opciones = new Dictionary<string, string>
                    {
                        {"a", "Con coraje y decisión"},
                        {"b", "Con paciencia y apoyo de otros"},
                        {"c", "Con análisis y planificación"},
                        {"d", "Con astucia y estrategia"}
                    }
                }

            };
        }        
    }
}
