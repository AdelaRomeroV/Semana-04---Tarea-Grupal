using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Paises
{
    internal class Pais
    {
        float impuestos;
        float poblacion;
        float dinero;
        float salud;
        float educacion;
        float seguridad;
        float felicidad;
        float gastos;

        string NombreNivel;

        public Pais (float impuestos, float poblacion, float dinero, float salud, float educacion, float seguridad, float felicidad, float gatos )
        {
            this.impuestos = impuestos; 
            this.poblacion = poblacion;
            this.dinero = dinero;
            this.salud = salud;
            this.educacion = educacion;
            this.seguridad = seguridad;
            this.felicidad = felicidad;
            this.gastos = gatos;

        }

        public void CalculateFactor()
        {

        }

        public void Healt()
        {

        }

        public void Education()
        {

        }

        public void Security()
        {

        }

    }
}
