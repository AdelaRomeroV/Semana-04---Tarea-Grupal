using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Paises
{
    internal class PaisDesarrollo: Pais
    {
        public PaisDesarrollo(string name, float poblacion, float dinero, float salud, float educacion, float seguridad, float felicidad, float gastos, float impuestos)
        {
            this.NombreNivel = name;
            this.poblacion = poblacion;
            this.dinero = dinero;
            this.salud = salud;
            this.educacion = educacion;
            this.seguridad = seguridad;
            this.felicidad = felicidad;
            this.gastos = gastos;
            this.impuestos = impuestos;
        }
        public override void Healt(float a)

        {
            if (a != 0)
            {
                salud = a;
            }
            if (salud < 60)
            {
                poblacion--;
            }
            else if (salud >= 60)
            {
                poblacion++;
            }
        }

        public override void Education(float a)
        {
            if (a != 0)
            {
                educacion = a;
            }
            dinero = dinero - educacion;
        }

        public override void Security(float a)
        {
            if (a != 0)
            {
                seguridad = a;
            }
            if (seguridad < 60)
            {
                felicidad--;
            }
            else if (salud >= 60)
            {
                felicidad++;
            }
        }
        public override void CalculateFactor()
        {
            gastos = salud + educacion + seguridad;
            dinero = (dinero + impuestos) - gastos;
        }
    }
}
