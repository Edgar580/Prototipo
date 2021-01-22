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
    public partial class Usuarios : Form
    {

        int Id;
        DataSet1TableAdapters.UsuariosTableAdapter DB;
        private readonly static Usuarios _instance = new Usuarios();



        public static Usuarios Instance
        {
            get
            {
                return _instance;
            }
        }
        public Usuarios()
        {
            InitializeComponent();
            DB = new DataSet1TableAdapters.UsuariosTableAdapter();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.dataSet1.Rol);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DB.ValidarDuplicados(TextBoxNombre.Text) != null)
            {
                MessageBox.Show("Ya existe");
            }
            else
            {
                if (TextBoxNombre.Text != "")
                {
                    try
                    {

                        DB.InsertQuery(TextBoxNombre.Text, TextBoxClave.Text, Convert.ToInt32(ComboBoxRol.SelectedValue));
                        MessageBox.Show("Creado con exito");
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
            
            

        }
        public void CargarDatos(DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                TextBoxNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TextBoxClave.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                ComboBoxRol.SelectedValue = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
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
                DB.UpdateQuery(TextBoxNombre.Text, TextBoxClave.Text, Convert.ToInt32(ComboBoxRol.SelectedValue),Id);
                MessageBox.Show("Modificar con exito");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatos(e);
        }
    }
}
