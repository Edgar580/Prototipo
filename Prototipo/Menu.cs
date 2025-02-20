﻿using System;
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
    public partial class Menu : Form
    {
        DataSet1TableAdapters.CalificacionTableAdapter DB;
        public bool Cambios;
        public bool admin;
        public int Rol;
        private readonly static Menu _instance = new Menu();



        public static Menu Instance
        {
            get
            {
                return _instance;
            }
        }
        public Menu()
        {
            InitializeComponent();
            DB = new DataSet1TableAdapters.CalificacionTableAdapter();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormEnPanel(Form x, string title)
        {

            TabPage t = new TabPage();

            t.Text = title;

            t.AllowDrop = true;

            tab.TabPages.Add(t);

            x.TopLevel = false;

            x.Dock = DockStyle.Fill;

            x.Parent = t;

            tab.SelectedTab = t;


            //  gvp.limpiar(x);

            x.Show();




        }
        private void label_estudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(Estudiante.Instance, "Estudiante");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_salir_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_inicio_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel_estudiantes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_asignaturas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(Asignaturas.Instance, "Asignaturas");
        }

        private void label_asignaturas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(Asignaturas.Instance, "Asignaturas");
        }

        private void panel_estudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(Estudiante.Instance, "Estudiante");
        }

        private void panel_inicio_Click(object sender, EventArgs e)
        {
            try
            {

                tab.SelectedTab.Controls.Clear();
                tab.TabPages.Remove(tab.SelectedTab);



            }
            catch (Exception)
            {

                MessageBox.Show("No existe pestaña para eliminar");
            }
        }

        private void label_inicio_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    tab.SelectedTab.Controls.Clear();
            //    tab.TabPages.Remove(tab.SelectedTab);


            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("No existe pestaña para eliminar");
            //}


        }

        private void panel_profesores_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_profesores_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(Profesor.Instance, "Profesor");
        }

        private void panel_calificaiones_Click(object sender, EventArgs e)
        {
            if (Rol == 1) // Estudiante
            {
                AbrirFormEnPanel(Indice.Instance, "Indice");

            }


            else if (Rol == 2) // Profesor
            {
                AbrirFormEnPanel(Calificaciones.Instance, "Calificaciones");
            }
            else if (Rol == 3) // Administrador
            {
                AbrirFormEnPanel(Reporte_de_calificaciones.Instance, "Reporte");

            }

        }

        private void label_calificaiones_Click(object sender, EventArgs e)
        {
            if (Rol == 1) // Estudiante
            {
                AbrirFormEnPanel(Indice.Instance, "Indice");
             
            }
           

            else if (Rol == 2) // Profesor
            {
                AbrirFormEnPanel(Calificaciones.Instance, "Calificaciones");
            }
           else if (Rol == 3) // Administrador
            {
                AbrirFormEnPanel(Reporte_de_calificaciones.Instance, "Reporte");

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Usuarios x = Usuarios.Instance;
            x.ShowDialog();
        }

        private void panel_calificaiones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
