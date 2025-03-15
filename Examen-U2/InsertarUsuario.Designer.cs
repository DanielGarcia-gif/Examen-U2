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
            panel1 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(31, 79);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Apellido Paterno*";
            // 
            // txtApPaterno
            // 
            txtApPaterno.BackColor = Color.FromArgb(224, 224, 224);
            txtApPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtApPaterno.Location = new Point(31, 97);
            txtApPaterno.MaxLength = 50;
            txtApPaterno.Name = "txtApPaterno";
            txtApPaterno.Size = new Size(100, 23);
            txtApPaterno.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(294, 79);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre*";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(224, 224, 224);
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNombre.Location = new Point(294, 97);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(31, 136);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefono";
            // 
            // txtApMaterno
            // 
            txtApMaterno.BackColor = Color.FromArgb(224, 224, 224);
            txtApMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtApMaterno.Location = new Point(166, 97);
            txtApMaterno.MaxLength = 50;
            txtApMaterno.Name = "txtApMaterno";
            txtApMaterno.Size = new Size(100, 23);
            txtApMaterno.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(166, 79);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 6;
            label4.Text = "Apellido Materno*";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(224, 224, 224);
            txtCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCorreo.Location = new Point(166, 154);
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(228, 23);
            txtCorreo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(166, 136);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 8;
            label5.Text = "Correo";
            // 
            // butCancelar
            // 
            butCancelar.BackgroundImage = Properties.Resources.pngegg__6_;
            butCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            butCancelar.Location = new Point(22, 99);
            butCancelar.Name = "butCancelar";
            butCancelar.Size = new Size(58, 56);
            butCancelar.TabIndex = 12;
            butCancelar.UseVisualStyleBackColor = true;
            butCancelar.Click += butCancelar_Click;
            // 
            // butInsertar
            // 
            butInsertar.BackgroundImage = Properties.Resources.pngegg__5_;
            butInsertar.BackgroundImageLayout = ImageLayout.Stretch;
            butInsertar.Location = new Point(22, 24);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(58, 53);
            butInsertar.TabIndex = 13;
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // mtbTelefono
            // 
            mtbTelefono.BackColor = Color.FromArgb(224, 224, 224);
            mtbTelefono.Location = new Point(31, 154);
            mtbTelefono.Mask = "0000000000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(100, 23);
            mtbTelefono.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(31, 198);
            label7.Name = "label7";
            label7.Size = new Size(136, 15);
            label7.TabIndex = 29;
            label7.Text = "* Campo OBLIGATORIO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 61);
            panel1.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(butInsertar);
            panel2.Controls.Add(butCancelar);
            panel2.Location = new Point(435, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(93, 216);
            panel2.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bauhaus 93", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(178, 18);
            label6.Name = "label6";
            label6.Size = new Size(171, 28);
            label6.TabIndex = 0;
            label6.Text = "Nuevo Usuario";
            // 
            // InsertarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(527, 240);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(mtbTelefono);
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
            Name = "InsertarUsuario";
            Text = "Insertar Nuevo Usuario";
            Load += InsertarUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private Label label6;
    }
}