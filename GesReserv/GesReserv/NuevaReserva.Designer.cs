namespace GesReserv
{
    partial class NuevaReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaReserva));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lHabitacion = new System.Windows.Forms.Label();
            this.lCliente = new System.Windows.Forms.Label();
            this.lFechaEntrada = new System.Windows.Forms.Label();
            this.lFechaSalida = new System.Windows.Forms.Label();
            this.cbHabitacion = new System.Windows.Forms.ComboBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Location = new System.Drawing.Point(123, 64);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(272, 22);
            this.dtpFechaEntrada.TabIndex = 2;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Checked = false;
            this.dtpFechaSalida.Location = new System.Drawing.Point(123, 105);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(272, 22);
            this.dtpFechaSalida.TabIndex = 3;
            // 
            // lHabitacion
            // 
            this.lHabitacion.AutoSize = true;
            this.lHabitacion.Location = new System.Drawing.Point(38, 27);
            this.lHabitacion.Name = "lHabitacion";
            this.lHabitacion.Size = new System.Drawing.Size(79, 17);
            this.lHabitacion.TabIndex = 4;
            this.lHabitacion.Text = "Habitación:";
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.Location = new System.Drawing.Point(62, 148);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(55, 17);
            this.lCliente.TabIndex = 5;
            this.lCliente.Text = "Cliente:";
            // 
            // lFechaEntrada
            // 
            this.lFechaEntrada.AutoSize = true;
            this.lFechaEntrada.Location = new System.Drawing.Point(12, 69);
            this.lFechaEntrada.Name = "lFechaEntrada";
            this.lFechaEntrada.Size = new System.Drawing.Size(105, 17);
            this.lFechaEntrada.TabIndex = 6;
            this.lFechaEntrada.Text = "Fecha Entrada:";
            // 
            // lFechaSalida
            // 
            this.lFechaSalida.AutoSize = true;
            this.lFechaSalida.Location = new System.Drawing.Point(23, 110);
            this.lFechaSalida.Name = "lFechaSalida";
            this.lFechaSalida.Size = new System.Drawing.Size(94, 17);
            this.lFechaSalida.TabIndex = 7;
            this.lFechaSalida.Text = "Fecha Salida:";
            // 
            // cbHabitacion
            // 
            this.cbHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHabitacion.FormattingEnabled = true;
            this.cbHabitacion.Location = new System.Drawing.Point(123, 24);
            this.cbHabitacion.Name = "cbHabitacion";
            this.cbHabitacion.Size = new System.Drawing.Size(272, 24);
            this.cbHabitacion.TabIndex = 8;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(320, 184);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 32);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(12, 184);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 32);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(123, 145);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(272, 24);
            this.cbCliente.TabIndex = 10;
            // 
            // NuevaReserva
            // 
            this.AcceptButton = this.btnEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(407, 228);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.cbHabitacion);
            this.Controls.Add(this.lFechaSalida);
            this.Controls.Add(this.lFechaEntrada);
            this.Controls.Add(this.lCliente);
            this.Controls.Add(this.lHabitacion);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.dtpFechaEntrada);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevaReserva";
            this.Text = "Nueva Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label lHabitacion;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.Label lFechaEntrada;
        private System.Windows.Forms.Label lFechaSalida;
        private System.Windows.Forms.ComboBox cbHabitacion;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbCliente;
    }
}