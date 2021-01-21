
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
            this.Estudiantes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 286);
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
            // Indice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 425);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Estudiantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Indice";
            this.Text = "Indice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Estudiantes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton Nombre;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}