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
        int Id;
        DataSet1TableAdapters.EstudianteTableAdapter DB;
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
            DB = new DataSet1TableAdapters.EstudianteTableAdapter();
        }

        private void Estudiante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Carrera' Puede moverla o quitarla según sea necesario.
            this.carreraTableAdapter.Fill(this.dataSet1.Carrera);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DB.ValidarDuplicado(TextBoxNombre.Text) != null)
            {
                MessageBox.Show("Esta estudiante ya existe");
            }
            else{


            }
            if (TextBoxNombre.Text != "")
            {
                try
                {
                    DB.InsertQuery(TextBoxNombre.Text, Convert.ToInt32(ComboBoxCarrera.SelectedValue));
                    MessageBox.Show("Agregado con exito");
                }
                catch (Exception EX)
                {

                    MessageBox.Show(EX.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe llenar los campos");
            }


        }
        public void CargarDatos(DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                TextBoxNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                ComboBoxCarrera.SelectedValue = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DB.UpdateQuery(TextBoxNombre.Text, Convert.ToInt32(ComboBoxCarrera.SelectedValue), Id);
                MessageBox.Show("Editado con exito");
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }

        }

        private void Estudiantes_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DB.DeleteQuery(Id);
                MessageBox.Show("Eliminado con exito");
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = DB.GetData();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatos(e);
        }
    }
}
