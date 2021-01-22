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
        int Id;
        DataSet1TableAdapters.AsignaturaTableAdapter DB;
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
            DB = new DataSet1TableAdapters.AsignaturaTableAdapter();
        }

        private void Asignaturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Asignatura' Puede moverla o quitarla según sea necesario.
            this.asignaturaTableAdapter.Fill(this.dataSet1.Asignatura);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ComboBoxPrerrequisitos.Visible = true;
            }
            else
            {
                ComboBoxPrerrequisitos.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (Convert.ToString(DB.ValidarDuplicados(TextBoxClave.Text)) != null)
                {
                    MessageBox.Show("Esta asignatura ya existe");
                }
                else
                {
                    if (checkBox1.Checked)
                    {
                        DB.InsertQuery(TextBoxClave.Text, TextBoxNombre.Text, Convert.ToInt32(TextBoxCreditos.Text), ComboBoxPrerrequisitos.Text);
                    }
                    else
                    {
                        DB.InsertQuery(TextBoxClave.Text, TextBoxNombre.Text, Convert.ToInt32(TextBoxCreditos.Text), "No tiene");
                    }

                    MessageBox.Show("Agregado con exito");

                }
               
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
                if (checkBox1.Checked)
                {
                    DB.UpdateQuery(TextBoxClave.Text, TextBoxNombre.Text, Convert.ToInt32(TextBoxCreditos.Text), ComboBoxPrerrequisitos.Text,Id);
                }
                else
                {
                    DB.UpdateQuery(TextBoxClave.Text, TextBoxNombre.Text, Convert.ToInt32(TextBoxCreditos.Text), "No tiene",Id);
                }
                MessageBox.Show("editado con exito");
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
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
        public void CargarDatos(DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                TextBoxClave.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TextBoxNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                TextBoxCreditos.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                ComboBoxPrerrequisitos.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
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
