
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcularAreaFormas.POO
{
    public class Formas
    {
        public double BaseObjeto { get; set; }
        public double Altura { get; set; }
        public double Raio { get; set; }
        public double DiagonalMaior { get; set; }
        public double DiagonalMenor { get; set; }
        public double BaseMaior { get; set; }
        public double BaseMenor { get; set; }
        private double _resultado;
        public double Resultado
        {
            get { return this._resultado; }
            set
            {
                if (value >= 0)
                {
                    this._resultado = value;
                }
                else
                {
                    this._resultado = 0;
                }
            }
        }
        private double _perimetro;

        public double Perimetro
        {
            get { return this._perimetro; }
            set
            {
                if (value >= 0)
                {
                    this._perimetro = value;
                }
                else
                {
                    this._perimetro = 0;
                }

            }
        }
        private double _lado;
        public double Lado
        {
            get { return this._lado; }
            set
            {
                if (value >= 0)
                {
                    this._lado = value;
                }
                else
                {
                    this._lado = 0;
                }

            }
        }
    }
}
