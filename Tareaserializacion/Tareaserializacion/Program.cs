using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Xml.Serialization;



namespace Tareaserializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("NOMBRE:\n");
            string nombre = Console.ReadLine();
            Console.WriteLine("APELLIDO:\n");
            string apellido= Console.ReadLine();
            Console.WriteLine("EDAD:\n");
            string edad = Console.ReadLine();
            Persona persona = new Persona(nombre,apellido,edad);

            Stream stream = File.Open("PersonaData.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, persona);
            stream.Close();
            persona = null;

            stream = File.Open("PersonaData.dat", FileMode.Open);
            bf = new BinaryFormatter();
            persona = (Persona)bf.Deserialize(stream);
            stream.Close();
            //Console.WriteLine(persona.ToString());
            Console.ReadLine();

            

        }
    }
}
