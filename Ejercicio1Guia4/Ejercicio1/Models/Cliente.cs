using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Cliente:IComparable
    {
        public Medidor Medidor { get; set; }
        public string Nombre { get; private set; }
        public string Direccion { get; private set; }
        public int Dni { get; private set; }
        public int NroServicio { get; private set; }
        ArrayList consumos = new ArrayList();
        private int CantidadConsumos 
        {
            get
            {
                return consumos.Count;
            }
        }

        private int periodoActual;
        public int PeriodoActual
        {
            get { return periodoActual; }
            private set
            {
                if (CantidadConsumos == 8)
                    consumos.RemoveAt(0);
                periodoActual = value % 6;
            }

        }
        public Cliente(int nro, string nombre, int dni, string direccion, Medidor medidor)
        {
            this.NroServicio = nro;
            this.Nombre = nombre;
            this.Dni = dni;
            this.Direccion = direccion;
            this.Medidor = medidor;
        }
        public void RegistrarConsumo(double medicion)
        {
            PeriodoActual++;
            Medidor.Medicion(medicion);
            consumos.Add(Medidor.ConsumoActual());
        }
        public int CompareTo(object obj)
        {
            int result = 0;
            if (obj != null && obj is Cliente)
            {
                Cliente obj1 = (Cliente)obj;
                result = NroServicio.CompareTo(obj1.NroServicio);
            }
            return result;
        }
        public double LeerConsumo(int pos)
        {
            return (double)consumos[pos];
        }
    }
}
