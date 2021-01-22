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
    public partial class Indice : Form
    {
        DataSet1TableAdapters.CalificacionTableAdapter DBC;
        DataSet1TableAdapters.AsignaturaTableAdapter DBA;
        DataSet1TableAdapters.ReporteCalificacionTableAdapter DBR;
        private readonly static Indice _instance = new Indice();



        public static Indice Instance
        {
            get
            {
                return _instance;
            }
        }
        public Indice()
        {
            InitializeComponent();
            DBC = new DataSet1TableAdapters.CalificacionTableAdapter();
            DBA = new DataSet1TableAdapters.AsignaturaTableAdapter();
            DBR = new DataSet1TableAdapters.ReporteCalificacionTableAdapter();
        }

        private void Indice_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Estudiante' Puede moverla o quitarla según sea necesario.
            this.estudianteTableAdapter.Fill(this.dataSet1.Estudiante);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Indice = 0.00;
            double creditostotales = 0;
            double puntajeindividual = 0;
            double puntosTotales = 0;
            double calificacion = 0.00;
            dataGridView1.DataSource = DBR.GetData(Convert.ToInt32(ComboBoxEstudiante.SelectedValue));
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                double Creditos = Convert.ToInt32(DBA.GetCreditos(dataGridView1.Rows[i].Cells[1].Value.ToString()));

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) >= 90)
                {
                    calificacion = 4;
                    puntajeindividual = Creditos * calificacion;
                    puntosTotales = puntosTotales + puntajeindividual;
                    creditostotales = creditostotales + Creditos;
                    //dataGridView1.Rows[i].Cells[4].Value = "A";



                }
                else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) >= 85 && Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) < 90)
                {
                    calificacion = 3.5;
                    puntajeindividual = Creditos * calificacion;
                    puntosTotales = puntosTotales + puntajeindividual;
                    creditostotales = creditostotales + Creditos;
                    //dataGridView1.Rows[i].Cells[4].Value = "B+";
                }
                else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) >= 80 && Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) < 85)
                {
                    calificacion = 3;
                    puntajeindividual = Creditos * calificacion;
                    puntosTotales = puntosTotales + puntajeindividual;
                    creditostotales = creditostotales + Creditos;
                    //dataGridView1.Rows[i].Cells[4].Value = "B";
                }
                else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) >= 75 && Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) < 80)
                {
                    calificacion = 2.5;
                    puntajeindividual = Creditos * calificacion;
                    puntosTotales = puntosTotales + puntajeindividual;
                    creditostotales = creditostotales + Creditos;
                    //dataGridView1.Rows[i].Cells[4].Value = "C+";
                }
                else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) >= 70 && Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) < 75)
                {
                    calificacion = 2;
                    puntajeindividual = Creditos * calificacion;
                    puntosTotales = puntosTotales + puntajeindividual;
                    creditostotales = creditostotales + Creditos;
                    //dataGridView1.Rows[i].Cells[4].Value = "C";
                }
                else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) >= 60 && Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) < 69)
                {
                    calificacion = 1;
                    puntajeindividual = Creditos * calificacion;
                    puntosTotales = puntosTotales + puntajeindividual;
                    creditostotales = creditostotales + Creditos;
                    //dataGridView1.Rows[i].Cells[4].Value = "D";
                }
                else if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) < 60)
                {
                    calificacion = 0;
                    puntajeindividual = Creditos * calificacion;
                    puntosTotales = puntosTotales + puntajeindividual;
                    creditostotales = creditostotales + Creditos;
                    //dataGridView1.Rows[i].Cells[4].Value = "F";
                }




            }
            Indice = puntosTotales / creditostotales;

            radioButton1.Text = Indice.ToString();

            if (Indice > 3.8)
            {
                radioButton2.Text = "Summa Cum lauden";
            }
            if (Indice > 3.5 && Indice < 3.8)
            {
                radioButton2.Text = "Magna Cum lauden";
            }
            if (Indice > 3.2 && Indice < 3.5)
            {
                radioButton2.Text = " Cum lauden";
            }
            if (Indice < 3.2)
            {
                radioButton2.Text = " Sin honores";
            }
        }
    }
}
