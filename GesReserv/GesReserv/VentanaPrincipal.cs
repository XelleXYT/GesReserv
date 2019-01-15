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
    public partial class VentanaPrincipal : Form
    {
        public DataTable datosClientes = new DataTable();
        public DataTable datosHabitaciones = new DataTable();
        public DataTable datosReservas = new DataTable();
        public DataTable[] calendario = new DataTable[13];
        public ConexionBBDD conexionBBDD;
        private int mes = 1;
        private int anno = 2019;

        public VentanaPrincipal()
        {
            InitializeComponent();
            cargaBBDD();
            tablaReservas.DataSource = calendario[mes];

            cargaValores();

            //cargaColores();

            btnMes.Text = dimeMes(mes) + " - " + anno.ToString();
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
            for (int i = 1; i <= 12; i++)
            {
                calendario[i] = new DataTable();
                calendario[i].Columns.Add("Habitacion", typeof(String));
                for (int j = 1; j <= DateTime.DaysInMonth(anno, i); j++)
                {
                    calendario[i].Columns.Add(j.ToString(), typeof(String));
                }
                foreach (DataRow rowHabitaciones in datosHabitaciones.Rows)
                {
                    calendario[i].Rows.Add(rowHabitaciones.Field<int>(0));
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
                    for (int j = 0; j < calendario[fechaAux.Month].Rows.Count; j++) // Por cada habitación.
                    {
                        int hCalendario = Convert.ToInt32(calendario[fechaAux.Month].Rows[j][0].ToString()); // Habitación del calendario.
                        if (hReserva == hCalendario) // Si coinciden la habitación de la reserva y la del calendario.
                        {
                            calendario[fechaAux.Month].Rows[j][fechaAux.Day] = "X"; // Pon una X en la celda del calendario, haciendo coincidir el día y habitación de la reserva.
                        }
                    }

                    fechaAux = fechaAux.AddDays(1); // Incrementa en un día la fecha Auxiliar.
                    //Console.WriteLine(fechaAux.Date); // Consola - Comprueba el incremento de fecha de fechaAux.
                }
            }

            cargaColores();

            tablaReservas.DataSource = calendario[mes];
        }



        // cargaColores - Se encarga de cambiar el color y el texto de las celdas reservadas.
        public void cargaColores()
        {
            for (int col = 0; col < tablaReservas.ColumnCount; col++)
            {
                for (int row = 0; row < tablaReservas.RowCount; row++)
                {
                    if (Convert.ToString(tablaReservas[col, row].Value).Equals("X"))
                    {
                        //Console.WriteLine("Cell"); // Consola - Comprueba que exista una celda con "X" como contenido.
                        DataGridViewCellStyle newCellStyle = new DataGridViewCellStyle();
                        newCellStyle.BackColor = Color.Red;
                        //tablaReservas.Rows[row].Cells[col].Value = "Reservado";
                        tablaReservas.Rows[row].Cells[col].Style = newCellStyle;
                    }
                }
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

        // 

        private void btnSigMes_Click(object sender, EventArgs e)
        {
            if (mes < 12)
            {
                mes++;
                tablaReservas.DataSource = calendario[mes];
                btnMes.Text = dimeMes(mes) + " - " + anno.ToString();
            }
        }

        private void btnAntMes_Click(object sender, EventArgs e)
        {
            if (mes > 1)
            {
                mes--;
                tablaReservas.DataSource = calendario[mes];
                btnMes.Text = (dimeMes(mes) + " - " + anno.ToString());
            }
        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {
            NuevaReserva nr = new NuevaReserva(this);
            nr.Show();
        }

        private void tablaReservas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NuevaReserva nr = new NuevaReserva(this);
            nr.Show();
        }
    }


}
