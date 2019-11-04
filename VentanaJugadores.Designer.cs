namespace Control_Ordenes_Trabajo
{
    partial class VentanaJugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaJugadores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridJugadores = new System.Windows.Forms.DataGridView();
            this.lbContadorDeJugadores = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTam = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTitulo.Controls.Add(this.label6);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(700, 30);
            this.panelTitulo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Agregar jugadores";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(670, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGuardarCambios);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.dataGridJugadores);
            this.panel1.Controls.Add(this.lbContadorDeJugadores);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbTam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 320);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridJugadores
            // 
            this.dataGridJugadores.AllowUserToAddRows = false;
            this.dataGridJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridJugadores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridJugadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(189)))), ((int)(((byte)(191)))));
            this.dataGridJugadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridJugadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridJugadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridJugadores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridJugadores.EnableHeadersVisualStyles = false;
            this.dataGridJugadores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(189)))), ((int)(((byte)(191)))));
            this.dataGridJugadores.Location = new System.Drawing.Point(247, 23);
            this.dataGridJugadores.Name = "dataGridJugadores";
            this.dataGridJugadores.RowHeadersVisible = false;
            this.dataGridJugadores.Size = new System.Drawing.Size(429, 216);
            this.dataGridJugadores.TabIndex = 23;
            // 
            // lbContadorDeJugadores
            // 
            this.lbContadorDeJugadores.AutoSize = true;
            this.lbContadorDeJugadores.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContadorDeJugadores.Location = new System.Drawing.Point(208, 223);
            this.lbContadorDeJugadores.Name = "lbContadorDeJugadores";
            this.lbContadorDeJugadores.Size = new System.Drawing.Size(15, 16);
            this.lbContadorDeJugadores.TabIndex = 22;
            this.lbContadorDeJugadores.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(86, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Jugadores agregados: ";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumero.Location = new System.Drawing.Point(79, 64);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(140, 23);
            this.txtNumero.TabIndex = 18;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(18, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellido.Location = new System.Drawing.Point(79, 23);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(140, 23);
            this.txtApellido.TabIndex = 15;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tamaño:";
            // 
            // cbTam
            // 
            this.cbTam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTam.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbTam.FormattingEnabled = true;
            this.cbTam.Items.AddRange(new object[] {
            "ECH",
            "CH",
            "M",
            "G ",
            "EG",
            "EEG"});
            this.cbTam.Location = new System.Drawing.Point(79, 107);
            this.cbTam.Name = "cbTam";
            this.cbTam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTam.Size = new System.Drawing.Size(140, 24);
            this.cbTam.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(217)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(144)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(184)))), ((int)(((byte)(229)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(89, 167);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(130, 43);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "    Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(217)))));
            this.btnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btnGuardarCambios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(144)))));
            this.btnGuardarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(184)))), ((int)(((byte)(229)))));
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCambios.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCambios.Image")));
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCambios.Location = new System.Drawing.Point(396, 254);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuardarCambios.Size = new System.Drawing.Size(130, 43);
            this.btnGuardarCambios.TabIndex = 25;
            this.btnGuardarCambios.Text = "    Guardar";
            this.btnGuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // VentanaJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaJugadores";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJugadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridJugadores;
        private System.Windows.Forms.Label lbContadorDeJugadores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTam;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardarCambios;
    }
}