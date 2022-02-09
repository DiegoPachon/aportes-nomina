using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recibo_de_nomina
{
    class Empleado
    {
        int dias;
        string nombres;
        string apellidos;
        double identificacion;

        public int Dias
        {
            get => dias;
            set => dias = value;
        }
        public string Nombres
        {
            get => nombres;
            set => nombres = value;
        }
        public string Apellidos
        {
            get => apellidos;
            set => apellidos = value;
        }
        public double Identificacion
        {
            get => identificacion;
            set => identificacion = value;
        }
    }
}
