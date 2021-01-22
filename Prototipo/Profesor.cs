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
        int Id;
        DataSet1TableAdapters.ProfesorTableAdapter DB;
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
            DB = new DataSet1TableAdapters.ProfesorTableAdapter();

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
        public void CargarDatos(DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                TextBoxNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
               
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (DB.ValidarDuplicados(TextBoxNombre.Text) != null)
            {
                MessageBox.Show("Este Profesor ya existe");
            }
            if (TextBoxNombre.Text != "")
            {
                try
                {
                    DB.InsertQuery(TextBoxNombre.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DB.UpdateQuery(TextBoxNombre.Text,Id);
                MessageBox.Show("Editado con exito");
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
