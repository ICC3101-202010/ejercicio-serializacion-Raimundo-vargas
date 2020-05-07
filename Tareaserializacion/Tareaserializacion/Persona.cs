using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using Microsoft.Win32.SafeHandles;
using System.Runtime.Serialization.Formatters.Binary;

namespace Tareaserializacion
{
    [Serializable]
    class Persona: ISerializable
    {
        public string Nombre;
        public string Apellido;
        public string Edad;
        
        public Persona(string nombre,string apellido, string edad)
            {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Nombre",Nombre);
            info.AddValue("Apellido", Apellido);
            info.AddValue("Edad", Edad);

        }
        public Persona(SerializationInfo info, StreamingContext context)
        {
            Nombre = (string)info.GetValue("Nombre", typeof(string));
            Apellido = (string)info.GetValue("Apellido", typeof(string));
            Edad = (string)info.GetValue("Edad", typeof(string));
        }
    }
}
