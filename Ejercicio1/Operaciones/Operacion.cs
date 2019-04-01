using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Operacion
    {
        private double valor1, valor2, resultado;

        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public double Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }

        public double Valor1
        {
            get { return valor1; }
            set { valor1 = value; }
        }

        public Operacion()    
        {
        this.valor1=0;
        this.valor2=0;
        }
        public double Suma()
        {
            resultado = (valor1 + valor2);
            return resultado;
        }
        public double Resta()
        {
            resultado = valor1 - valor2;
            return resultado;
        }
        public double Multiplicacion()
        {
            resultado = valor1 * valor2;
            return resultado;
        }
        public double Division()
        {
            resultado = valor1 / valor2;
            return resultado;
        }
    }
}
