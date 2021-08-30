using LABSEGUNDAPARTE.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABSEGUNDAPARTE.Negocio
{
    class NclsPersona
    {
        public String calcularIMC(Persona persona) 
        {
            persona.Totalpeso = (persona.Peso / Math.Pow(persona.Altura, 2));

            if (persona.Totalpeso < 20)
            {
                return "Peso ideal";
            }
            else
            {
                return "Tiene sobrepeso";
            }
        }

        public string esMayorDeEdad(Persona persona)
        {
            if (persona.Edad > 18)
            {
                return "Es mayor de Edad";
            }
            else
            {
                return "Es menor de edad";
            }
        }
    }
}
