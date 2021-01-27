
namespace Prototipo
{
    partial class Indice
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ComboBoxEstudiante = new System.Windows.Forms.ComboBox();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Prototipo.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.estudianteTableAdapter = new Prototipo.DataSet1TableAdapters.EstudianteTableAdapter();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Estudiantes
            // 
            this.Estudiantes.AutoSize = true;
            this.Estudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estudiantes.Location = new System.Drawing.Point(124, 31);
            this.Estudiantes.Name = "Estudiantes";
            this.Estudiantes.Size = new System.Drawing.Size(160, 25);
            this.Estudiantes.TabIndex = 12;
            this.Estudiantes.Text = "Calificaciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(457, 267);
            this.dataGridView1.TabIndex = 13;
            // 
            // Nombre
            // 
            this.Nombre.Appearance = System.Windows.Forms.Appearance.Button;
            this.Nombre.AutoSize = true;
            this.Nombre.FlatAppearance.BorderSize = 0;
            this.Nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(12, 88);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(106, 26);
            this.Nombre.TabIndex = 14;
            this.Nombre.TabStop = true;
            this.Nombre.Text = "Indice general:";
            this.Nombre.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Location = new System.Drawing.Point(112, 91);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(38, 23);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "4.00";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ComboBoxEstudiante
            // 
            this.ComboBoxEstudiante.DataSource = this.estudianteBindingSource;
            this.ComboBoxEstudiante.DisplayMember = "Nombre";
            this.ComboBoxEstudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEstudiante.FormattingEnabled = true;
            this.ComboBoxEstudiante.Location = new System.Drawing.Point(307, 68);
            this.ComboBoxEstudiante.Name = "ComboBoxEstudiante";
            this.ComboBoxEstudiante.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxEstudiante.TabIndex = 16;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Estudiante";
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Location = new System.Drawing.Point(307, 94);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 23);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No tiene";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.AutoSize = true;
            this.radioButton3.FlatAppearance.BorderSize = 0;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(231, 91);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 26);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Honores";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Indice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBoxEstudiante);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Estudiantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Indice";
            this.Text = "Indice";
            this.Load += new System.EventHandler(this.Indice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Estudiantes;
        private System.Windows.Forms.RadioButton Nombre;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ComboBoxEstudiante;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private DataSet1TableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
    }
}