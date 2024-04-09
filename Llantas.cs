using Polimorfismo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIMORFISMO
{
    internal class Llantas : Carro
    {

        //Atributo
        public double radio { get; set; }

        //Contructor
        public Llantas(string c, double r)
        {
            color = c;
            this.radio = r;
        }
        //Método
        public string MostrarArea()
        {
            string datos;
            double area = Math.PI * Math.Pow(radio, 2);
            datos = "El area de la llanta es:  " + area + Environment.NewLine;
            return datos;
        }
        public string MostrarColor()
        {
            string datos;
            datos ="El color de la llantas es :"+ color+ Environment.NewLine;
            return datos;
        }
    }
}

