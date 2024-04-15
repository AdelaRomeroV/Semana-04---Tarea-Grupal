using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Paises
{
    internal class Pais
    {
        public float impuestos;
        public float poblacion;
        public float dinero;
        public float salud;
        public float educacion;
        public float seguridad;
        public float felicidad;
        public float gastos;

        protected string NombreNivel;

        public virtual void CalculateFactor()
        {            
        }

        public virtual void Healt(float a)
        {           
        }

        public virtual void Education(float a)
        {
        }

        public virtual void Security(float a)
        {
        }

    }
}
