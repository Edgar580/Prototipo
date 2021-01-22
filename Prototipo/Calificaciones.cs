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
        DataSet1TableAdapters.CalificacionTableAdapter DB;
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
            DB = new DataSet1TableAdapters.CalificacionTableAdapter();
        }

        private void Calificaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Profesor' Puede moverla o quitarla según sea necesario.
            this.profesorTableAdapter.Fill(this.dataSet1.Profesor);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Asignatura' Puede moverla o quitarla según sea necesario.
            this.asignaturaTableAdapter.Fill(this.dataSet1.Asignatura);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Estudiante' Puede moverla o quitarla según sea necesario.
            this.estudianteTableAdapter.Fill(this.dataSet1.Estudiante);

        }

        private void Estudiantes_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB.InsertQuery(Convert.ToInt32(ComboBoxAsignatura.SelectedValue), 1, Convert.ToInt32(ComboBoxEstudiante.SelectedValue), Convert.ToDouble(TextBoxCalificacion.Text));
                MessageBox.Show("Agregado con exito");
                TextBoxCalificacion.Clear();
                ComboBoxAsignatura.SelectedIndex = 0;
                ComboBoxEstudiante.SelectedIndex = 0;
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }
    }
}
