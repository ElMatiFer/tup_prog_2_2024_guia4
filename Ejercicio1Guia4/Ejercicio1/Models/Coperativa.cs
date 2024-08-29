using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Coperativa
    {
        public string Nombre { get; private set; }
        public Coperativa(string nombre)
        {
            this.Nombre = nombre;
        }
        public ArrayList clientes = new ArrayList();
        public Cliente AgregarCliente(int nro, int dni, string nombre, string direccion, Medidor medidor)
        {
            Cliente cliente = new Cliente(nro, nombre, dni, direccion, medidor);
            clientes.Add(cliente);
            return cliente;
        }
        public Cliente BuscarCliente(int nroServicio)
        {
            int izq = 0, der = clientes.Count - 1, med, pos = -1;

            Cliente obj = null;
            clientes.Sort();

            while (izq <= der && pos < 0)
            {
                med = (izq + der) / 2;

                if (((Cliente)clientes[med]).NroServicio == nroServicio)
                {
                    pos = med;
                }
                else
                {
                    if (nroServicio > ((Cliente)clientes[med]).NroServicio)
                    {
                        izq = med + 1;
                    }
                    else
                    {
                        der = med - 1;
                    }
                }
                if (pos != -1)
                {
                    obj = (Cliente)clientes[pos];
                }       
            }
            return obj;
        }
    }
}
