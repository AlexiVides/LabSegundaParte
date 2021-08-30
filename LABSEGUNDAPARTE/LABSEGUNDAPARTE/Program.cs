using LABSEGUNDAPARTE.Entidades;
using LABSEGUNDAPARTE.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABSEGUNDAPARTE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!!!!!Escribe tus Datos!!!!!!! ");
            Console.WriteLine("Escribe tu Nombre: ");
            String nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu Edad: ");
            int edad =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Escribe tu Sexo: ");
            String sexo = Console.ReadLine();
            Console.WriteLine("Escribe tu Peso: ");
            Double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe tu Altura: ");
            Double altura = Convert.ToDouble(Console.ReadLine());

            Persona persona = new Persona(nombre,edad,sexo,peso,altura);

            Persona persona1 = new Persona(nombre, edad, sexo);

            NClsPersona nclsPersona = new NClsPersona();
            Console.WriteLine("-------------------------------- ");
            //CALCULAR IMC
            Console.WriteLine(nclsPersona.calcularIMC(persona));
            //MAYOR O MENOR
            Console.WriteLine(nclsPersona.esMayorDeEdad(persona));


            Console.WriteLine(persona.ToString());
            Console.ReadLine();


        }
    }
}
