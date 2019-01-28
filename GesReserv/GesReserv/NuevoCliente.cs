using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesReserv
{
    public partial class NuevoCliente : Form
    {
        ConexionBBDD conexionBBDD;
        VentanaPrincipal ventanaPrincipal;
        public NuevoCliente(VentanaPrincipal _ventanaPrincipal)
        {
            InitializeComponent();
            ventanaPrincipal = _ventanaPrincipal;
            conexionBBDD = ventanaPrincipal.conexionBBDD;
        }

        //Método de establecimiento de acción en cierre.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            ventanaPrincipal.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.Enabled = true;
            this.Dispose();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                conexionBBDD.insertaDatosCliente(tbDNI.Text, tbNombre.Text, tbTelefono.Text);
                MessageBox.Show("Cliente añadido correctamnte.", "Cliente añadido");
                ventanaPrincipal.cargaBBDD();
                ventanaPrincipal.cargaValores();
                ventanaPrincipal.cargaColores();
                ventanaPrincipal.cargaHabitaciones();
                ventanaPrincipal.Enabled = true;
                this.Dispose();
            }
            catch
            {
                MessageBox.Show("Error al añadir el cliente.", "Error al añadir el cliente");
            }
        }
    }
}
