namespace GesReserv
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablaReservas = new System.Windows.Forms.DataGridView();
            this.btnSigMes = new System.Windows.Forms.Button();
            this.btnAntMes = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnNuevaReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaReservas
            // 
            this.tablaReservas.AllowUserToAddRows = false;
            this.tablaReservas.AllowUserToDeleteRows = false;
            this.tablaReservas.AllowUserToResizeColumns = false;
            this.tablaReservas.AllowUserToResizeRows = false;
            this.tablaReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaReservas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaReservas.Location = new System.Drawing.Point(12, 59);
            this.tablaReservas.Name = "tablaReservas";
            this.tablaReservas.RowTemplate.Height = 24;
            this.tablaReservas.Size = new System.Drawing.Size(776, 379);
            this.tablaReservas.TabIndex = 0;
            this.tablaReservas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaReservas_CellMouseClick);
            // 
            // btnSigMes
            // 
            this.btnSigMes.Location = new System.Drawing.Point(744, 13);
            this.btnSigMes.Name = "btnSigMes";
            this.btnSigMes.Size = new System.Drawing.Size(44, 40);
            this.btnSigMes.TabIndex = 1;
            this.btnSigMes.Text = ">";
            this.btnSigMes.UseVisualStyleBackColor = true;
            this.btnSigMes.Click += new System.EventHandler(this.btnSigMes_Click);
            // 
            // btnAntMes
            // 
            this.btnAntMes.Location = new System.Drawing.Point(186, 12);
            this.btnAntMes.Name = "btnAntMes";
            this.btnAntMes.Size = new System.Drawing.Size(44, 40);
            this.btnAntMes.TabIndex = 2;
            this.btnAntMes.Text = "<";
            this.btnAntMes.UseVisualStyleBackColor = true;
            this.btnAntMes.Click += new System.EventHandler(this.btnAntMes_Click);
            // 
            // btnMes
            // 
            this.btnMes.Location = new System.Drawing.Point(236, 12);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(502, 40);
            this.btnMes.TabIndex = 3;
            this.btnMes.Text = "Mes";
            this.btnMes.UseVisualStyleBackColor = true;
            // 
            // btnNuevaReserva
            // 
            this.btnNuevaReserva.Location = new System.Drawing.Point(12, 12);
            this.btnNuevaReserva.Name = "btnNuevaReserva";
            this.btnNuevaReserva.Size = new System.Drawing.Size(168, 40);
            this.btnNuevaReserva.TabIndex = 4;
            this.btnNuevaReserva.Text = "Nueva Reserva";
            this.btnNuevaReserva.UseVisualStyleBackColor = true;
            this.btnNuevaReserva.Click += new System.EventHandler(this.btnNuevaReserva_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevaReserva);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.btnAntMes);
            this.Controls.Add(this.btnSigMes);
            this.Controls.Add(this.tablaReservas);
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "GesReserv";
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaReservas;
        private System.Windows.Forms.Button btnSigMes;
        private System.Windows.Forms.Button btnAntMes;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnNuevaReserva;
    }
}

