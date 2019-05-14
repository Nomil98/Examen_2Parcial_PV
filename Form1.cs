using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        Rol Rutas = new Rol();
      
        private void btnguardar_Click(object sender, EventArgs e)
        {
            combo1.Items.Add(Rutas.NombreRuta(combo1.Text));
            combo2.Items.Add(Rutas.NumeroSalida(Convert.ToInt16(combo2)));
            combo3.Items.Add(Rutas.NumeroCamion(Convert.ToInt16(combo3)));
            combo4.Items.Add(Rutas.Chofer(combo4.Text));

            listBox.Text = "Ruta"+ combo1.Text + ": Salidas" + "Número de camión" +  combo2.Text + "Chofer" +  combo3.Text + combo4.Text;
        }

        private void combo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
