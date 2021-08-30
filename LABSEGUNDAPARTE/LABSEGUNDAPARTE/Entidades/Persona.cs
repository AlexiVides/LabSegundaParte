using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABSEGUNDAPARTE.Entidades
{
    class Persona
    {
        private String nombre;
        private int edad;
        private String sexo;
        private Double peso;
        private Double altura;
        private Double totalpeso;

        public Persona() { }

        public Persona(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public Persona(string nombre, int edad, string sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public Persona(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public override string ToString()
        {
            return "Nomnbre " + nombre +"Edad " + edad + "Sexo "+sexo + "Peso " + peso + "Altura " + altura;
        }
    }
}
