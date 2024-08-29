using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Coperativa miCoperativa;
        public Form1()
        {
            InitializeComponent();
        }

        private void btIniciarCoperativa_Click(object sender, EventArgs e)
        {
            string nombre = tbCoperativa.Text;
            miCoperativa = new Coperativa(nombre);
            tbCoperativa.Text = nombre;
            tbCoperativa.Enabled = false;
            btIniciarCoperativa.Enabled = false;
        }

        private void btCargaClientes_Click(object sender, EventArgs e)
        {
            fDatosCliente vCargar = new fDatosCliente();
            if (vCargar.ShowDialog() == DialogResult.OK)
            {
                string nombre = vCargar.tbNombre.Text;
                int dni = Convert.ToInt32(vCargar.tbDni.Text);
                int nroServicio = Convert.ToInt32(vCargar.tbNumeroServicio.Text);
                string direccion = vCargar.tbDireccion.Text;
                Medidor medidor = new Medidor();
                Cliente cliente = miCoperativa.AgregarCliente(nroServicio,dni,nombre,direccion,medidor);
                MessageBox.Show($"Numero de servicio: {cliente.NroServicio}. Cliente agregado");
            }
        }
    }
}
