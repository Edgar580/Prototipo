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
    public partial class Menu : Form
    {
        private readonly static Menu _instance = new Menu();



        public static Menu Instance
        {
            get
            {
                return _instance;
            }
        }
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormEnPanel(Form x, string title)
        {

            TabPage t = new TabPage();

            t.Text = title;

            t.AllowDrop = true;

            tab.TabPages.Add(t);

            x.TopLevel = false;

            x.Dock = DockStyle.Fill;

            x.Parent = t;

            tab.SelectedTab = t;


            //  gvp.limpiar(x);

            x.Show();




        }
        private void label_estudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(Estudiante.Instance, "Estudiante");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_salir_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_inicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_estudiantes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
