﻿namespace Examen_U2
{
    partial class FrmUsuarios
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
            dgvUsuarios = new DataGridView();
            panel1 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            butInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(2, 100);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(675, 277);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 94);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.Controls.Add(butInsertar);
            panel3.Location = new Point(683, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(169, 283);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Bauhaus 93", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(416, 54);
            label1.TabIndex = 5;
            label1.Text = "Tabla de Usuarios";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.klipartz_com__5_;
            pictureBox1.Location = new Point(432, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // butInsertar
            // 
            butInsertar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butInsertar.ForeColor = Color.Black;
            butInsertar.Location = new Point(5, 73);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(152, 23);
            butInsertar.TabIndex = 7;
            butInsertar.Text = "Insertar Nuevo Usuario";
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 385);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dgvUsuarios);
            ForeColor = Color.White;
            Name = "FrmUsuarios";
            Text = "Informacion de los Usuarios";
            Activated += FrmUsuarios_Activated;
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button butInsertar;
    }
}