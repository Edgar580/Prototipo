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
    public partial class Estudiante : Form
    {
        private readonly static Estudiante _instance = new Estudiante();



        public static Estudiante Instance
        {
            get
            {
                return _instance;
            }
        }
        public Estudiante()
        {
            InitializeComponent();
        }

        private void Estudiante_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Estudiantes_Click(object sender, EventArgs e)
        {

        }
    }
}
