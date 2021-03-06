﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Aero_Negocio;

namespace Pagina_Principal
{
    public partial class Form1 : Form
    {
        string nombre;
        int usuario;
        public Form1()
        {
            InitializeComponent();
        }
        
        public void verificarUser()
        {
            try
            {
                string tipo_user;
                usuario = Convert.ToInt32(txtNombre.Text);
                string clave = txtPassword.Text;
                if (usuario.Equals("") && clave.Equals(""))
                {
                    MessageBox.Show("No pueden quedar espacios vacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Users consultar = new Users();
                    tipo_user = consultar.encriptar_clave(usuario, clave);
                    if (tipo_user.Equals("T"))
                    {
                        //vetana administrado
                        this.Hide();
                        Window_Admin admin = new Window_Admin();
                        admin.Show();

                    }
                    else if (tipo_user.Equals("U"))
                    {
                        //vetana usuario
                        ExtraerNombre();
                        this.Hide();
                        Menu_User ver = new Menu_User(usuario, nombre);
                        ver.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No pueden quedar espacios vacios..", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verificarUser();
        }

        private void btnCerrar_MouseDown(object sender, MouseEventArgs e)
        {
            string message = "Desea cerrar la aplicación";
            string captura = "Advertencia";
            MessageBoxButtons boton = MessageBoxButtons.YesNo;
            MessageBoxIcon boton2 = MessageBoxIcon.Warning;
            DialogResult result;

            result = MessageBox.Show(message, captura, boton, boton2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.White;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.ForeColor = Color.SkyBlue;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            window_registry ventana = new window_registry();
            ventana.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.btnCerrar, "Cerrar aplicación.");
           
        }
        public void ExtraerNombre()
        {
            alojamiento alo = new alojamiento();
            nombre= alo.TraerInfo("SELECT name FROM admin_user WHERE cedula = '" +usuario +"'");
        }
    }
    
}
