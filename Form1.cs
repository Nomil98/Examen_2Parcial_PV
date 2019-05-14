using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resolución_Examen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Rol> Roles2 = new List<Rol>();
        Dictionary<int, Rol> Roles = new Dictionary<int, Rol>();
        

        private void txtRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSalida.Items.Clear();
            if(txtRuta.Text== "Ruta 1")
            {
                txtSalida.Items.Add("6:00am");
                txtSalida.Items.Add("6:30am");
                txtSalida.Items.Add("7:00am");
                txtSalida.Items.Add("7:30am");
            }
            else if (txtRuta.Text == "Ruta 2")
            {
                txtSalida.Items.Add("7:15am");
                txtSalida.Items.Add("7:40am");
                txtSalida.Items.Add("8:10am");
                txtSalida.Items.Add("8:50am");
            }
            else if (txtRuta.Text == "Ruta 10")
            {
                txtSalida.Items.Add("9:15am");
                txtSalida.Items.Add("9:40am");
                txtSalida.Items.Add("10:10am");
                txtSalida.Items.Add("10:50am");
            }
            else if (txtRuta.Text == "Ruta 21")
            {
                txtSalida.Items.Add("11:15am");
                txtSalida.Items.Add("11:40am");
                txtSalida.Items.Add("12:10am");
                txtSalida.Items.Add("12:50am");
            }
            txtSalida.SelectedIndex = 0;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Rol MiRol;
            int numero = Convert.ToInt32(txtEco.Text);
            MiRol = new Rol(numero, txtChofer.Text, txtRuta.Text, txtSalida.Text);
            listareporte.Items.Add(MiRol.ToString());
            Roles.Add(numero, MiRol);


        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtEco.Text);
            int pos = -1;
            for (int i = 0; pos == -1 && i < Roles2.Count; i++)
                if (numero == Roles2[i].Economico)
                    pos = i;
            if(pos != -1)
            {
                listareporte.SelectedIndex = pos;
                txtSalida.Text = Roles2[pos].Salida;
                txtChofer.Text = Roles2[pos].Chofer;            }
            
        }
    }
}
