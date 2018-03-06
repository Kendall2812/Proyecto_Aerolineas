namespace Pagina_Principal
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.optPrecioMenorPais = new System.Windows.Forms.RadioButton();
            this.optPrecioMayorPais = new System.Windows.Forms.RadioButton();
            this.btnReservar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPersonas = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.spinerMenores = new System.Windows.Forms.NumericUpDown();
            this.spinnerAdultos = new System.Windows.Forms.NumericUpDown();
            this.labelCantidadDias = new System.Windows.Forms.Label();
            this.spinnerHab = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.dataTLlegada = new System.Windows.Forms.DateTimePicker();
            this.dateTPSalida = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldestino = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtLugar = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinerMenores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerHab)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.rbtLugar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.optPrecioMenorPais);
            this.panel1.Controls.Add(this.optPrecioMayorPais);
            this.panel1.Controls.Add(this.btnReservar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panelPersonas);
            this.panel1.Controls.Add(this.labelCantidadDias);
            this.panel1.Controls.Add(this.spinnerHab);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataTLlegada);
            this.panel1.Controls.Add(this.dateTPSalida);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblDias);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbldestino);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 563);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(601, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(636, 247);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 56;
            this.button3.Text = "Mis Reservas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 55;
            this.button2.Text = "Cerrar Sesion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // optPrecioMenorPais
            // 
            this.optPrecioMenorPais.AutoSize = true;
            this.optPrecioMenorPais.Location = new System.Drawing.Point(141, 269);
            this.optPrecioMenorPais.Name = "optPrecioMenorPais";
            this.optPrecioMenorPais.Size = new System.Drawing.Size(88, 17);
            this.optPrecioMenorPais.TabIndex = 54;
            this.optPrecioMenorPais.TabStop = true;
            this.optPrecioMenorPais.Text = "Precio Menor";
            this.optPrecioMenorPais.UseVisualStyleBackColor = true;
            this.optPrecioMenorPais.CheckedChanged += new System.EventHandler(this.optPrecioMenorPais_CheckedChanged);
            // 
            // optPrecioMayorPais
            // 
            this.optPrecioMayorPais.AutoSize = true;
            this.optPrecioMayorPais.Location = new System.Drawing.Point(48, 269);
            this.optPrecioMayorPais.Name = "optPrecioMayorPais";
            this.optPrecioMayorPais.Size = new System.Drawing.Size(87, 17);
            this.optPrecioMayorPais.TabIndex = 53;
            this.optPrecioMayorPais.TabStop = true;
            this.optPrecioMayorPais.Text = "Precio Mayor";
            this.optPrecioMayorPais.UseVisualStyleBackColor = true;
            this.optPrecioMayorPais.CheckedChanged += new System.EventHandler(this.optPrecioMayorPais_CheckedChanged);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(658, 372);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 52;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Personas:";
            // 
            // panelPersonas
            // 
            this.panelPersonas.Controls.Add(this.label23);
            this.panelPersonas.Controls.Add(this.label21);
            this.panelPersonas.Controls.Add(this.spinerMenores);
            this.panelPersonas.Controls.Add(this.spinnerAdultos);
            this.panelPersonas.Location = new System.Drawing.Point(406, 148);
            this.panelPersonas.Name = "panelPersonas";
            this.panelPersonas.Size = new System.Drawing.Size(113, 60);
            this.panelPersonas.TabIndex = 50;
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
            this.label21.Location = new System.Drawing.Point(3, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "Niños:";
            // 
            // spinerMenores
            // 
            this.spinerMenores.Location = new System.Drawing.Point(60, 8);
            this.spinerMenores.Name = "spinerMenores";
            this.spinerMenores.Size = new System.Drawing.Size(37, 20);
            this.spinerMenores.TabIndex = 44;
            this.spinerMenores.ValueChanged += new System.EventHandler(this.spinerMenores_ValueChanged);
            // 
            // spinnerAdultos
            // 
            this.spinnerAdultos.Location = new System.Drawing.Point(60, 37);
            this.spinnerAdultos.Name = "spinnerAdultos";
            this.spinnerAdultos.Size = new System.Drawing.Size(37, 20);
            this.spinnerAdultos.TabIndex = 45;
            this.spinnerAdultos.ValueChanged += new System.EventHandler(this.spinnerAdultos_ValueChanged);
            // 
            // labelCantidadDias
            // 
            this.labelCantidadDias.AutoSize = true;
            this.labelCantidadDias.Location = new System.Drawing.Point(450, 189);
            this.labelCantidadDias.Name = "labelCantidadDias";
            this.labelCantidadDias.Size = new System.Drawing.Size(0, 13);
            this.labelCantidadDias.TabIndex = 49;
            // 
            // spinnerHab
            // 
            this.spinnerHab.Location = new System.Drawing.Point(300, 161);
            this.spinnerHab.Name = "spinnerHab";
            this.spinnerHab.Size = new System.Drawing.Size(48, 20);
            this.spinnerHab.TabIndex = 11;
            this.spinnerHab.ValueChanged += new System.EventHandler(this.spinnerHab_ValueChanged);
            this.spinnerHab.Click += new System.EventHandler(this.numericUpDown1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(48, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataTLlegada
            // 
            this.dataTLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataTLlegada.Location = new System.Drawing.Point(156, 161);
            this.dataTLlegada.Name = "dataTLlegada";
            this.dataTLlegada.Size = new System.Drawing.Size(101, 20);
            this.dataTLlegada.TabIndex = 7;
            this.dataTLlegada.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTPSalida
            // 
            this.dateTPSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPSalida.Location = new System.Drawing.Point(49, 161);
            this.dateTPSalida.Name = "dateTPSalida";
            this.dateTPSalida.Size = new System.Drawing.Size(101, 20);
            this.dateTPSalida.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Habitaciones:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(153, 132);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(31, 13);
            this.lblDias.TabIndex = 4;
            this.lblDias.Text = "        ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fechas:";
            // 
            // lbldestino
            // 
            this.lbldestino.AutoSize = true;
            this.lbldestino.Location = new System.Drawing.Point(45, 77);
            this.lbldestino.Name = "lbldestino";
            this.lbldestino.Size = new System.Drawing.Size(46, 13);
            this.lbldestino.TabIndex = 2;
            this.lbldestino.Text = "Destino:";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(48, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSCA TU ALOJAMIENTO";
            // 
            // rbtLugar
            // 
            this.rbtLugar.AutoSize = true;
            this.rbtLugar.Location = new System.Drawing.Point(244, 269);
            this.rbtLugar.Name = "rbtLugar";
            this.rbtLugar.Size = new System.Drawing.Size(52, 17);
            this.rbtLugar.TabIndex = 60;
            this.rbtLugar.TabStop = true;
            this.rbtLugar.Text = "Lugar";
            this.rbtLugar.UseVisualStyleBackColor = true;
            this.rbtLugar.CheckedChanged += new System.EventHandler(this.rbtLugar_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 556);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelPersonas.ResumeLayout(false);
            this.panelPersonas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinerMenores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerHab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dataTLlegada;
        private System.Windows.Forms.DateTimePicker dateTPSalida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldestino;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown spinnerHab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPersonas;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown spinerMenores;
        private System.Windows.Forms.NumericUpDown spinnerAdultos;
        private System.Windows.Forms.Label labelCantidadDias;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.RadioButton optPrecioMenorPais;
        private System.Windows.Forms.RadioButton optPrecioMayorPais;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtLugar;
    }
}