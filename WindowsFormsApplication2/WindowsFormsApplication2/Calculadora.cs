using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Calculadora
    {

        double primernumero;
        double segundonumero;



        // constructor
        public Calculadora()
        {
        }
        // constructor recibe parametrosd

        public Calculadora(double primernumero, double segundonumero)
        {
            this.primernumero = primernumero;
            this.segundonumero = segundonumero;
        }


        public double Primernumero
        {
            get { return primernumero; }
            set { primernumero = value; }
        }


        public double Segundonumero
        {
            get { return segundonumero; }
            set { segundonumero = value; }
        }

        public double Sumar(double primernumero, double segundonumero)
        {
            double resultado = primernumero + segundonumero;
            return resultado;

        }

        public double restar(double primernumero, double segundonumero)
        {
            double resultado = primernumero - segundonumero;
            return resultado;

        }

        public double dividir(double primernumero, double segundonumero)
        {
            double resultado = primernumero / segundonumero;
            return resultado;

        }
        public double multiplicar(double primernumero, double segundonumero)
        {
            double resultado = primernumero * segundonumero;
            return resultado;

        }
    }
}
