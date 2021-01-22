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
    public partial class Reporte_de_calificaciones : Form
    {
        DataSet1TableAdapters.ReporteTotalTableAdapter DB;
        private readonly static Reporte_de_calificaciones _instance = new Reporte_de_calificaciones();



        public static Reporte_de_calificaciones Instance
        {
            get
            {
                return _instance;
            }
        }
        public Reporte_de_calificaciones()
        {
            InitializeComponent();
            DB = new DataSet1TableAdapters.ReporteTotalTableAdapter();
        }

        private void Reporte_de_calificaciones_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.GetData();
        }
    }
}
