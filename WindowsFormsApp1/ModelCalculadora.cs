using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ModelCalculadora
    {
        public ModelCalculadora()
        {
            
        }//fim do metodo construtor

        public double Somar(double num1,double num2)
        {
            return num1 + num2;
        }//fim do somar

        public double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }//fim do subtrair

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }//fim do multiplicar

        public double Dividir(double num1, double num2)
        {
            if (num2 <= 0)
            {
                return -1;
            }
            else
            {
                return num1 / num2;
            }
        }//fim do dividir

        public double Potencia (double bas, double expoente)
        {
            if (expoente == 1)
            {
                return bas;
            }else if(expoente == 0)
            {
                return 1;
            }
            else
            {
                return Math.Pow(bas, expoente);
            }
        } // fim do potencia
        
        public double Raiz (double num1)
        {
            if (num1 <= 0)
            {
                return -1;
            }
            else
            {
                return Math.Sqrt(num1);
            }
        }// fim do raiz


    }//fim da classe

}//fim do projeto
