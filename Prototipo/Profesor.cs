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
    public partial class Profesor : Form
    {
        private readonly static Profesor _instance = new Profesor();



        public static Profesor Instance
        {
            get
            {
                return _instance;
            }
        }
        public Profesor()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Profesor_Load(object sender, EventArgs e)
        {

        }
    }
}
