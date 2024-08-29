using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Medidor
    {
        public double LecturaAnterior { get; private set; }
        public double LecturaActual { get; private set; }
        
        public Medidor() 
        {
            
        }
        public double ConsumoActual()
        {
            return LecturaActual - LecturaAnterior;
        }
        public void Medicion(double lectura)
        {
            LecturaAnterior = LecturaActual;
            LecturaActual = lectura;
        }
    }
}
