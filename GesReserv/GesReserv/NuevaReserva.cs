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
    public partial class NuevaReserva : Form
    {
        ConexionBBDD conexionBBDD;
        VentanaPrincipal ventanaPrincipal;

        public NuevaReserva(VentanaPrincipal _ventanaPrincipal)
        {
            InitializeComponent();
            ventanaPrincipal = _ventanaPrincipal;
            conexionBBDD = ventanaPrincipal.conexionBBDD;
            for (int i = 0; i < ventanaPrincipal.datosHabitaciones.Rows.Count; i++)
            {
                cbHabitacion.Items.Add(ventanaPrincipal.datosHabitaciones.Rows[i][0]);
            }
            for (int i = 0; i < ventanaPrincipal.datosClientes.Rows.Count; i++)
            {
                cbCliente.Items.Add(ventanaPrincipal.datosClientes.Rows[i][0]);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            TimeSpan ts = dtpFechaSalida.Value.Date - dtpFechaEntrada.Value.Date;

            DateTime tAux = dtpFechaEntrada.Value.Date;
            bool hOcupada = false;

            //Console.WriteLine(ts.Days); // Consola - Comprueba el número de días de la reserva.

            for (int i = 0; i < ts.Days; i++)
            {
                String tString = tAux.ToString("yyyy-MM-dd");
                if (!hOcupada)
                {
                    if (conexionBBDD.cargaDatos("select * from gesreserv.reservas where n_habitacion = '" + cbHabitacion.Text + "' and '" + tString + "' between fecha_entrada and fecha_salida;").Rows.Count > 0)
                    {
                        hOcupada = true;
                    }
                }

                tAux = tAux.AddDays(1);
                //Console.WriteLine(tString); // Consola - Comprueba la fecha enviada mediante la querry.
            }

            if (!hOcupada)
            {
                try
                {
                    conexionBBDD.insertaDatosReserva(dtpFechaEntrada.Value.Date, dtpFechaSalida.Value.Date, cbCliente.Text, cbHabitacion.Text);
                    MessageBox.Show("Reserva añadida correctamnte.", "Reserva añadida");
                    ventanaPrincipal.mes = dtpFechaEntrada.Value.Month;
                    ventanaPrincipal.cargaBBDD();
                    ventanaPrincipal.cargaValores();
                    ventanaPrincipal.cargaColores();
                    ventanaPrincipal.cargaHabitaciones();
                    ventanaPrincipal.Enabled = true;
                    this.Dispose();
                }
                catch
                {
                    MessageBox.Show("Error al añadir la reserva.", "Error al añadir la reserva");
                }
            }
            else
            {
                MessageBox.Show("La habitación enstá ocupada en esta fecha.", "Habitación ocupada");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ventanaPrincipal.Enabled = true;
            this.Dispose();
        }

        //Método de establecimiento de acción en cierre.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            ventanaPrincipal.Enabled = true;
        }
    }
}
