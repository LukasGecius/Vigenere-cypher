
namespace Sifravimas
{
    partial class Form1
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
            this.label9 = new System.Windows.Forms.Label();
            this.boxTekstas = new System.Windows.Forms.TextBox();
            this.boxRaktas = new System.Windows.Forms.TextBox();
            this.boxSifras = new System.Windows.Forms.TextBox();
            this.boxSifruotas = new System.Windows.Forms.TextBox();
            this.boxRaktas2 = new System.Windows.Forms.TextBox();
            this.boxAtsifruotas = new System.Windows.Forms.TextBox();
            this.Raktas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ButSifruot = new System.Windows.Forms.Button();
            this.butAtsifruot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tekstas";
            // 
            // boxTekstas
            // 
            this.boxTekstas.Location = new System.Drawing.Point(104, 27);
            this.boxTekstas.Name = "boxTekstas";
            this.boxTekstas.Size = new System.Drawing.Size(100, 20);
            this.boxTekstas.TabIndex = 0;
            // 
            // boxRaktas
            // 
            this.boxRaktas.Location = new System.Drawing.Point(104, 57);
            this.boxRaktas.Name = "boxRaktas";
            this.boxRaktas.Size = new System.Drawing.Size(100, 20);
            this.boxRaktas.TabIndex = 1;
            // 
            // boxSifras
            // 
            this.boxSifras.Location = new System.Drawing.Point(104, 88);
            this.boxSifras.Name = "boxSifras";
            this.boxSifras.Size = new System.Drawing.Size(100, 20);
            this.boxSifras.TabIndex = 2;
            // 
            // boxSifruotas
            // 
            this.boxSifruotas.Location = new System.Drawing.Point(350, 27);
            this.boxSifruotas.Name = "boxSifruotas";
            this.boxSifruotas.Size = new System.Drawing.Size(100, 20);
            this.boxSifruotas.TabIndex = 3;
            // 
            // boxRaktas2
            // 
            this.boxRaktas2.Location = new System.Drawing.Point(350, 57);
            this.boxRaktas2.Name = "boxRaktas2";
            this.boxRaktas2.Size = new System.Drawing.Size(100, 20);
            this.boxRaktas2.TabIndex = 4;
            // 
            // boxAtsifruotas
            // 
            this.boxAtsifruotas.Location = new System.Drawing.Point(350, 88);
            this.boxAtsifruotas.Name = "boxAtsifruotas";
            this.boxAtsifruotas.Size = new System.Drawing.Size(100, 20);
            this.boxAtsifruotas.TabIndex = 5;
            // 
            // Raktas
            // 
            this.Raktas.AutoSize = true;
            this.Raktas.Location = new System.Drawing.Point(12, 60);
            this.Raktas.Name = "Raktas";
            this.Raktas.Size = new System.Drawing.Size(41, 13);
            this.Raktas.TabIndex = 6;
            this.Raktas.Text = "Raktas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Sifruotas tekstas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(225, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Sifruotas tekstas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Raktas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(225, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Atsifruotas tekstas";
            // 
            // ButSifruot
            // 
            this.ButSifruot.Location = new System.Drawing.Point(119, 114);
            this.ButSifruot.Name = "ButSifruot";
            this.ButSifruot.Size = new System.Drawing.Size(75, 23);
            this.ButSifruot.TabIndex = 11;
            this.ButSifruot.Text = "Sifruoti";
            this.ButSifruot.UseVisualStyleBackColor = true;
            this.ButSifruot.Click += new System.EventHandler(this.ButSifruot_Click);
            // 
            // butAtsifruot
            // 
            this.butAtsifruot.Location = new System.Drawing.Point(361, 114);
            this.butAtsifruot.Name = "butAtsifruot";
            this.butAtsifruot.Size = new System.Drawing.Size(75, 23);
            this.butAtsifruot.TabIndex = 12;
            this.butAtsifruot.Text = "Atsifruoti";
            this.butAtsifruot.UseVisualStyleBackColor = true;
            this.butAtsifruot.Click += new System.EventHandler(this.butAtsifruot_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(546, 384);
            this.Controls.Add(this.butAtsifruot);
            this.Controls.Add(this.ButSifruot);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Raktas);
            this.Controls.Add(this.boxAtsifruotas);
            this.Controls.Add(this.boxRaktas2);
            this.Controls.Add(this.boxSifruotas);
            this.Controls.Add(this.boxSifras);
            this.Controls.Add(this.boxRaktas);
            this.Controls.Add(this.boxTekstas);
            this.Controls.Add(this.label9);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxNesifruotasTekstas;
        private System.Windows.Forms.TextBox boxSifravimoRaktas;
        private System.Windows.Forms.TextBox boxUzsifruotasRaktas;
        private System.Windows.Forms.TextBox BoxUzsifruotasTekstas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butSifruoti;
        private System.Windows.Forms.TextBox boxSifruotasTekstas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BoxAtsifruotasTekstas;
        private System.Windows.Forms.Button butAtsifruoti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox boxTekstas;
        private System.Windows.Forms.TextBox boxRaktas;
        private System.Windows.Forms.TextBox boxSifras;
        private System.Windows.Forms.TextBox boxSifruotas;
        private System.Windows.Forms.TextBox boxRaktas2;
        private System.Windows.Forms.TextBox boxAtsifruotas;
        private System.Windows.Forms.Label Raktas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ButSifruot;
        private System.Windows.Forms.Button butAtsifruot;
    }
}

