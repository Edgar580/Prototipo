
namespace Prototipo
{
    partial class Calificaciones
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
            this.components = new System.ComponentModel.Container();
            this.Estudiantes = new System.Windows.Forms.Label();
            this.ComboBoxEstudiante = new System.Windows.Forms.ComboBox();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Prototipo.DataSet1();
            this.label_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxAsignatura = new System.Windows.Forms.ComboBox();
            this.asignaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxCalificacion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.estudianteTableAdapter = new Prototipo.DataSet1TableAdapters.EstudianteTableAdapter();
            this.asignaturaTableAdapter = new Prototipo.DataSet1TableAdapters.AsignaturaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesorTableAdapter = new Prototipo.DataSet1TableAdapters.ProfesorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Estudiantes
            // 
            this.Estudiantes.AutoSize = true;
            this.Estudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estudiantes.Location = new System.Drawing.Point(109, 9);
            this.Estudiantes.Name = "Estudiantes";
            this.Estudiantes.Size = new System.Drawing.Size(228, 37);
            this.Estudiantes.TabIndex = 12;
            this.Estudiantes.Text = "Calificaciones";
            this.Estudiantes.Click += new System.EventHandler(this.Estudiantes_Click);
            // 
            // ComboBoxEstudiante
            // 
            this.ComboBoxEstudiante.DataSource = this.estudianteBindingSource;
            this.ComboBoxEstudiante.DisplayMember = "Nombre";
            this.ComboBoxEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEstudiante.FormattingEnabled = true;
            this.ComboBoxEstudiante.Location = new System.Drawing.Point(93, 90);
            this.ComboBoxEstudiante.Name = "ComboBoxEstudiante";
            this.ComboBoxEstudiante.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxEstudiante.TabIndex = 13;
            this.ComboBoxEstudiante.ValueMember = "Id";
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "Estudiante";
            this.estudianteBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ID.Location = new System.Drawing.Point(12, 90);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(75, 18);
            this.label_ID.TabIndex = 14;
            this.label_ID.Text = "Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Asignatura";
            // 
            // ComboBoxAsignatura
            // 
            this.ComboBoxAsignatura.DataSource = this.asignaturaBindingSource;
            this.ComboBoxAsignatura.DisplayMember = "Nombre";
            this.ComboBoxAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAsignatura.FormattingEnabled = true;
            this.ComboBoxAsignatura.Location = new System.Drawing.Point(96, 131);
            this.ComboBoxAsignatura.Name = "ComboBoxAsignatura";
            this.ComboBoxAsignatura.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxAsignatura.TabIndex = 17;
            this.ComboBoxAsignatura.ValueMember = "Id";
            // 
            // asignaturaBindingSource
            // 
            this.asignaturaBindingSource.DataMember = "Asignatura";
            this.asignaturaBindingSource.DataSource = this.dataSet1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(223, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Calificacion";
            // 
            // TextBoxCalificacion
            // 
            this.TextBoxCalificacion.Location = new System.Drawing.Point(316, 132);
            this.TextBoxCalificacion.Name = "TextBoxCalificacion";
            this.TextBoxCalificacion.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCalificacion.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 217);
            this.dataGridView1.TabIndex = 23;
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // asignaturaTableAdapter
            // 
            this.asignaturaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 24;
            this.button1.Text = "Grabar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(214, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Profesor";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.profesorBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(295, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "Id";
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataMember = "Profesor";
            this.profesorBindingSource.DataSource = this.dataSet1;
            // 
            // profesorTableAdapter
            // 
            this.profesorTableAdapter.ClearBeforeFill = true;
            // 
            // Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TextBoxCalificacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBoxAsignatura);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.ComboBoxEstudiante);
            this.Controls.Add(this.Estudiantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calificaciones";
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.Calificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Estudiantes;
        private System.Windows.Forms.ComboBox ComboBoxEstudiante;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxAsignatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxCalificacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private DataSet1TableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private System.Windows.Forms.BindingSource asignaturaBindingSource;
        private DataSet1TableAdapters.AsignaturaTableAdapter asignaturaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private DataSet1TableAdapters.ProfesorTableAdapter profesorTableAdapter;
    }
}