namespace Control_Ordenes_Trabajo
{
    partial class VentanaFinalizadas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridOrdenes = new System.Windows.Forms.DataGridView();
            this.datePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.datePickerFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxFecha = new System.Windows.Forms.CheckBox();
            this.picturBox = new System.Windows.Forms.PictureBox();
            this.btnProceso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nombre de equipo";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(42, 51);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(204, 20);
            this.txtBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(74, 187);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridOrdenes
            // 
            this.dataGridOrdenes.AllowUserToAddRows = false;
            this.dataGridOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrdenes.Location = new System.Drawing.Point(277, 22);
            this.dataGridOrdenes.Name = "dataGridOrdenes";
            this.dataGridOrdenes.ReadOnly = true;
            this.dataGridOrdenes.Size = new System.Drawing.Size(487, 150);
            this.dataGridOrdenes.TabIndex = 3;
            this.dataGridOrdenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrdenes_CellClick);
            // 
            // datePickerInicio
            // 
            this.datePickerInicio.Enabled = false;
            this.datePickerInicio.Location = new System.Drawing.Point(42, 116);
            this.datePickerInicio.Name = "datePickerInicio";
            this.datePickerInicio.Size = new System.Drawing.Size(204, 20);
            this.datePickerInicio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "De";
            // 
            // datePickerFin
            // 
            this.datePickerFin.Enabled = false;
            this.datePickerFin.Location = new System.Drawing.Point(42, 152);
            this.datePickerFin.Name = "datePickerFin";
            this.datePickerFin.Size = new System.Drawing.Size(204, 20);
            this.datePickerFin.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "A";
            // 
            // checkBoxFecha
            // 
            this.checkBoxFecha.AutoSize = true;
            this.checkBoxFecha.Location = new System.Drawing.Point(91, 77);
            this.checkBoxFecha.Name = "checkBoxFecha";
            this.checkBoxFecha.Size = new System.Drawing.Size(99, 17);
            this.checkBoxFecha.TabIndex = 10;
            this.checkBoxFecha.Text = "Filtrar por fecha";
            this.checkBoxFecha.UseVisualStyleBackColor = true;
            this.checkBoxFecha.CheckedChanged += new System.EventHandler(this.checkBoxFecha_CheckedChanged);
            // 
            // picturBox
            // 
            this.picturBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturBox.Location = new System.Drawing.Point(373, 187);
            this.picturBox.Name = "picturBox";
            this.picturBox.Size = new System.Drawing.Size(300, 225);
            this.picturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturBox.TabIndex = 11;
            this.picturBox.TabStop = false;
            // 
            // btnProceso
            // 
            this.btnProceso.Location = new System.Drawing.Point(74, 241);
            this.btnProceso.Name = "btnProceso";
            this.btnProceso.Size = new System.Drawing.Size(144, 23);
            this.btnProceso.TabIndex = 12;
            this.btnProceso.Text = "Poner en progreso";
            this.btnProceso.UseVisualStyleBackColor = true;
            this.btnProceso.Click += new System.EventHandler(this.btnProceso_Click);
            // 
            // VentanaFinalizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProceso);
            this.Controls.Add(this.picturBox);
            this.Controls.Add(this.checkBoxFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePickerFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePickerInicio);
            this.Controls.Add(this.dataGridOrdenes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.Name = "VentanaFinalizadas";
            this.Text = "VentanaFinalizadas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridOrdenes;
        private System.Windows.Forms.DateTimePicker datePickerInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePickerFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxFecha;
        private System.Windows.Forms.PictureBox picturBox;
        private System.Windows.Forms.Button btnProceso;
    }
}