using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_Olvidaste_Clave_CursorChanged(object sender, EventArgs e)
        {
            label_Olvidaste_Clave.ForeColor = Color.Blue;
        }

        private void button_Acceder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBox1.SelectedIndex) == 1)
            {
                panel_login.BackColor = Color.Blue;
                panel_Superior.BackColor = Color.Blue;
                panel_inferior.BackColor = Color.Blue;
            }
            else if (Convert.ToInt32(comboBox1.SelectedIndex) == 2)
            {
                panel_login.BackColor = Color.Black;
                panel_Superior.BackColor = Color.Black;
                panel_inferior.BackColor = Color.Black;
            }
            else if (Convert.ToInt32(comboBox1.SelectedIndex) == 3)
            {
                panel_login.BackColor = Color.Green;
                panel_Superior.BackColor = Color.Green;
                panel_inferior.BackColor = Color.Green;
            }
            else if (Convert.ToInt32(comboBox1.SelectedIndex) == 0)
            {
                panel_login.BackColor = Color.Red;
                panel_Superior.BackColor = Color.Red;
                panel_inferior.BackColor = Color.Red;
            }
        }

        private void label_Nombre_Aplicacion_Click(object sender, EventArgs e)
        {

        }

        private void panel_Superior_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
