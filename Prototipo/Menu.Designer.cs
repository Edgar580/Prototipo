﻿namespace Prototipo
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_calificaiones = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label_calificaiones = new System.Windows.Forms.Label();
            this.panel_estudiantes = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_estudiantes = new System.Windows.Forms.Label();
            this.panel_inicio = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_inicio = new System.Windows.Forms.Label();
            this.panel_profesores = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_profesores = new System.Windows.Forms.Label();
            this.panel_asignaturas = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_asignaturas = new System.Windows.Forms.Label();
            this.panel_salir = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label_salir = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_menu.SuspendLayout();
            this.panel_calificaiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel_estudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_profesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_asignaturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel_salir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_menu.Controls.Add(this.panel1);
            this.panel_menu.Controls.Add(this.panel_calificaiones);
            this.panel_menu.Controls.Add(this.panel_estudiantes);
            this.panel_menu.Controls.Add(this.panel_inicio);
            this.panel_menu.Location = new System.Drawing.Point(1, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(211, 449);
            this.panel_menu.TabIndex = 0;
            this.panel_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_menu_Paint);
            // 
            // panel_calificaiones
            // 
            this.panel_calificaiones.BackColor = System.Drawing.Color.Gray;
            this.panel_calificaiones.Controls.Add(this.pictureBox5);
            this.panel_calificaiones.Controls.Add(this.label_calificaiones);
            this.panel_calificaiones.Location = new System.Drawing.Point(0, 236);
            this.panel_calificaiones.Name = "panel_calificaiones";
            this.panel_calificaiones.Size = new System.Drawing.Size(211, 53);
            this.panel_calificaiones.TabIndex = 3;
            this.panel_calificaiones.Click += new System.EventHandler(this.panel_calificaiones_Click);
            this.panel_calificaiones.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_calificaiones_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.ImageLocation = "C:\\Users\\Alan\\Desktop\\iconos\\estudiante.png";
            this.pictureBox5.Location = new System.Drawing.Point(11, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // label_calificaiones
            // 
            this.label_calificaiones.AutoSize = true;
            this.label_calificaiones.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_calificaiones.ForeColor = System.Drawing.Color.White;
            this.label_calificaiones.Location = new System.Drawing.Point(49, 12);
            this.label_calificaiones.Name = "label_calificaiones";
            this.label_calificaiones.Size = new System.Drawing.Size(144, 29);
            this.label_calificaiones.TabIndex = 6;
            this.label_calificaiones.Text = "Calificaciones";
            this.label_calificaiones.Click += new System.EventHandler(this.label_calificaiones_Click);
            // 
            // panel_estudiantes
            // 
            this.panel_estudiantes.BackColor = System.Drawing.Color.Gray;
            this.panel_estudiantes.Controls.Add(this.pictureBox1);
            this.panel_estudiantes.Controls.Add(this.label_estudiantes);
            this.panel_estudiantes.Location = new System.Drawing.Point(0, 59);
            this.panel_estudiantes.Name = "panel_estudiantes";
            this.panel_estudiantes.Size = new System.Drawing.Size(211, 53);
            this.panel_estudiantes.TabIndex = 1;
            this.panel_estudiantes.Visible = false;
            this.panel_estudiantes.Click += new System.EventHandler(this.panel_estudiantes_Click);
            this.panel_estudiantes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_estudiantes_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\Alan\\Desktop\\iconos\\estudiante.png";
            this.pictureBox1.Location = new System.Drawing.Point(11, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label_estudiantes
            // 
            this.label_estudiantes.AutoSize = true;
            this.label_estudiantes.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estudiantes.ForeColor = System.Drawing.Color.White;
            this.label_estudiantes.Location = new System.Drawing.Point(49, 14);
            this.label_estudiantes.Name = "label_estudiantes";
            this.label_estudiantes.Size = new System.Drawing.Size(125, 29);
            this.label_estudiantes.TabIndex = 4;
            this.label_estudiantes.Text = "Estudiantes";
            this.label_estudiantes.Click += new System.EventHandler(this.label_estudiantes_Click);
            // 
            // panel_inicio
            // 
            this.panel_inicio.BackColor = System.Drawing.Color.Gray;
            this.panel_inicio.Controls.Add(this.pictureBox2);
            this.panel_inicio.Controls.Add(this.label_inicio);
            this.panel_inicio.Location = new System.Drawing.Point(0, 0);
            this.panel_inicio.Name = "panel_inicio";
            this.panel_inicio.Size = new System.Drawing.Size(211, 53);
            this.panel_inicio.TabIndex = 0;
            this.panel_inicio.Click += new System.EventHandler(this.panel_inicio_Click);
            this.panel_inicio.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_inicio_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "C:\\Users\\Alan\\Desktop\\iconos\\estudiante.png";
            this.pictureBox2.Location = new System.Drawing.Point(11, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label_inicio
            // 
            this.label_inicio.AutoSize = true;
            this.label_inicio.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_inicio.ForeColor = System.Drawing.Color.White;
            this.label_inicio.Location = new System.Drawing.Point(49, 9);
            this.label_inicio.Name = "label_inicio";
            this.label_inicio.Size = new System.Drawing.Size(63, 29);
            this.label_inicio.TabIndex = 0;
            this.label_inicio.Text = "Inicio";
            this.label_inicio.Click += new System.EventHandler(this.label_inicio_Click);
            // 
            // panel_profesores
            // 
            this.panel_profesores.BackColor = System.Drawing.Color.Gray;
            this.panel_profesores.Controls.Add(this.pictureBox3);
            this.panel_profesores.Controls.Add(this.label_profesores);
            this.panel_profesores.Location = new System.Drawing.Point(1, 118);
            this.panel_profesores.Name = "panel_profesores";
            this.panel_profesores.Size = new System.Drawing.Size(211, 53);
            this.panel_profesores.TabIndex = 2;
            this.panel_profesores.Visible = false;
            this.panel_profesores.Click += new System.EventHandler(this.panel_profesores_Click);
            this.panel_profesores.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_profesores_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.ImageLocation = "C:\\Users\\Alan\\Desktop\\iconos\\estudiante.png";
            this.pictureBox3.Location = new System.Drawing.Point(11, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label_profesores
            // 
            this.label_profesores.AutoSize = true;
            this.label_profesores.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profesores.ForeColor = System.Drawing.Color.White;
            this.label_profesores.Location = new System.Drawing.Point(49, 10);
            this.label_profesores.Name = "label_profesores";
            this.label_profesores.Size = new System.Drawing.Size(117, 29);
            this.label_profesores.TabIndex = 5;
            this.label_profesores.Text = "Profesores";
            // 
            // panel_asignaturas
            // 
            this.panel_asignaturas.BackColor = System.Drawing.Color.Gray;
            this.panel_asignaturas.Controls.Add(this.pictureBox4);
            this.panel_asignaturas.Controls.Add(this.label_asignaturas);
            this.panel_asignaturas.Location = new System.Drawing.Point(1, 177);
            this.panel_asignaturas.Name = "panel_asignaturas";
            this.panel_asignaturas.Size = new System.Drawing.Size(211, 53);
            this.panel_asignaturas.TabIndex = 3;
            this.panel_asignaturas.Visible = false;
            this.panel_asignaturas.Click += new System.EventHandler(this.panel_asignaturas_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.ImageLocation = "C:\\Users\\Alan\\Desktop\\iconos\\estudiante.png";
            this.pictureBox4.Location = new System.Drawing.Point(11, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // label_asignaturas
            // 
            this.label_asignaturas.AutoSize = true;
            this.label_asignaturas.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_asignaturas.ForeColor = System.Drawing.Color.White;
            this.label_asignaturas.Location = new System.Drawing.Point(49, 13);
            this.label_asignaturas.Name = "label_asignaturas";
            this.label_asignaturas.Size = new System.Drawing.Size(127, 29);
            this.label_asignaturas.TabIndex = 6;
            this.label_asignaturas.Text = "Asignaturas";
            this.label_asignaturas.Click += new System.EventHandler(this.label_asignaturas_Click);
            // 
            // panel_salir
            // 
            this.panel_salir.BackColor = System.Drawing.Color.Gray;
            this.panel_salir.Controls.Add(this.pictureBox6);
            this.panel_salir.Controls.Add(this.label_salir);
            this.panel_salir.Location = new System.Drawing.Point(1, 380);
            this.panel_salir.Name = "panel_salir";
            this.panel_salir.Size = new System.Drawing.Size(211, 53);
            this.panel_salir.TabIndex = 3;
            this.panel_salir.Click += new System.EventHandler(this.panel_salir_Click);
            this.panel_salir.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_salir_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.ImageLocation = "C:\\Users\\Alan\\Desktop\\iconos\\estudiante.png";
            this.pictureBox6.Location = new System.Drawing.Point(11, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // label_salir
            // 
            this.label_salir.AutoSize = true;
            this.label_salir.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salir.ForeColor = System.Drawing.Color.White;
            this.label_salir.Location = new System.Drawing.Point(49, 12);
            this.label_salir.Name = "label_salir";
            this.label_salir.Size = new System.Drawing.Size(55, 29);
            this.label_salir.TabIndex = 6;
            this.label_salir.Text = "Salir";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Location = new System.Drawing.Point(218, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(583, 433);
            this.tab.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(195, 96);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(192, 190);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 53);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox8
            // 
            this.pictureBox8.ImageLocation = "C:\\Users\\Alan\\Desktop\\iconos\\estudiante.png";
            this.pictureBox8.Location = new System.Drawing.Point(11, 9);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 451);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.panel_salir);
            this.Controls.Add(this.panel_asignaturas);
            this.Controls.Add(this.panel_profesores);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_calificaiones.ResumeLayout(false);
            this.panel_calificaiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel_estudiantes.ResumeLayout(false);
            this.panel_estudiantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_inicio.ResumeLayout(false);
            this.panel_inicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_profesores.ResumeLayout(false);
            this.panel_profesores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_asignaturas.ResumeLayout(false);
            this.panel_asignaturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel_salir.ResumeLayout(false);
            this.panel_salir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_calificaiones;
        private System.Windows.Forms.Label label_estudiantes;
        private System.Windows.Forms.Label label_inicio;
        private System.Windows.Forms.Label label_profesores;
        private System.Windows.Forms.Label label_asignaturas;
        private System.Windows.Forms.Label label_salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TabControl tab;
        public System.Windows.Forms.Panel panel_menu;
        public System.Windows.Forms.Panel panel_estudiantes;
        public System.Windows.Forms.Panel panel_inicio;
        public System.Windows.Forms.Panel panel_profesores;
        public System.Windows.Forms.Panel panel_asignaturas;
        public System.Windows.Forms.Panel panel_calificaiones;
        public System.Windows.Forms.Panel panel_salir;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
    }
}