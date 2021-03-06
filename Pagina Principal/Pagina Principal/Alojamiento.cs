﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Aero_Negocio;
using Data_Base;
using Npgsql;

namespace Pagina_Principal
{
    public partial class Form2 : Form
    {
        int cntPersonas, cntHabi, cntAdultos, cntMenores;
        SqlDataAdapter adapta = new SqlDataAdapter();
        SqlConnection cn = new SqlConnection();
        SqlCommand sqlseleccion = new SqlCommand();
        DataSet datos = new DataSet();
        String [] infoHoteles = { };
        alojamiento alo = new alojamiento();
        string dato;
        int cedu;
        Conexio_BaseDatos conexion1 = new Conexio_BaseDatos();
        AutoCompleteStringCollection source = new AutoCompleteStringCollection();
        int cantidadDias;
        string[] paths = { };

        int codigo;
        string nombre, pais, lugar;
        string nombreuser;
        int precio;

        public Form2(int cedula, string nombreUsuario)
        {
            InitializeComponent();
            this.CenterToScreen();
            panelPersonas.Visible = true;
            cedu = cedula;
            nombreuser = nombreUsuario;
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            //contextMenuStrip1.Show(numericUpDown1, 1, numericUpDown1.Height);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Alojamientos c = new Alojamientos();
            //c.autoCompletar(textBox1);
            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //CONSTRUCT TEXT COLUMNS
            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[0].Width = 132;
            dataGridView1.Columns[1].Width = 133;
            dataGridView1.Columns[2].Width = 132;
            dataGridView1.Columns[3].Width = 132;
            dataGridView1.Columns[4].Width = 132;

            dataGridView1.Columns[0].Name = "CODIGO";
            dataGridView1.Columns[1].Name = "NOMBRE";
            dataGridView1.Columns[2].Name = "LUGAR";
            dataGridView1.Columns[3].Name = "PAIS";
            dataGridView1.Columns[4].Name = "PRECIO";
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDias.Text = "";
            DateTime llegada = DateTime.Parse(dataTLlegada.Text);
            DateTime salida = DateTime.Parse(dateTPSalida.Text);
            TimeSpan dias = llegada - salida;
            cantidadDias = dias.Days;
            lblDias.Text += "Total Dias " + cantidadDias.ToString();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
     
            if(cantidadDias!= 0 & cntHabi!=0 & cntPersonas!=0)
            {
                string hotel = textBox1.Text;
                MessageBox.Show("Has reservado un hotel con " + spinnerHab.Value.ToString());
            }
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un Hotel!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Reservar();
                //Close();
            }
        }
        public void Reservar()
        {//este metodo lo que hace es capturar la informacion de la pantanlla para guardarla en la tabla de las reservas.
            alojamiento alo = new alojamiento();
            DateTime llegada = DateTime.Parse(dataTLlegada.Text);
            DateTime salida = DateTime.Parse(dateTPSalida.Text);
            int cantiHabitacio = Convert.ToInt32(spinnerHab.Value);
            int precioHotelMas13 = (((cantiHabitacio * precio) *13) /100)* cantidadDias;
            int precioTotal = precio + precioHotelMas13;
            try
            {
                if (cantiHabitacio == 0)
                {
                    MessageBox.Show("Debe seleccionar la cantida de habitaciones.", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (codigo == 0 || nombre.Equals("") || lugar.Equals("") || pais.Equals("") || precio == 0)
                    {
                        MessageBox.Show("Debe seleccionar la fila del Hotel para poder Reservarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        alo.InsertarReserva("INSERT INTO reservas (cedula, niños, adultos, id_hotel, total_hotel, nombre, fecha_inicio, fecha_final, fin_pais_destino, nombre_hotel, tipo_accion, canti_habitaciones) " +
                        "VALUES ( '" + cedu + "', '" + cntMenores + "', '" + cntAdultos + "', '" + codigo + "', '" + precioTotal + "', '" + nombreuser + "', '" + dateTPSalida.Value + "', '" + dataTLlegada.Value + "', '" + pais + "', '" + nombre + "', '" + false + "', '" + cantiHabitacio + "')");
                        MessageBox.Show("Se ha registrado la reserva!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                   
                }
            }
           
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            reservasYcompras compras = new reservasYcompras(cedu, nombreuser);
            compras.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_User regresar = new Menu_User(cedu, nombreuser);
            regresar.Show();
        }

        private void spinnerHab_ValueChanged(object sender, EventArgs e)
        {
            cntHabi = Convert.ToInt32(spinnerHab.Value.ToString()) * 4;
            MessageBox.Show("Habi " + cntHabi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codigo = 0;
            nombre = "";
            pais = "";
            lugar = "";
            nombreuser = "";
            precio = 0;
            pictureBox1.Image = null;

            cargarListView();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 90;
            }
        }

        private void rbtLugar_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["LUGAR"], ListSortDirection.Ascending);

        }

        private void panelPersonas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void spinerMenores_ValueChanged(object sender, EventArgs e)
        {
            cntPersonas = 0;
            cntMenores = 0;
            cntMenores = Convert.ToInt32(spinerMenores.Value.ToString());
            cntPersonas = cntMenores + cntAdultos;
            if (cntPersonas <= cntHabi)
            {
                spinerMenores.Enabled = true;
            }
            else
            {
                spinerMenores.Value = cntMenores - 1;
            }
        }

        private void optPrecioMenorPais_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["PRECIO"], ListSortDirection.Descending);
        }

        private void optPrecioMayorPais_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["PRECIO"], ListSortDirection.Ascending);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {// este evento lo que hace es mostrar la imagen del hotel en pantalla
            Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 5)
            {
                codigo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CODIGO"].Value.ToString());
                nombre = dataGridView1.SelectedRows[0].Cells["NOMBRE"].Value.ToString();
                lugar = dataGridView1.SelectedRows[0].Cells["LUGAR"].Value.ToString();
                pais = dataGridView1.SelectedRows[0].Cells["PAIS"].Value.ToString();
                precio = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PRECIO"].Value.ToString());

                alojamiento alo = new alojamiento();
                try
                {
                    string foto = alo.TraerInfo("SELECT foto FROM hoteles WHERE codigo = '" + dataGridView1.CurrentRow.Cells[0].Value + "'");
                    Bitmap foto2 = new Bitmap(foto);
                    pictureBox1.Image = (Image)foto2;

                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe estar la fila selecciona para poder Reservar el Hotel.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void spinnerAdultos_ValueChanged(object sender, EventArgs e)
        {
            cntPersonas = 0;
            cntAdultos = 0;
            cntAdultos = Convert.ToInt32(spinnerAdultos.Value.ToString());
            cntPersonas = cntMenores + cntAdultos;
            if (cntPersonas <= cntHabi)
            {
                spinnerAdultos.Enabled = true;
            }
            else
            {
                spinnerAdultos.Value = cntAdultos - 1;
            }
        }


        public void cargarListView()
        {//este metodo lo que hace es mostrar la informacion de los hoteles y mostralos en el datagridview
            dataGridView1.Rows.Clear();
            dato = "";
            dato = textBox1.Text;


            Alojamientos aloja = new Alojamientos();
            ListViewItem item = new ListViewItem();
            if (dato.Equals(""))
            {
                MessageBox.Show("Debe ingresar el nombre, pais o lugar");
            }
            else
            {
                aloja.cargarDatos(dato, dataGridView1);
                
            }
        }

    }
}

