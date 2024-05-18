using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormstrabajo2
{
    public class Jefe
    {
        public string Nombres { get; set; }
        public string Dni { get; set; }
        public string Cargo { get; set; } // gerente, subgerente
        public string Area { get; set; } // contabilidad, planificación
        public int AnosAntiguedad { get; set; }

        public Jefe(string nombres, string dni, string cargo, string area, int anosAntiguedad)
        {
            Nombres = nombres;
            Dni = dni;
            Cargo = cargo;
            Area = area;
            AnosAntiguedad = anosAntiguedad;
        }

        public double CalcularSueldoBase()
        {
            double sueldoBase = 0;
            if (Cargo == "Gerente")
            {
                sueldoBase = Area == "Contabilidad" ? 6000 : 7000;
            }
            else if (Cargo == "Subgerente")
            {
                sueldoBase = Area == "Contabilidad" ? 5000 : 6000;
            }
            return sueldoBase;
        }

        public double AsignarMontoMovilidad()
        {
            return Cargo == "gerente" ? 700 : 400;
        }

        public double CalcularBonificacion()
        {
            return AnosAntiguedad <= 7 ? CalcularSueldoBase() * 0.05 : CalcularSueldoBase() * 0.04;
        }

        public double CalcularSueldoFinal()
        {
            return CalcularSueldoBase() + CalcularBonificacion() + AsignarMontoMovilidad();
        }
    }
}
