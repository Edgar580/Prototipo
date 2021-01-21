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
        private readonly static Inicio _instance = new Inicio();



        public static Inicio Instance
        {
            get
            {
                return _instance;
            }
        }
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
            if (Convert.ToInt32(comboBox1.SelectedIndex) == 0)
            {
                menu.panel_inicio.BackColor = Color.Red;
                menu.panel_estudiantes.BackColor = Color.Red;
                menu.panel_profesores.BackColor = Color.Red;
                menu.panel_asignaturas.BackColor = Color.Red;
                menu.panel_calificaiones.BackColor = Color.Red;
                menu.panel_salir.BackColor = Color.Red;
                menu.panel_menu.BackColor = Color.White;
                


            }
            else if (Convert.ToInt32(comboBox1.SelectedIndex) == 1)
            {
                menu.panel_inicio.BackColor = Color.Blue;
                menu.panel_estudiantes.BackColor = Color.Blue;
                menu.panel_profesores.BackColor = Color.Blue;
                menu.panel_asignaturas.BackColor = Color.Blue;
                menu.panel_calificaiones.BackColor = Color.Blue;
                menu.panel_salir.BackColor = Color.Blue;
                menu.panel_menu.BackColor = Color.White;
            }
            else if (Convert.ToInt32(comboBox1.SelectedIndex) == 2)
            {
                menu.panel_inicio.BackColor = Color.Gray;
                menu.panel_estudiantes.BackColor = Color.Gray;
                menu.panel_profesores.BackColor = Color.Gray;
                menu.panel_asignaturas.BackColor = Color.Gray;
                menu.panel_calificaiones.BackColor = Color.Gray;
                menu.panel_salir.BackColor = Color.Gray;
            }
            else if (Convert.ToInt32(comboBox1.SelectedIndex) == 3)
            {
                menu.panel_inicio.BackColor = Color.Green;
                menu.panel_estudiantes.BackColor = Color.Green;
                menu.panel_profesores.BackColor = Color.Green;
                menu.panel_asignaturas.BackColor = Color.Green;
                menu.panel_calificaiones.BackColor = Color.Green;
                menu.panel_salir.BackColor = Color.Green;
                menu.panel_menu.BackColor = Color.White;
            }
         
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
                panel_login.BackColor = Color.Gray;
                panel_Superior.BackColor = Color.Gray;
                panel_inferior.BackColor = Color.Gray;
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

        private void label_Olvidaste_Clave_MouseHover(object sender, EventArgs e)
        {
           
               
            

        }

        private void label_Olvidaste_Clave_MouseMove(object sender, MouseEventArgs e)
        {
            label_Olvidaste_Clave.ForeColor = Color.Black;
        }

        private void button_Registrar_Click(object sender, EventArgs e)
        {
            Usuarios x = Usuarios.Instance;
            x.ShowDialog();
        }

        private void richTextBox_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
