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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaFinalizadas));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dataGridOrdenes = new System.Windows.Forms.DataGridView();
            this.datePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.datePickerFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxFecha = new System.Windows.Forms.CheckBox();
            this.picturBox = new System.Windows.Forms.PictureBox();
            this.btnProceso = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(154, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del equipo:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusqueda.Location = new System.Drawing.Point(272, 26);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(220, 23);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridOrdenes
            // 
            this.dataGridOrdenes.AllowUserToAddRows = false;
            this.dataGridOrdenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrdenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridOrdenes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(189)))), ((int)(((byte)(191)))));
            this.dataGridOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridOrdenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridOrdenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridOrdenes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridOrdenes.EnableHeadersVisualStyles = false;
            this.dataGridOrdenes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(189)))), ((int)(((byte)(191)))));
            this.dataGridOrdenes.Location = new System.Drawing.Point(12, 246);
            this.dataGridOrdenes.Name = "dataGridOrdenes";
            this.dataGridOrdenes.ReadOnly = true;
            this.dataGridOrdenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridOrdenes.RowHeadersVisible = false;
            this.dataGridOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrdenes.Size = new System.Drawing.Size(620, 302);
            this.dataGridOrdenes.TabIndex = 3;
            this.dataGridOrdenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrdenes_CellClick);
            // 
            // datePickerInicio
            // 
            this.datePickerInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePickerInicio.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.datePickerInicio.Enabled = false;
            this.datePickerInicio.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerInicio.Location = new System.Drawing.Point(181, 110);
            this.datePickerInicio.Name = "datePickerInicio";
            this.datePickerInicio.Size = new System.Drawing.Size(311, 23);
            this.datePickerInicio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(154, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "De:";
            // 
            // datePickerFin
            // 
            this.datePickerFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePickerFin.Enabled = false;
            this.datePickerFin.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFin.Location = new System.Drawing.Point(181, 146);
            this.datePickerFin.Name = "datePickerFin";
            this.datePickerFin.Size = new System.Drawing.Size(311, 23);
            this.datePickerFin.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(154, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "A:";
            // 
            // checkBoxFecha
            // 
            this.checkBoxFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxFecha.AutoSize = true;
            this.checkBoxFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBoxFecha.Location = new System.Drawing.Point(272, 71);
            this.checkBoxFecha.Name = "checkBoxFecha";
            this.checkBoxFecha.Size = new System.Drawing.Size(110, 20);
            this.checkBoxFecha.TabIndex = 10;
            this.checkBoxFecha.Text = "Filtrar por fecha";
            this.checkBoxFecha.UseVisualStyleBackColor = true;
            this.checkBoxFecha.CheckedChanged += new System.EventHandler(this.checkBoxFecha_CheckedChanged);
            // 
            // picturBox
            // 
            this.picturBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picturBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturBox.BackgroundImage")));
            this.picturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picturBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturBox.InitialImage = null;
            this.picturBox.Location = new System.Drawing.Point(638, 98);
            this.picturBox.Name = "picturBox";
            this.picturBox.Size = new System.Drawing.Size(350, 450);
            this.picturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturBox.TabIndex = 11;
            this.picturBox.TabStop = false;
            // 
            // btnProceso
            // 
            this.btnProceso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(217)))));
            this.btnProceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProceso.FlatAppearance.BorderSize = 0;
            this.btnProceso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(144)))));
            this.btnProceso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(184)))), ((int)(((byte)(229)))));
            this.btnProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceso.ForeColor = System.Drawing.Color.White;
            this.btnProceso.Image = ((System.Drawing.Image)(resources.GetObject("btnProceso.Image")));
            this.btnProceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProceso.Location = new System.Drawing.Point(362, 192);
            this.btnProceso.Name = "btnProceso";
            this.btnProceso.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProceso.Size = new System.Drawing.Size(130, 43);
            this.btnProceso.TabIndex = 26;
            this.btnProceso.Text = "    Reutilizar";
            this.btnProceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProceso.UseVisualStyleBackColor = false;
            this.btnProceso.Click += new System.EventHandler(this.btnProceso_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(217)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(144)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(184)))), ((int)(((byte)(229)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(153, 192);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuscar.Size = new System.Drawing.Size(130, 43);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "    Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // VentanaFinalizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 560);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnProceso);
            this.Controls.Add(this.picturBox);
            this.Controls.Add(this.checkBoxFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePickerFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePickerInicio);
            this.Controls.Add(this.dataGridOrdenes);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.DataGridView dataGridOrdenes;
        private System.Windows.Forms.DateTimePicker datePickerInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePickerFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxFecha;
        private System.Windows.Forms.PictureBox picturBox;
        private System.Windows.Forms.Button btnProceso;
        private System.Windows.Forms.Button btnBuscar;
    }
}