namespace Examen_U2
{
    partial class InsertarUsuario
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
            label1 = new Label();
            txtApPaterno = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtApMaterno = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            label5 = new Label();
            butCancelar = new Button();
            butInsertar = new Button();
            mtbTelefono = new MaskedTextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(15, 23);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Apellido Paterno*";
            // 
            // txtApPaterno
            // 
            txtApPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtApPaterno.Location = new Point(15, 41);
            txtApPaterno.MaxLength = 50;
            txtApPaterno.Name = "txtApPaterno";
            txtApPaterno.Size = new Size(100, 23);
            txtApPaterno.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(278, 23);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre*";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNombre.Location = new Point(278, 41);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(15, 80);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefono";
            // 
            // txtApMaterno
            // 
            txtApMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtApMaterno.Location = new Point(150, 41);
            txtApMaterno.MaxLength = 50;
            txtApMaterno.Name = "txtApMaterno";
            txtApMaterno.Size = new Size(100, 23);
            txtApMaterno.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(150, 23);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 6;
            label4.Text = "Apellido Materno*";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCorreo.Location = new Point(150, 98);
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(228, 23);
            txtCorreo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(150, 80);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 8;
            label5.Text = "Correo";
            // 
            // butCancelar
            // 
            butCancelar.Location = new Point(355, 167);
            butCancelar.Name = "butCancelar";
            butCancelar.Size = new Size(75, 23);
            butCancelar.TabIndex = 12;
            butCancelar.Text = "Cancelar";
            butCancelar.UseVisualStyleBackColor = true;
            butCancelar.Click += butCancelar_Click;
            // 
            // butInsertar
            // 
            butInsertar.Location = new Point(262, 167);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(75, 23);
            butInsertar.TabIndex = 13;
            butInsertar.Text = "Insertar";
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // mtbTelefono
            // 
            mtbTelefono.Location = new Point(15, 98);
            mtbTelefono.Mask = "0000000000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(100, 23);
            mtbTelefono.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 142);
            label7.Name = "label7";
            label7.Size = new Size(136, 15);
            label7.TabIndex = 29;
            label7.Text = "* Campo OBLIGATORIO";
            // 
            // InsertarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 203);
            Controls.Add(label7);
            Controls.Add(mtbTelefono);
            Controls.Add(butInsertar);
            Controls.Add(butCancelar);
            Controls.Add(txtCorreo);
            Controls.Add(label5);
            Controls.Add(txtApMaterno);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtApPaterno);
            Controls.Add(label1);
            Name = "InsertarUsuario";
            Text = "Insertar Nuevo Usuario";
            Load += InsertarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtApPaterno;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtApMaterno;
        private Label label4;
        private TextBox txtCorreo;
        private Label label5;
        private Button butCancelar;
        private Button butInsertar;
        private MaskedTextBox mtbTelefono;
        private Label label7;
    }
}