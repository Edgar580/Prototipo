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
    public partial class Asignaturas : Form
    {
        private readonly static Asignaturas _instance = new Asignaturas();



        public static Asignaturas Instance
        {
            get
            {
                return _instance;
            }
        }
        public Asignaturas()
        {
            InitializeComponent();
        }

        private void Asignaturas_Load(object sender, EventArgs e)
        {

        }
    }
}
