namespace Pagina_Principal
{
    partial class reservasYcompras
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
            this.btnComprar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.Reservas_Hoteles = new System.Windows.Forms.RadioButton();
            this.Reservas_Vuelos = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInfoHotel = new System.Windows.Forms.Button();
            this.dtgVehi = new System.Windows.Forms.DataGridView();
            this.dtgHotel = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "MIS RESERVAS";
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.Yellow;
            this.btnComprar.FlatAppearance.BorderSize = 0;
            this.btnComprar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnComprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(164, 312);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(76, 30);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 29);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(940, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Yellow;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(264, 312);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 30);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.BackColor = System.Drawing.Color.Yellow;
            this.btnVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVehiculo.FlatAppearance.BorderSize = 0;
            this.btnVehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnVehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculo.Location = new System.Drawing.Point(13, 374);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(154, 30);
            this.btnVehiculo.TabIndex = 9;
            this.btnVehiculo.Text = "Informacion Vehiculo";
            this.btnVehiculo.UseVisualStyleBackColor = false;
            // 
            // Reservas_Hoteles
            // 
            this.Reservas_Hoteles.AutoSize = true;
            this.Reservas_Hoteles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservas_Hoteles.Location = new System.Drawing.Point(13, 84);
            this.Reservas_Hoteles.Margin = new System.Windows.Forms.Padding(2);
            this.Reservas_Hoteles.Name = "Reservas_Hoteles";
            this.Reservas_Hoteles.Size = new System.Drawing.Size(138, 21);
            this.Reservas_Hoteles.TabIndex = 10;
            this.Reservas_Hoteles.TabStop = true;
            this.Reservas_Hoteles.Text = "Reservas Hoteles";
            this.Reservas_Hoteles.UseVisualStyleBackColor = true;
            this.Reservas_Hoteles.CheckedChanged += new System.EventHandler(this.Reservas_Hoteles_CheckedChanged);
            // 
            // Reservas_Vuelos
            // 
            this.Reservas_Vuelos.AutoSize = true;
            this.Reservas_Vuelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reservas_Vuelos.Location = new System.Drawing.Point(13, 124);
            this.Reservas_Vuelos.Margin = new System.Windows.Forms.Padding(2);
            this.Reservas_Vuelos.Name = "Reservas_Vuelos";
            this.Reservas_Vuelos.Size = new System.Drawing.Size(153, 21);
            this.Reservas_Vuelos.TabIndex = 11;
            this.Reservas_Vuelos.TabStop = true;
            this.Reservas_Vuelos.Text = "Reservas de Vuelos";
            this.Reservas_Vuelos.UseVisualStyleBackColor = true;
            this.Reservas_Vuelos.CheckedChanged += new System.EventHandler(this.Reservas_Vuelos_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 210);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnInfoHotel
            // 
            this.btnInfoHotel.BackColor = System.Drawing.Color.Yellow;
            this.btnInfoHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoHotel.FlatAppearance.BorderSize = 0;
            this.btnInfoHotel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnInfoHotel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnInfoHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoHotel.Location = new System.Drawing.Point(526, 374);
            this.btnInfoHotel.Name = "btnInfoHotel";
            this.btnInfoHotel.Size = new System.Drawing.Size(138, 30);
            this.btnInfoHotel.TabIndex = 14;
            this.btnInfoHotel.Text = "Informacion Hotel";
            this.btnInfoHotel.UseVisualStyleBackColor = false;
            // 
            // dtgVehi
            // 
            this.dtgVehi.AllowUserToAddRows = false;
            this.dtgVehi.AllowUserToDeleteRows = false;
            this.dtgVehi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVehi.Location = new System.Drawing.Point(13, 410);
            this.dtgVehi.Name = "dtgVehi";
            this.dtgVehi.Size = new System.Drawing.Size(404, 150);
            this.dtgVehi.TabIndex = 15;
            // 
            // dtgHotel
            // 
            this.dtgHotel.AllowUserToAddRows = false;
            this.dtgHotel.AllowUserToDeleteRows = false;
            this.dtgHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHotel.Location = new System.Drawing.Point(526, 410);
            this.dtgHotel.Name = "dtgHotel";
            this.dtgHotel.Size = new System.Drawing.Size(406, 150);
            this.dtgHotel.TabIndex = 16;
            // 
            // reservasYcompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(982, 592);
            this.Controls.Add(this.dtgHotel);
            this.Controls.Add(this.dtgVehi);
            this.Controls.Add(this.btnInfoHotel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Reservas_Vuelos);
            this.Controls.Add(this.Reservas_Hoteles);
            this.Controls.Add(this.btnVehiculo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnComprar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reservasYcompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reservasYcompras";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.RadioButton Reservas_Hoteles;
        private System.Windows.Forms.RadioButton Reservas_Vuelos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInfoHotel;
        private System.Windows.Forms.DataGridView dtgVehi;
        private System.Windows.Forms.DataGridView dtgHotel;
    }
}