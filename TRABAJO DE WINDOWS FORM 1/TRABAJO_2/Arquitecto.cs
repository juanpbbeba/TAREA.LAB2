using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJO_2
{
    public class Arquitecto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string CondicionContrato { get; set; } // estable, contratado
        public string Especialidad { get; set; } // estructuras, recursos hídricos
        public string TipoActividad { get; set; } // supervisión de obras, supervisión de vías
        public string TipoAfiliado { get; set; } // AFP, SNP

        public Arquitecto(string codigo, string nombre, string condicionContrato, string especialidad, string tipoActividad, string tipoAfiliado)
        {
            Codigo = codigo;
            Nombre = nombre;
            CondicionContrato = condicionContrato;
            Especialidad = especialidad;
            TipoActividad = tipoActividad;
            TipoAfiliado = tipoAfiliado;
        }

        public double CalcularSueldoBase()
        {
            double sueldoBase = 0;

            if (CondicionContrato == "estable")
            {
                sueldoBase = TipoActividad == "supervisión de obras" ? 4000 : 6000;
            }
            else if (CondicionContrato == "contratado")
            {
                sueldoBase = TipoActividad == "supervisión de obras" ? 2000 : 4500;
            }

            return sueldoBase;
        }

        public double CalcularBonificacion()
        {
            double sueldoBase = CalcularSueldoBase();
            double bonificacion = Especialidad == "estructuras" ? sueldoBase * 0.16 : sueldoBase * 0.18;

            return bonificacion;
        }

        public double CalcularDescuento()
        {
            double sueldoBase = CalcularSueldoBase();
            double descuento = TipoAfiliado == "AFP" ? sueldoBase * 0.15 : sueldoBase * 0.08;

            return descuento;
        }

        public double CalcularSueldoNeto()
        {
            double sueldoBase = CalcularSueldoBase();
            double bonificacion = CalcularBonificacion();
            double descuento = CalcularDescuento();

            double sueldoNeto = sueldoBase + bonificacion - descuento;

            return sueldoNeto;
        }

        public double CalcularSueldoBruto()
        {
            double sueldoBase = CalcularSueldoBase();
            double bonificacion = CalcularBonificacion();

            double sueldoBruto = sueldoBase + bonificacion;

            return sueldoBruto;
        }
    }
}
