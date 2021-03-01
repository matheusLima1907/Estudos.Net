using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDePintura
{
    class Calculadora
    {
        //objetos necessarios para calculos
        private double areaParedes;
        private double areaTeto;
        
        //calcula área das paredes
        public double CalculaAreaParede(double largura, double profundidade, double altura)
        {
            areaParedes = 2 * (largura + profundidade) * altura;

            return areaParedes ;
        }

        //calcula área do teto
        public double CalculaAreaTeto(double largura, double profundidade)
        {
            areaTeto = (largura * profundidade);

            return areaTeto;
        }
        
        //calcula litragem da tinta
        public double CalculaLitragem()
        {
            return (areaParedes + areaTeto)/10;
        }

    }
}
