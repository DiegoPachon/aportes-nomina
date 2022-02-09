using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recibo_de_nomina
{
    class NominaTrabajador
    {
        private double salario;

        public double Salario
        {
            get => salario;
            set => salario = value;
        }

        //Método para calcular la nómina

        public double Calcularsalariodiario(double salariom, int ndias)
        {
            double totalsalariodiario = salariom / ndias ;
            return totalsalariodiario;
        }
    }
}
