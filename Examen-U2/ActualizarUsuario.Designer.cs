namespace Examen_U2
{
    partial class ActualizarUsuario
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
            txtID = new TextBox();
            label6 = new Label();
            txtCorreo = new TextBox();
            label5 = new Label();
            txtApMaterno = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtApPaterno = new TextBox();
            label1 = new Label();
            butCancelar = new Button();
            butEliminar = new Button();
            butActualizar = new Button();
            mtbTelefono = new MaskedTextBox();
            label7 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.BackColor = Color.Silver;
            txtID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtID.Location = new Point(33, 90);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(33, 72);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 22;
            label6.Text = "ID";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(224, 224, 224);
            txtCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCorreo.Location = new Point(168, 200);
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(228, 23);
            txtCorreo.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(168, 182);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 20;
            label5.Text = "Correo";
            // 
            // txtApMaterno
            // 
            txtApMaterno.BackColor = Color.FromArgb(224, 224, 224);
            txtApMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtApMaterno.Location = new Point(168, 143);
            txtApMaterno.MaxLength = 50;
            txtApMaterno.Name = "txtApMaterno";
            txtApMaterno.Size = new Size(100, 23);
            txtApMaterno.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(168, 125);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 18;
            label4.Text = "Apellido Materno*";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(224, 224, 224);
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNombre.Location = new Point(296, 143);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(33, 182);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 16;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(296, 125);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre*";
            // 
            // txtApPaterno
            // 
            txtApPaterno.BackColor = Color.FromArgb(224, 224, 224);
            txtApPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtApPaterno.Location = new Point(33, 143);
            txtApPaterno.MaxLength = 50;
            txtApPaterno.Name = "txtApPaterno";
            txtApPaterno.Size = new Size(100, 23);
            txtApPaterno.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(33, 125);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 12;
            label1.Text = "Apellido Paterno*";
            // 
            // butCancelar
            // 
            butCancelar.BackgroundImage = Properties.Resources.pngegg__6_;
            butCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            butCancelar.Font = new Font("Segoe UI", 9F);
            butCancelar.Location = new Point(20, 155);
            butCancelar.Name = "butCancelar";
            butCancelar.Size = new Size(63, 56);
            butCancelar.TabIndex = 24;
            butCancelar.UseVisualStyleBackColor = true;
            butCancelar.Click += butCancelar_Click;
            // 
            // butEliminar
            // 
            butEliminar.BackgroundImage = Properties.Resources.pngegg__8_;
            butEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            butEliminar.Font = new Font("Segoe UI", 9F);
            butEliminar.Location = new Point(20, 85);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(63, 54);
            butEliminar.TabIndex = 25;
            butEliminar.UseVisualStyleBackColor = true;
            butEliminar.Click += butEliminar_Click;
            // 
            // butActualizar
            // 
            butActualizar.BackgroundImage = Properties.Resources.pngegg__7_;
            butActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            butActualizar.Font = new Font("Segoe UI", 9F);
            butActualizar.Location = new Point(20, 16);
            butActualizar.Name = "butActualizar";
            butActualizar.Size = new Size(63, 53);
            butActualizar.TabIndex = 26;
            butActualizar.UseVisualStyleBackColor = true;
            butActualizar.Click += butActualizar_Click;
            // 
            // mtbTelefono
            // 
            mtbTelefono.BackColor = Color.FromArgb(224, 224, 224);
            mtbTelefono.Location = new Point(33, 200);
            mtbTelefono.Mask = "0000000000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(100, 23);
            mtbTelefono.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(33, 243);
            label7.Name = "label7";
            label7.Size = new Size(136, 15);
            label7.TabIndex = 30;
            label7.Text = "* Campo OBLIGATORIO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 60);
            panel1.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bauhaus 93", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(169, 18);
            label8.Name = "label8";
            label8.Size = new Size(209, 28);
            label8.TabIndex = 0;
            label8.Text = "Actulizar Usuario";
            label8.Click += label8_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(butActualizar);
            panel2.Controls.Add(butEliminar);
            panel2.Controls.Add(butCancelar);
            panel2.Location = new Point(435, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(107, 225);
            panel2.TabIndex = 32;
            // 
            // ActualizarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(542, 281);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(mtbTelefono);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(txtCorreo);
            Controls.Add(label5);
            Controls.Add(txtApMaterno);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtApPaterno);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "ActualizarUsuario";
            Text = "Actualizar Usuario";
            Load += ActualizarUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private Label label6;
        private TextBox txtCorreo;
        private Label label5;
        private TextBox txtApMaterno;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private TextBox txtApPaterno;
        private Label label1;
        private Button butCancelar;
        private Button butEliminar;
        private Button butActualizar;
        private MaskedTextBox mtbTelefono;
        private Label label7;
        private Panel panel1;
        private Label label8;
        private Panel panel2;
    }
}