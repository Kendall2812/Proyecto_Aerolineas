namespace Pagina_Principal
{
    partial class crud_Rutas
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.EditarEliminar = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.Hora2 = new System.Windows.Forms.DateTimePicker();
            this.comboPaisDestino2 = new System.Windows.Forms.ComboBox();
            this.comboPaisOrigen2 = new System.Windows.Forms.ComboBox();
            this.codigo2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1Datos = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Horas = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.comboPaisDestino = new System.Windows.Forms.ComboBox();
            this.comboPaisOrigen = new System.Windows.Forms.ComboBox();
            this.txtCodigoR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.EditarEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Datos)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 36);
            this.panel1.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(841, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(53, 33);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "X";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // EditarEliminar
            // 
            this.EditarEliminar.BackColor = System.Drawing.Color.Silver;
            this.EditarEliminar.Controls.Add(this.btnGuardar);
            this.EditarEliminar.Controls.Add(this.btnEliminar);
            this.EditarEliminar.Controls.Add(this.btnModificar);
            this.EditarEliminar.Controls.Add(this.Hora2);
            this.EditarEliminar.Controls.Add(this.comboPaisDestino2);
            this.EditarEliminar.Controls.Add(this.comboPaisOrigen2);
            this.EditarEliminar.Controls.Add(this.codigo2);
            this.EditarEliminar.Controls.Add(this.label5);
            this.EditarEliminar.Controls.Add(this.label6);
            this.EditarEliminar.Controls.Add(this.label7);
            this.EditarEliminar.Controls.Add(this.label8);
            this.EditarEliminar.Controls.Add(this.dataGridView1Datos);
            this.EditarEliminar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarEliminar.Location = new System.Drawing.Point(4, 33);
            this.EditarEliminar.Name = "EditarEliminar";
            this.EditarEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.EditarEliminar.Size = new System.Drawing.Size(863, 476);
            this.EditarEliminar.TabIndex = 1;
            this.EditarEliminar.Text = "Editar o Eliminar Rutas";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Yellow;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(638, 177);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 37);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Yellow;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(755, 177);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 37);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Yellow;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(521, 177);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 37);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Hora2
            // 
            this.Hora2.CustomFormat = "hh:mm";
            this.Hora2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Hora2.Location = new System.Drawing.Point(548, 106);
            this.Hora2.Name = "Hora2";
            this.Hora2.ShowUpDown = true;
            this.Hora2.Size = new System.Drawing.Size(136, 30);
            this.Hora2.TabIndex = 20;
            this.Hora2.Value = new System.DateTime(2018, 2, 21, 15, 9, 31, 0);
            // 
            // comboPaisDestino2
            // 
            this.comboPaisDestino2.FormattingEnabled = true;
            this.comboPaisDestino2.Location = new System.Drawing.Point(362, 104);
            this.comboPaisDestino2.Name = "comboPaisDestino2";
            this.comboPaisDestino2.Size = new System.Drawing.Size(140, 32);
            this.comboPaisDestino2.TabIndex = 19;
            // 
            // comboPaisOrigen2
            // 
            this.comboPaisOrigen2.FormattingEnabled = true;
            this.comboPaisOrigen2.Location = new System.Drawing.Point(189, 104);
            this.comboPaisOrigen2.Name = "comboPaisOrigen2";
            this.comboPaisOrigen2.Size = new System.Drawing.Size(140, 32);
            this.comboPaisOrigen2.TabIndex = 18;
            // 
            // codigo2
            // 
            this.codigo2.BackColor = System.Drawing.Color.White;
            this.codigo2.Location = new System.Drawing.Point(16, 106);
            this.codigo2.Name = "codigo2";
            this.codigo2.ReadOnly = true;
            this.codigo2.Size = new System.Drawing.Size(140, 30);
            this.codigo2.TabIndex = 17;
            this.codigo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo2_KeyPress);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(535, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Duración";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(362, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "País Destino";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(189, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "País Origen";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Codigo Ruta";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1Datos
            // 
            this.dataGridView1Datos.AllowUserToAddRows = false;
            this.dataGridView1Datos.AllowUserToDeleteRows = false;
            this.dataGridView1Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Datos.Location = new System.Drawing.Point(6, 220);
            this.dataGridView1Datos.Name = "dataGridView1Datos";
            this.dataGridView1Datos.ReadOnly = true;
            this.dataGridView1Datos.RowTemplate.Height = 24;
            this.dataGridView1Datos.Size = new System.Drawing.Size(851, 250);
            this.dataGridView1Datos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.Horas);
            this.tabPage1.Controls.Add(this.btnRegistrar);
            this.tabPage1.Controls.Add(this.comboPaisDestino);
            this.tabPage1.Controls.Add(this.comboPaisOrigen);
            this.tabPage1.Controls.Add(this.txtCodigoR);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(863, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Rutas";
            // 
            // Horas
            // 
            this.Horas.CustomFormat = "hh:mm";
            this.Horas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Horas.Location = new System.Drawing.Point(542, 88);
            this.Horas.Name = "Horas";
            this.Horas.ShowUpDown = true;
            this.Horas.Size = new System.Drawing.Size(136, 30);
            this.Horas.TabIndex = 12;
            this.Horas.Value = new System.DateTime(2018, 2, 20, 9, 21, 0, 0);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Yellow;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(10, 232);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(102, 37);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // comboPaisDestino
            // 
            this.comboPaisDestino.FormattingEnabled = true;
            this.comboPaisDestino.Location = new System.Drawing.Point(356, 86);
            this.comboPaisDestino.Name = "comboPaisDestino";
            this.comboPaisDestino.Size = new System.Drawing.Size(140, 32);
            this.comboPaisDestino.TabIndex = 7;
            // 
            // comboPaisOrigen
            // 
            this.comboPaisOrigen.FormattingEnabled = true;
            this.comboPaisOrigen.Location = new System.Drawing.Point(183, 86);
            this.comboPaisOrigen.Name = "comboPaisOrigen";
            this.comboPaisOrigen.Size = new System.Drawing.Size(140, 32);
            this.comboPaisOrigen.TabIndex = 6;
            // 
            // txtCodigoR
            // 
            this.txtCodigoR.Location = new System.Drawing.Point(10, 88);
            this.txtCodigoR.Name = "txtCodigoR";
            this.txtCodigoR.Size = new System.Drawing.Size(140, 30);
            this.txtCodigoR.TabIndex = 4;
            this.txtCodigoR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoR_KeyPress);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(529, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duración";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(356, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "País Destino";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(183, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "País Origen";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Ruta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.EditarEliminar);
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 513);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // crud_Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(897, 583);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "crud_Rutas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "crud_aeropuertos";
            this.Load += new System.EventHandler(this.crud_aeropuertos_Load);
            this.panel1.ResumeLayout(false);
            this.EditarEliminar.ResumeLayout(false);
            this.EditarEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Datos)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TabPage EditarEliminar;
        private System.Windows.Forms.DataGridView dataGridView1Datos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker Horas;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox comboPaisDestino;
        private System.Windows.Forms.ComboBox comboPaisOrigen;
        private System.Windows.Forms.TextBox txtCodigoR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DateTimePicker Hora2;
        private System.Windows.Forms.ComboBox comboPaisDestino2;
        private System.Windows.Forms.ComboBox comboPaisOrigen2;
        private System.Windows.Forms.TextBox codigo2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
    }
}