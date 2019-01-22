using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace GesReserv
{
    public partial class VentanaPrincipal : Form
    {
        public DataTable datosClientes = new DataTable();
        public DataTable datosHabitaciones = new DataTable();
        public DataTable datosReservas = new DataTable();
        public DataTable[,] calendario = new DataTable[3000, 13];
        public ConexionBBDD conexionBBDD;
        public int mes = DateTime.Now.Month;
        private int anno = DateTime.Now.Year;
        private bool sync = false;

        public VentanaPrincipal()
        {
            InitializeComponent();
            cargaBBDD();
            cargaValores();
            tablaReservas.DataSource = calendario[anno, mes];
            //cargaColores();
            //cargaHabitaciones();

            /*
            // Nuevo hilo de ejecución que permite cargar los colores de las casillas una vez ha terminado de arrancar el programa. - Innecesario.
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Thread.Sleep(10000); // Espera 1 segundo.
                cargaColores();
                cargaHabitaciones();
            }).Start();
            */
        }

        // cargaBBDD - Se encarga de cargar los datos de la base de datos en variables de instancia.
        public void cargaBBDD()
        {

            conexionBBDD = new ConexionBBDD();
            datosClientes = conexionBBDD.cargaDatos("Select * from clientes");
            datosHabitaciones = conexionBBDD.cargaDatos("Select * from habitaciones");
            datosReservas = conexionBBDD.cargaDatos("Select * from reservas");
        }

        // cargaValores - Se encarga de crear y mostrar el calendario.
        public void cargaValores()
        {
            for (int year = 2000; year < 2100; year++)
            {

                for (int i = 1; i <= 12; i++)
                {
                    calendario[year, i] = new DataTable();

                    calendario[year, i].Columns.Add("Habitacion", typeof(String));
                    for (int j = 1; j <= DateTime.DaysInMonth(year, i); j++)
                    {
                        calendario[year, i].Columns.Add(j.ToString(), typeof(String));
                    }

                    foreach (DataRow rowHabitaciones in datosHabitaciones.Rows)
                    {
                        calendario[year, i].Rows.Add(rowHabitaciones.Field<int>(0));
                    }
                }
            }
            foreach (DataRow rowReservas in datosReservas.Rows)
            {

                DateTime fechaEntrada = rowReservas.Field<DateTime>(1);
                DateTime fechaSalida = rowReservas.Field<DateTime>(2);

                TimeSpan ts = fechaSalida - fechaEntrada;
                //Console.WriteLine(ts.Days);

                DateTime fechaAux = fechaEntrada; // Crea e iguala la variable fechaAux a fechaEntrada.

                for (int i = 0; i <= ts.Days; i++) // Por el número de dias de la reserva.
                {
                    int hReserva = rowReservas.Field<int>(4); // Habitación de la reserva.
                    //Console.WriteLine(calendario[fechaAux.Month].Rows.Count); // Consola - Comprueba el número de habitaciones que hay cada mes.
                    for (int j = 0; j < calendario[fechaAux.Year, fechaAux.Month].Rows.Count; j++) // Por cada habitación.
                    {
                        int hCalendario = Convert.ToInt32(calendario[fechaAux.Year, fechaAux.Month].Rows[j][0].ToString()); // Habitación del calendario.
                        if (hReserva == hCalendario) // Si coinciden la habitación de la reserva y la del calendario.
                        {
                            calendario[fechaAux.Year, fechaAux.Month].Rows[j][fechaAux.Day] = "X"; // Pon una X en la celda del calendario, haciendo coincidir el día y habitación de la reserva.
                        }
                    }

                    fechaAux = fechaAux.AddDays(1); // Incrementa en un día la fecha Auxiliar.
                    //Console.WriteLine(fechaAux.Date); // Consola - Comprueba el incremento de fecha de fechaAux.
                }
            }



            tablaReservas.DataSource = calendario[anno, mes];
            btnMes.Text = dimeMes(mes) + " - " + anno.ToString();
        }

        // cargaHabitaciones - Se encarga de cargar los títulos de las líneas del calendario.

        public void cargaHabitaciones()
        {
            for (int row = 0; row < tablaReservas.RowCount; row++)
            {
                tablaReservas.Rows[row].HeaderCell.Value = tablaReservas.Rows[row].Cells[0].Value.ToString();
            }
        }


        // cargaColores - Se encarga de cambiar el color y el texto de las celdas reservadas.
        public void cargaColores()
        {
            tablaReservas.ClearSelection();
            foreach (DataGridViewRow row in tablaReservas.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.Equals("X"))
                    {
                        //Console.WriteLine("Celda Roja");
                        cell.Style.ForeColor = Color.LightCoral;
                        cell.Style.BackColor = Color.LightCoral;
                    }
                    else if (cell.Value.ToString() == "")
                    {
                        cell.Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.LightYellow;
                    }
                }
            }
        }

        // cargaDimensiones - Se encarga de cargar las dimensiones de las columnas.
        public void cargaDimensiones()
        {
            tablaReservas.Columns[0].Visible = false;

            for (int i = 1; i < tablaReservas.ColumnCount; i++)
            {
                tablaReservas.Columns[i].Width = 30;
            }
        }

        // dimeMes - Se encarga de devolver el nombre del mes pasandole el número.
        private String dimeMes(int nMes)
        {
            switch (nMes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    return nMes.ToString();
            }
        }

        private void cargaEnClick()
        {
            tablaReservas.DataSource = calendario[anno, mes];
            btnMes.Text = dimeMes(mes) + " - " + anno.ToString();
            cargaColores();
            cargaHabitaciones();
            cargaDimensiones();
        }

        // 

        private void btnSigMes_Click(object sender, EventArgs e)
        {
            if (mes < 12)
            {
                mes++;
                cargaEnClick();
            }
            if (mes == 12)
            {
                if (anno < 2099 && anno > 2000)
                {
                    mes = 1;
                    anno++;
                    cargaEnClick();
                }
            }
        }

        private void btnAntMes_Click(object sender, EventArgs e)
        {
            if (mes > 1)
            {
                mes--;
                cargaEnClick();
            }
            if (mes == 1)
            {
                if (anno < 2099 && anno > 2000)
                {
                    anno--;
                    mes = 12;
                    cargaEnClick();
                }
            }
        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {
            NuevaReserva nr = new NuevaReserva(this);
            nr.Show();
            tablaReservas.ClearSelection();
            this.Enabled = false;
        }

        private void tablaReservas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NuevaReserva nr = new NuevaReserva(this);
            nr.Show();
            tablaReservas.ClearSelection();
            this.Enabled = false;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente nc = new NuevoCliente(this);
            nc.Show();
            tablaReservas.ClearSelection();
            this.Enabled = false;
        }

        // VentanaPrincipal_Load - Ejecuta el método al terminar de cargar la solución.
        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            cargaEnClick();
        }
    }


}
