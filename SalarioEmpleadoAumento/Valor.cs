using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalarioEmpleadoAumento
{
    public class Valor
    {
        private double salario;
        private string antiguedad; 

        public void setSalario(double valor)
        {
            this.salario = valor; 
        }

        public void setAntiguedad(string anti)
        {
            this.antiguedad = anti; 
        }

        public double getSalario()
        {
            return salario; 
        }

        public string getAntiguedad()
        {
            return antiguedad;
        }
    }
}
