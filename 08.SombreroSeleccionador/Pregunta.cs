using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SombreroSeleccionador
{
    internal class Pregunta
    {
        public string Texto { get; set; }
        public Dictionary<string, string> Opciones { get; set; }
    }
}