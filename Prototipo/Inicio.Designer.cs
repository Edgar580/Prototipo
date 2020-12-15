
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
            this.richTextBox_ID = new System.Windows.Forms.RichTextBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.panel_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_ID
            // 
            this.richTextBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_ID.Location = new System.Drawing.Point(46, 37);
            this.richTextBox_ID.MaxLength = 7;
            this.richTextBox_ID.Multiline = false;
            this.richTextBox_ID.Name = "richTextBox_ID";
            this.richTextBox_ID.Size = new System.Drawing.Size(147, 23);
            this.richTextBox_ID.TabIndex = 1;
            this.richTextBox_ID.Text = "";
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(8)))), ((int)(((byte)(18)))));
            this.panel_login.Controls.Add(this.richTextBox_ID);
            this.panel_login.Location = new System.Drawing.Point(122, 44);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(234, 340);
            this.panel_login.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 428);
            this.Controls.Add(this.panel_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_login.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_ID;
        private System.Windows.Forms.Panel panel_login;
    }
}

