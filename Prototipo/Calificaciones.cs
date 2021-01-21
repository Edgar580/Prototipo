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
    public partial class Calificaciones : Form
    {
        private readonly static Calificaciones _instance = new Calificaciones();



        public static Calificaciones Instance
        {
            get
            {
                return _instance;
            }
        }
        public Calificaciones()
        {
            InitializeComponent();
        }

        private void Calificaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
