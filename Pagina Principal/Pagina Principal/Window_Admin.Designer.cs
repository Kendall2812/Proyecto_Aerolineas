namespace Pagina_Principal
{
    partial class Window_Admin
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
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.panelLed = new System.Windows.Forms.Panel();
            this.btnTarijas_Vuelo = new System.Windows.Forms.Button();
            this.btnTarijas_Hotel = new System.Windows.Forms.Button();
            this.btnHoteles = new System.Windows.Forms.Button();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnAeropuerto = new System.Windows.Forms.Button();
            this.btnLugar = new System.Windows.Forms.Button();
            this.btnPais = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelPais = new System.Windows.Forms.Panel();
            this.crudPaises1 = new Pagina_Principal.CrudPaises();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPais.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVehiculos);
            this.panel1.Controls.Add(this.panelLed);
            this.panel1.Controls.Add(this.btnTarijas_Vuelo);
            this.panel1.Controls.Add(this.btnTarijas_Hotel);
            this.panel1.Controls.Add(this.btnHoteles);
            this.panel1.Controls.Add(this.btnRutas);
            this.panel1.Controls.Add(this.btnAeropuerto);
            this.panel1.Controls.Add(this.btnLugar);
            this.panel1.Controls.Add(this.btnPais);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 685);
            this.panel1.TabIndex = 0;
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.FlatAppearance.BorderSize = 0;
            this.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculos.ForeColor = System.Drawing.Color.White;
            this.btnVehiculos.Location = new System.Drawing.Point(22, 593);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(177, 63);
            this.btnVehiculos.TabIndex = 9;
            this.btnVehiculos.Text = "Crud Vehículos";
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.button8_Click);
            // 
            // panelLed
            // 
            this.panelLed.BackColor = System.Drawing.Color.Yellow;
            this.panelLed.Location = new System.Drawing.Point(0, 124);
            this.panelLed.Name = "panelLed";
            this.panelLed.Size = new System.Drawing.Size(10, 63);
            this.panelLed.TabIndex = 3;
            // 
            // btnTarijas_Vuelo
            // 
            this.btnTarijas_Vuelo.FlatAppearance.BorderSize = 0;
            this.btnTarijas_Vuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarijas_Vuelo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarijas_Vuelo.ForeColor = System.Drawing.Color.White;
            this.btnTarijas_Vuelo.Location = new System.Drawing.Point(22, 526);
            this.btnTarijas_Vuelo.Name = "btnTarijas_Vuelo";
            this.btnTarijas_Vuelo.Size = new System.Drawing.Size(177, 63);
            this.btnTarijas_Vuelo.TabIndex = 8;
            this.btnTarijas_Vuelo.Text = "Crud Tarifas Vuelos";
            this.btnTarijas_Vuelo.UseVisualStyleBackColor = true;
            this.btnTarijas_Vuelo.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnTarijas_Hotel
            // 
            this.btnTarijas_Hotel.FlatAppearance.BorderSize = 0;
            this.btnTarijas_Hotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarijas_Hotel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarijas_Hotel.ForeColor = System.Drawing.Color.White;
            this.btnTarijas_Hotel.Location = new System.Drawing.Point(22, 459);
            this.btnTarijas_Hotel.Name = "btnTarijas_Hotel";
            this.btnTarijas_Hotel.Size = new System.Drawing.Size(177, 63);
            this.btnTarijas_Hotel.TabIndex = 7;
            this.btnTarijas_Hotel.Text = "Crud Tarifas Hoteles";
            this.btnTarijas_Hotel.UseVisualStyleBackColor = true;
            this.btnTarijas_Hotel.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnHoteles
            // 
            this.btnHoteles.FlatAppearance.BorderSize = 0;
            this.btnHoteles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoteles.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoteles.ForeColor = System.Drawing.Color.White;
            this.btnHoteles.Location = new System.Drawing.Point(22, 392);
            this.btnHoteles.Name = "btnHoteles";
            this.btnHoteles.Size = new System.Drawing.Size(177, 63);
            this.btnHoteles.TabIndex = 6;
            this.btnHoteles.Text = "Crud Hoteles";
            this.btnHoteles.UseVisualStyleBackColor = true;
            this.btnHoteles.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnRutas
            // 
            this.btnRutas.FlatAppearance.BorderSize = 0;
            this.btnRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutas.ForeColor = System.Drawing.Color.White;
            this.btnRutas.Location = new System.Drawing.Point(22, 325);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(177, 63);
            this.btnRutas.TabIndex = 5;
            this.btnRutas.Text = "Crud Rutas";
            this.btnRutas.UseVisualStyleBackColor = true;
            this.btnRutas.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAeropuerto
            // 
            this.btnAeropuerto.FlatAppearance.BorderSize = 0;
            this.btnAeropuerto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAeropuerto.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAeropuerto.ForeColor = System.Drawing.Color.White;
            this.btnAeropuerto.Location = new System.Drawing.Point(22, 258);
            this.btnAeropuerto.Name = "btnAeropuerto";
            this.btnAeropuerto.Size = new System.Drawing.Size(177, 63);
            this.btnAeropuerto.TabIndex = 4;
            this.btnAeropuerto.Text = "Crud Aeropuertos";
            this.btnAeropuerto.UseVisualStyleBackColor = true;
            this.btnAeropuerto.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLugar
            // 
            this.btnLugar.FlatAppearance.BorderSize = 0;
            this.btnLugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLugar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLugar.ForeColor = System.Drawing.Color.White;
            this.btnLugar.Location = new System.Drawing.Point(22, 191);
            this.btnLugar.Name = "btnLugar";
            this.btnLugar.Size = new System.Drawing.Size(177, 63);
            this.btnLugar.TabIndex = 3;
            this.btnLugar.Text = "Crud Lugares";
            this.btnLugar.UseVisualStyleBackColor = true;
            this.btnLugar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPais
            // 
            this.btnPais.FlatAppearance.BorderSize = 0;
            this.btnPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPais.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPais.ForeColor = System.Drawing.Color.White;
            this.btnPais.Location = new System.Drawing.Point(22, 124);
            this.btnPais.Name = "btnPais";
            this.btnPais.Size = new System.Drawing.Size(177, 63);
            this.btnPais.TabIndex = 2;
            this.btnPais.Text = "Crud Paises";
            this.btnPais.UseVisualStyleBackColor = true;
            this.btnPais.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 91);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Airport";
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(1113, 16);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(32, 39);
            this.button9.TabIndex = 2;
            this.button9.Text = "X";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button9_MouseDown);
            this.button9.MouseLeave += new System.EventHandler(this.button9_MouseLeave);
            this.button9.MouseHover += new System.EventHandler(this.button9_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(219, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(938, 10);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(219, 675);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(938, 10);
            this.panel4.TabIndex = 5;
            // 
            // panelPais
            // 
            this.panelPais.BackColor = System.Drawing.Color.Transparent;
            this.panelPais.Controls.Add(this.crudPaises1);
            this.panelPais.Location = new System.Drawing.Point(286, 124);
            this.panelPais.Name = "panelPais";
            this.panelPais.Size = new System.Drawing.Size(797, 532);
            this.panelPais.TabIndex = 6;
            // 
            // crudPaises1
            // 
            this.crudPaises1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crudPaises1.BackColor = System.Drawing.Color.Transparent;
            this.crudPaises1.Location = new System.Drawing.Point(0, 0);
            this.crudPaises1.Margin = new System.Windows.Forms.Padding(12, 16, 12, 16);
            this.crudPaises1.Name = "crudPaises1";
            this.crudPaises1.Size = new System.Drawing.Size(790, 460);
            this.crudPaises1.TabIndex = 0;
            // 
            // Window_Admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1157, 685);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPais);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Window_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window_Admin";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPais.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPais;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLugar;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnTarijas_Vuelo;
        private System.Windows.Forms.Button btnTarijas_Hotel;
        private System.Windows.Forms.Button btnHoteles;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Button btnAeropuerto;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panelLed;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelPais;
        private CrudPaises crudPaises1;
    }
}