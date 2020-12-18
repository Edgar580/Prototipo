
namespace Prototipo
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.richTextBox_ID = new System.Windows.Forms.RichTextBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.button_Registrar = new System.Windows.Forms.Button();
            this.label_Olvidaste_Clave = new System.Windows.Forms.Label();
            this.button_Acceder = new System.Windows.Forms.Button();
            this.label_Clave = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.richTextBox_Clave = new System.Windows.Forms.RichTextBox();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.panel_Superior = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel_inferior = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.panel_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_ID
            // 
            this.richTextBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_ID.Location = new System.Drawing.Point(37, 52);
            this.richTextBox_ID.MaxLength = 7;
            this.richTextBox_ID.Multiline = false;
            this.richTextBox_ID.Name = "richTextBox_ID";
            this.richTextBox_ID.Size = new System.Drawing.Size(157, 23);
            this.richTextBox_ID.TabIndex = 1;
            this.richTextBox_ID.Text = "";
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.Gray;
            this.panel_login.Controls.Add(this.button_Registrar);
            this.panel_login.Controls.Add(this.label_Olvidaste_Clave);
            this.panel_login.Controls.Add(this.button_Acceder);
            this.panel_login.Controls.Add(this.label_Clave);
            this.panel_login.Controls.Add(this.label_ID);
            this.panel_login.Controls.Add(this.richTextBox_Clave);
            this.panel_login.Controls.Add(this.richTextBox_ID);
            this.panel_login.Location = new System.Drawing.Point(12, 32);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(232, 261);
            this.panel_login.TabIndex = 1;
            // 
            // button_Registrar
            // 
            this.button_Registrar.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Registrar.Location = new System.Drawing.Point(22, 183);
            this.button_Registrar.Name = "button_Registrar";
            this.button_Registrar.Size = new System.Drawing.Size(83, 33);
            this.button_Registrar.TabIndex = 8;
            this.button_Registrar.Text = "Registrar";
            this.button_Registrar.UseVisualStyleBackColor = true;
            this.button_Registrar.Click += new System.EventHandler(this.button_Registrar_Click);
            // 
            // label_Olvidaste_Clave
            // 
            this.label_Olvidaste_Clave.AutoSize = true;
            this.label_Olvidaste_Clave.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Olvidaste_Clave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_Olvidaste_Clave.Location = new System.Drawing.Point(48, 142);
            this.label_Olvidaste_Clave.Name = "label_Olvidaste_Clave";
            this.label_Olvidaste_Clave.Size = new System.Drawing.Size(136, 18);
            this.label_Olvidaste_Clave.TabIndex = 6;
            this.label_Olvidaste_Clave.Text = "¿Olvidaste tu clave?";
            this.label_Olvidaste_Clave.CursorChanged += new System.EventHandler(this.label_Olvidaste_Clave_CursorChanged);
            this.label_Olvidaste_Clave.Click += new System.EventHandler(this.label3_Click);
            this.label_Olvidaste_Clave.MouseHover += new System.EventHandler(this.label_Olvidaste_Clave_MouseHover);
            this.label_Olvidaste_Clave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_Olvidaste_Clave_MouseMove);
            // 
            // button_Acceder
            // 
            this.button_Acceder.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Acceder.Location = new System.Drawing.Point(126, 183);
            this.button_Acceder.Name = "button_Acceder";
            this.button_Acceder.Size = new System.Drawing.Size(83, 33);
            this.button_Acceder.TabIndex = 5;
            this.button_Acceder.Text = "Acceder";
            this.button_Acceder.UseVisualStyleBackColor = true;
            this.button_Acceder.Click += new System.EventHandler(this.button_Acceder_Click);
            // 
            // label_Clave
            // 
            this.label_Clave.AutoSize = true;
            this.label_Clave.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Clave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_Clave.Location = new System.Drawing.Point(85, 95);
            this.label_Clave.Name = "label_Clave";
            this.label_Clave.Size = new System.Drawing.Size(44, 18);
            this.label_Clave.TabIndex = 3;
            this.label_Clave.Text = "Clave";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_ID.Location = new System.Drawing.Point(85, 31);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(58, 18);
            this.label_ID.TabIndex = 2;
            this.label_ID.Text = "Usuario";
            // 
            // richTextBox_Clave
            // 
            this.richTextBox_Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Clave.Location = new System.Drawing.Point(37, 116);
            this.richTextBox_Clave.MaxLength = 7;
            this.richTextBox_Clave.Multiline = false;
            this.richTextBox_Clave.Name = "richTextBox_Clave";
            this.richTextBox_Clave.Size = new System.Drawing.Size(157, 23);
            this.richTextBox_Clave.TabIndex = 2;
            this.richTextBox_Clave.Text = "";
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.Image")));
            this.pictureBox_Logo.InitialImage = null;
            this.pictureBox_Logo.Location = new System.Drawing.Point(302, 60);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(179, 188);
            this.pictureBox_Logo.TabIndex = 5;
            this.pictureBox_Logo.TabStop = false;
            this.pictureBox_Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_Superior
            // 
            this.panel_Superior.BackColor = System.Drawing.Color.Gray;
            this.panel_Superior.Controls.Add(this.btnCerrar);
            this.panel_Superior.Location = new System.Drawing.Point(0, -1);
            this.panel_Superior.Name = "panel_Superior";
            this.panel_Superior.Size = new System.Drawing.Size(548, 27);
            this.panel_Superior.TabIndex = 6;
            this.panel_Superior.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Superior_Paint);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(520, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 215;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel_inferior
            // 
            this.panel_inferior.BackColor = System.Drawing.Color.Gray;
            this.panel_inferior.Location = new System.Drawing.Point(0, 299);
            this.panel_inferior.Name = "panel_inferior";
            this.panel_inferior.Size = new System.Drawing.Size(643, 21);
            this.panel_inferior.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(487, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 21);
            this.comboBox1.TabIndex = 217;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(546, 320);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel_inferior);
            this.Controls.Add(this.panel_Superior);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.panel_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Opacity = 0.87D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.panel_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_ID;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label label_Clave;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.RichTextBox richTextBox_Clave;
        private System.Windows.Forms.Button button_Acceder;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label_Olvidaste_Clave;
        private System.Windows.Forms.Panel panel_Superior;
        private System.Windows.Forms.Panel panel_inferior;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button button_Registrar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

