namespace Pagina_Principal
{
    partial class crud_Hoteles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboPrecioHabitacion = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Imagenhotel = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.FotoHotel = new System.Windows.Forms.Button();
            this.comboLugar3 = new System.Windows.Forms.ComboBox();
            this.comboPais3 = new System.Windows.Forms.ComboBox();
            this.numericUp3 = new System.Windows.Forms.NumericUpDown();
            this.txtNombre3 = new System.Windows.Forms.TextBox();
            this.txtCodigo3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboTarifaHotel1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGuardar2 = new System.Windows.Forms.Button();
            this.FotoHotel2 = new System.Windows.Forms.Button();
            this.comboLugar2 = new System.Windows.Forms.ComboBox();
            this.comboPais2 = new System.Windows.Forms.ComboBox();
            this.numericUp2 = new System.Windows.Forms.NumericUpDown();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagenhotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUp3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUp2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 36);
            this.panel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(790, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 33);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(931, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(53, 33);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "X";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(822, 562);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.comboPrecioHabitacion);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.Imagenhotel);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.FotoHotel);
            this.tabPage1.Controls.Add(this.comboLugar3);
            this.tabPage1.Controls.Add(this.comboPais3);
            this.tabPage1.Controls.Add(this.numericUp3);
            this.tabPage1.Controls.Add(this.txtNombre3);
            this.tabPage1.Controls.Add(this.txtCodigo3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(814, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar Hoteles";
            // 
            // comboPrecioHabitacion
            // 
            this.comboPrecioHabitacion.FormattingEnabled = true;
            this.comboPrecioHabitacion.Location = new System.Drawing.Point(106, 310);
            this.comboPrecioHabitacion.Name = "comboPrecioHabitacion";
            this.comboPrecioHabitacion.Size = new System.Drawing.Size(189, 32);
            this.comboPrecioHabitacion.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 313);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 24);
            this.label14.TabIndex = 14;
            this.label14.Text = "Tarifa Hotel";
            // 
            // Imagenhotel
            // 
            this.Imagenhotel.BackColor = System.Drawing.Color.LightGray;
            this.Imagenhotel.Location = new System.Drawing.Point(460, 259);
            this.Imagenhotel.Name = "Imagenhotel";
            this.Imagenhotel.Size = new System.Drawing.Size(348, 208);
            this.Imagenhotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagenhotel.TabIndex = 13;
            this.Imagenhotel.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Yellow;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(6, 454);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 37);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FotoHotel
            // 
            this.FotoHotel.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FotoHotel.Image = global::Pagina_Principal.Properties.Resources.camara;
            this.FotoHotel.Location = new System.Drawing.Point(346, 259);
            this.FotoHotel.Name = "FotoHotel";
            this.FotoHotel.Size = new System.Drawing.Size(94, 78);
            this.FotoHotel.TabIndex = 11;
            this.FotoHotel.UseVisualStyleBackColor = true;
            this.FotoHotel.Click += new System.EventHandler(this.FotoHotel_Click);
            // 
            // comboLugar3
            // 
            this.comboLugar3.FormattingEnabled = true;
            this.comboLugar3.Location = new System.Drawing.Point(533, 28);
            this.comboLugar3.Name = "comboLugar3";
            this.comboLugar3.Size = new System.Drawing.Size(179, 32);
            this.comboLugar3.TabIndex = 10;
            // 
            // comboPais3
            // 
            this.comboPais3.FormattingEnabled = true;
            this.comboPais3.Location = new System.Drawing.Point(106, 210);
            this.comboPais3.Name = "comboPais3";
            this.comboPais3.Size = new System.Drawing.Size(189, 32);
            this.comboPais3.TabIndex = 9;
            // 
            // numericUp3
            // 
            this.numericUp3.Location = new System.Drawing.Point(533, 121);
            this.numericUp3.Name = "numericUp3";
            this.numericUp3.Size = new System.Drawing.Size(179, 30);
            this.numericUp3.TabIndex = 8;
            // 
            // txtNombre3
            // 
            this.txtNombre3.Location = new System.Drawing.Point(106, 121);
            this.txtNombre3.Name = "txtNombre3";
            this.txtNombre3.Size = new System.Drawing.Size(189, 30);
            this.txtNombre3.TabIndex = 7;
            // 
            // txtCodigo3
            // 
            this.txtCodigo3.BackColor = System.Drawing.Color.White;
            this.txtCodigo3.Location = new System.Drawing.Point(106, 30);
            this.txtCodigo3.Name = "txtCodigo3";
            this.txtCodigo3.Size = new System.Drawing.Size(189, 30);
            this.txtCodigo3.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Foto del Hotel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad Habitaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Localidad Hotel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "País";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.comboTarifaHotel1);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.btnLimpiar);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.btnGuardar2);
            this.tabPage2.Controls.Add(this.FotoHotel2);
            this.tabPage2.Controls.Add(this.comboLugar2);
            this.tabPage2.Controls.Add(this.comboPais2);
            this.tabPage2.Controls.Add(this.numericUp2);
            this.tabPage2.Controls.Add(this.txtNombre2);
            this.tabPage2.Controls.Add(this.txtCodigo2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(814, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar o Eliminar Hoteles";
            // 
            // comboTarifaHotel1
            // 
            this.comboTarifaHotel1.FormattingEnabled = true;
            this.comboTarifaHotel1.Location = new System.Drawing.Point(102, 365);
            this.comboTarifaHotel1.Name = "comboTarifaHotel1";
            this.comboTarifaHotel1.Size = new System.Drawing.Size(189, 32);
            this.comboTarifaHotel1.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 366);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 24);
            this.label15.TabIndex = 33;
            this.label15.Text = "Tarifa Hotel";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Yellow;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(129, 482);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 37);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 24);
            this.label13.TabIndex = 31;
            this.label13.Text = "Seleccionar Hotel";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 32);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Yellow;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(252, 482);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 37);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Location = new System.Drawing.Point(460, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(348, 208);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // btnGuardar2
            // 
            this.btnGuardar2.BackColor = System.Drawing.Color.Yellow;
            this.btnGuardar2.FlatAppearance.BorderSize = 0;
            this.btnGuardar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnGuardar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnGuardar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar2.Location = new System.Drawing.Point(6, 482);
            this.btnGuardar2.Name = "btnGuardar2";
            this.btnGuardar2.Size = new System.Drawing.Size(102, 37);
            this.btnGuardar2.TabIndex = 26;
            this.btnGuardar2.Text = "Guardar";
            this.btnGuardar2.UseVisualStyleBackColor = false;
            this.btnGuardar2.Click += new System.EventHandler(this.btnGuardar2_Click);
            // 
            // FotoHotel2
            // 
            this.FotoHotel2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FotoHotel2.Image = global::Pagina_Principal.Properties.Resources.camara;
            this.FotoHotel2.Location = new System.Drawing.Point(346, 267);
            this.FotoHotel2.Name = "FotoHotel2";
            this.FotoHotel2.Size = new System.Drawing.Size(94, 78);
            this.FotoHotel2.TabIndex = 25;
            this.FotoHotel2.UseVisualStyleBackColor = true;
            this.FotoHotel2.Click += new System.EventHandler(this.FotoHotel2_Click);
            // 
            // comboLugar2
            // 
            this.comboLugar2.FormattingEnabled = true;
            this.comboLugar2.Location = new System.Drawing.Point(533, 53);
            this.comboLugar2.Name = "comboLugar2";
            this.comboLugar2.Size = new System.Drawing.Size(179, 32);
            this.comboLugar2.TabIndex = 24;
            // 
            // comboPais2
            // 
            this.comboPais2.FormattingEnabled = true;
            this.comboPais2.Location = new System.Drawing.Point(102, 284);
            this.comboPais2.Name = "comboPais2";
            this.comboPais2.Size = new System.Drawing.Size(189, 32);
            this.comboPais2.TabIndex = 23;
            // 
            // numericUp2
            // 
            this.numericUp2.Location = new System.Drawing.Point(533, 141);
            this.numericUp2.Name = "numericUp2";
            this.numericUp2.Size = new System.Drawing.Size(179, 30);
            this.numericUp2.TabIndex = 22;
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(102, 205);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(189, 30);
            this.txtNombre2.TabIndex = 21;
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.BackColor = System.Drawing.Color.White;
            this.txtCodigo2.Location = new System.Drawing.Point(102, 126);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.ReadOnly = true;
            this.txtCodigo2.Size = new System.Drawing.Size(189, 30);
            this.txtCodigo2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Foto del Hotel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cantidad Habitaciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Localidad Hotel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "País";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "Nombre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "Codigo ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // crud_Hoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(846, 616);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "crud_Hoteles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "crud_Hoteles";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagenhotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUp3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUp2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button FotoHotel;
        private System.Windows.Forms.ComboBox comboLugar3;
        private System.Windows.Forms.NumericUpDown numericUp3;
        private System.Windows.Forms.TextBox txtNombre3;
        private System.Windows.Forms.TextBox txtCodigo3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox comboPais3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGuardar2;
        private System.Windows.Forms.Button FotoHotel2;
        private System.Windows.Forms.ComboBox comboLugar2;
        private System.Windows.Forms.ComboBox comboPais2;
        private System.Windows.Forms.NumericUpDown numericUp2;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.TextBox txtCodigo2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox Imagenhotel;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox comboPrecioHabitacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboTarifaHotel1;
        private System.Windows.Forms.Label label15;
    }
}