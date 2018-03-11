namespace Pagina_Principal
{
    partial class Seccion_vuelos
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelPersonas = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.spinerMenores = new System.Windows.Forms.NumericUpDown();
            this.spinnerAdultos = new System.Windows.Forms.NumericUpDown();
            this.labelCantidadDias = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgHotel = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrehotl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgVehi = new System.Windows.Forms.DataGridView();
            this.id_vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_ve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.spinnerHab = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinerMenores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Añadir Hotel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Añadir Vehiculo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encuentra tu vuelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Origen:";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(76, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destino:";
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox2.Location = new System.Drawing.Point(330, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(133, 92);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fechas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dias:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pasajeros:";
            // 
            // panelPersonas
            // 
            this.panelPersonas.Controls.Add(this.label23);
            this.panelPersonas.Controls.Add(this.label21);
            this.panelPersonas.Controls.Add(this.spinerMenores);
            this.panelPersonas.Controls.Add(this.spinnerAdultos);
            this.panelPersonas.Location = new System.Drawing.Point(343, 70);
            this.panelPersonas.Name = "panelPersonas";
            this.panelPersonas.Size = new System.Drawing.Size(113, 60);
            this.panelPersonas.TabIndex = 53;
            this.panelPersonas.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 37);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 13);
            this.label23.TabIndex = 42;
            this.label23.Text = "Adultos:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 7);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "Niños:";
            // 
            // spinerMenores
            // 
            this.spinerMenores.Location = new System.Drawing.Point(60, 8);
            this.spinerMenores.Name = "spinerMenores";
            this.spinerMenores.ReadOnly = true;
            this.spinerMenores.Size = new System.Drawing.Size(37, 20);
            this.spinerMenores.TabIndex = 44;
            this.spinerMenores.ValueChanged += new System.EventHandler(this.spinerMenores_ValueChanged);
            // 
            // spinnerAdultos
            // 
            this.spinnerAdultos.Location = new System.Drawing.Point(60, 37);
            this.spinnerAdultos.Name = "spinnerAdultos";
            this.spinnerAdultos.ReadOnly = true;
            this.spinnerAdultos.Size = new System.Drawing.Size(37, 20);
            this.spinnerAdultos.TabIndex = 45;
            this.spinnerAdultos.ValueChanged += new System.EventHandler(this.spinnerAdultos_ValueChanged);
            // 
            // labelCantidadDias
            // 
            this.labelCantidadDias.AutoSize = true;
            this.labelCantidadDias.Location = new System.Drawing.Point(439, 122);
            this.labelCantidadDias.Name = "labelCantidadDias";
            this.labelCantidadDias.Size = new System.Drawing.Size(0, 13);
            this.labelCantidadDias.TabIndex = 52;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 54;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(931, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 55;
            this.button4.Text = "Regresar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(636, 308);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 93);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // dtgHotel
            // 
            this.dtgHotel.AllowUserToAddRows = false;
            this.dtgHotel.AllowUserToDeleteRows = false;
            this.dtgHotel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombrehotl,
            this.nombre_pais,
            this.lugar,
            this.ha,
            this.precio_h,
            this.puntuacion});
            this.dtgHotel.Location = new System.Drawing.Point(13, 308);
            this.dtgHotel.Name = "dtgHotel";
            this.dtgHotel.ReadOnly = true;
            this.dtgHotel.Size = new System.Drawing.Size(617, 198);
            this.dtgHotel.TabIndex = 60;
            // 
            // id
            // 
            this.id.DataPropertyName = "CODIGO";
            this.id.HeaderText = "CODIGO";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombrehotl
            // 
            this.nombrehotl.DataPropertyName = "nombrehotl";
            this.nombrehotl.HeaderText = "NOMBRE";
            this.nombrehotl.Name = "nombrehotl";
            this.nombrehotl.ReadOnly = true;
            // 
            // nombre_pais
            // 
            this.nombre_pais.DataPropertyName = "nombre_pais";
            this.nombre_pais.HeaderText = "PAIS";
            this.nombre_pais.Name = "nombre_pais";
            this.nombre_pais.ReadOnly = true;
            // 
            // lugar
            // 
            this.lugar.DataPropertyName = "nombre_lugar";
            this.lugar.HeaderText = "LUGAR";
            this.lugar.Name = "lugar";
            this.lugar.ReadOnly = true;
            // 
            // ha
            // 
            this.ha.HeaderText = "HABITA";
            this.ha.Name = "ha";
            this.ha.ReadOnly = true;
            // 
            // precio_h
            // 
            this.precio_h.DataPropertyName = "precio";
            this.precio_h.HeaderText = "PRECIO";
            this.precio_h.Name = "precio_h";
            this.precio_h.ReadOnly = true;
            // 
            // puntuacion
            // 
            this.puntuacion.DataPropertyName = "puntuacion";
            this.puntuacion.HeaderText = "CALIFICACION";
            this.puntuacion.Name = "puntuacion";
            this.puntuacion.ReadOnly = true;
            // 
            // dtgVehi
            // 
            this.dtgVehi.AllowUserToAddRows = false;
            this.dtgVehi.AllowUserToDeleteRows = false;
            this.dtgVehi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVehi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVehi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vehiculo,
            this.marca,
            this.modelo,
            this.esti,
            this.capacidad,
            this.precio_ve});
            this.dtgVehi.Location = new System.Drawing.Point(782, 308);
            this.dtgVehi.Name = "dtgVehi";
            this.dtgVehi.ReadOnly = true;
            this.dtgVehi.Size = new System.Drawing.Size(457, 150);
            this.dtgVehi.TabIndex = 61;
            // 
            // id_vehiculo
            // 
            this.id_vehiculo.DataPropertyName = "id_vehiculo";
            this.id_vehiculo.HeaderText = "PLACA";
            this.id_vehiculo.Name = "id_vehiculo";
            this.id_vehiculo.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "MARCA";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "MODELO";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // esti
            // 
            this.esti.HeaderText = "ESTILO";
            this.esti.Name = "esti";
            this.esti.ReadOnly = true;
            // 
            // capacidad
            // 
            this.capacidad.DataPropertyName = "capacidad";
            this.capacidad.HeaderText = "CAPACIDAD";
            this.capacidad.Name = "capacidad";
            this.capacidad.ReadOnly = true;
            // 
            // precio_ve
            // 
            this.precio_ve.DataPropertyName = "precio";
            this.precio_ve.HeaderText = "PRECIO";
            this.precio_ve.Name = "precio_ve";
            this.precio_ve.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Habitaciones";
            // 
            // spinnerHab
            // 
            this.spinnerHab.Location = new System.Drawing.Point(546, 83);
            this.spinnerHab.Name = "spinnerHab";
            this.spinnerHab.ReadOnly = true;
            this.spinnerHab.Size = new System.Drawing.Size(41, 20);
            this.spinnerHab.TabIndex = 63;
            this.spinnerHab.ValueChanged += new System.EventHandler(this.spinnerHab_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 150);
            this.dataGridView1.TabIndex = 64;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pais Origen";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Pais Destino";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Vuelo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Pais Salida";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Pais Destino";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Vuelo";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Precio";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Duracion Escala";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Duracion Directo";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Pasajeros";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Habitaciones";
            this.Column11.Name = "Column11";
            // 
            // Seccion_vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1255, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.spinnerHab);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgVehi);
            this.Controls.Add(this.dtgHotel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panelPersonas);
            this.Controls.Add(this.labelCantidadDias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Seccion_vuelos";
            this.Text = "seccion_vuelos";
            this.Load += new System.EventHandler(this.seccion_vuelos_Load);
            this.panelPersonas.ResumeLayout(false);
            this.panelPersonas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinerMenores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelPersonas;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown spinerMenores;
        private System.Windows.Forms.NumericUpDown spinnerAdultos;
        private System.Windows.Forms.Label labelCantidadDias;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgHotel;
        private System.Windows.Forms.DataGridView dtgVehi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown spinnerHab;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn esti;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_ve;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrehotl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ha;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_h;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntuacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}