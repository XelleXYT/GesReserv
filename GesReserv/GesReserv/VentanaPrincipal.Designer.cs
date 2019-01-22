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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.tablaReservas = new System.Windows.Forms.DataGridView();
            this.btnSigMes = new System.Windows.Forms.Button();
            this.btnAntMes = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnNuevaReserva = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.lNApp = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaReservas
            // 
            this.tablaReservas.AllowUserToAddRows = false;
            this.tablaReservas.AllowUserToDeleteRows = false;
            this.tablaReservas.AllowUserToResizeColumns = false;
            this.tablaReservas.AllowUserToResizeRows = false;
            this.tablaReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaReservas.ColumnHeadersHeight = 25;
            this.tablaReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaReservas.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaReservas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaReservas.Location = new System.Drawing.Point(12, 114);
            this.tablaReservas.MultiSelect = false;
            this.tablaReservas.Name = "tablaReservas";
            this.tablaReservas.RowHeadersWidth = 60;
            this.tablaReservas.RowTemplate.Height = 24;
            this.tablaReservas.Size = new System.Drawing.Size(776, 324);
            this.tablaReservas.TabIndex = 0;
            this.tablaReservas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaReservas_CellMouseDoubleClick);
            // 
            // btnSigMes
            // 
            this.btnSigMes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSigMes.Location = new System.Drawing.Point(744, 68);
            this.btnSigMes.Name = "btnSigMes";
            this.btnSigMes.Size = new System.Drawing.Size(44, 40);
            this.btnSigMes.TabIndex = 1;
            this.btnSigMes.Text = ">";
            this.btnSigMes.UseVisualStyleBackColor = true;
            this.btnSigMes.Click += new System.EventHandler(this.btnSigMes_Click);
            // 
            // btnAntMes
            // 
            this.btnAntMes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAntMes.Location = new System.Drawing.Point(12, 68);
            this.btnAntMes.Name = "btnAntMes";
            this.btnAntMes.Size = new System.Drawing.Size(44, 40);
            this.btnAntMes.TabIndex = 2;
            this.btnAntMes.Text = "<";
            this.btnAntMes.UseVisualStyleBackColor = true;
            this.btnAntMes.Click += new System.EventHandler(this.btnAntMes_Click);
            // 
            // btnMes
            // 
            this.btnMes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMes.Location = new System.Drawing.Point(62, 68);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(676, 40);
            this.btnMes.TabIndex = 3;
            this.btnMes.Text = "Mes";
            this.btnMes.UseVisualStyleBackColor = true;
            // 
            // btnNuevaReserva
            // 
            this.btnNuevaReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaReserva.Location = new System.Drawing.Point(620, 12);
            this.btnNuevaReserva.Name = "btnNuevaReserva";
            this.btnNuevaReserva.Size = new System.Drawing.Size(168, 40);
            this.btnNuevaReserva.TabIndex = 4;
            this.btnNuevaReserva.Text = "Nueva Reserva";
            this.btnNuevaReserva.UseVisualStyleBackColor = true;
            this.btnNuevaReserva.Click += new System.EventHandler(this.btnNuevaReserva_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(12, 12);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(168, 40);
            this.btnNuevoCliente.TabIndex = 5;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // lNApp
            // 
            this.lNApp.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.lNApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNApp.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNApp.LinkColor = System.Drawing.Color.Black;
            this.lNApp.Location = new System.Drawing.Point(186, 12);
            this.lNApp.Name = "lNApp";
            this.lNApp.Size = new System.Drawing.Size(428, 40);
            this.lNApp.TabIndex = 6;
            this.lNApp.TabStop = true;
            this.lNApp.Text = "GesReserv";
            this.lNApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lNApp.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lNApp);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnNuevaReserva);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.btnAntMes);
            this.Controls.Add(this.btnSigMes);
            this.Controls.Add(this.tablaReservas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "GesReserv";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaReservas;
        private System.Windows.Forms.Button btnSigMes;
        private System.Windows.Forms.Button btnAntMes;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnNuevaReserva;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.LinkLabel lNApp;
    }
}

