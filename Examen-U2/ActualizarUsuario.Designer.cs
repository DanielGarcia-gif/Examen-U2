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
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtID.Location = new Point(22, 36);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(22, 18);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 22;
            label6.Text = "ID";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCorreo.Location = new Point(157, 146);
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(228, 23);
            txtCorreo.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(157, 128);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 20;
            label5.Text = "Correo";
            // 
            // txtApMaterno
            // 
            txtApMaterno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtApMaterno.Location = new Point(157, 89);
            txtApMaterno.MaxLength = 50;
            txtApMaterno.Name = "txtApMaterno";
            txtApMaterno.Size = new Size(100, 23);
            txtApMaterno.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(157, 71);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 18;
            label4.Text = "Apellido Materno*";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNombre.Location = new Point(285, 89);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(22, 128);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 16;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(285, 71);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre*";
            // 
            // txtApPaterno
            // 
            txtApPaterno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtApPaterno.Location = new Point(22, 89);
            txtApPaterno.MaxLength = 50;
            txtApPaterno.Name = "txtApPaterno";
            txtApPaterno.Size = new Size(100, 23);
            txtApPaterno.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(22, 71);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 12;
            label1.Text = "Apellido Paterno*";
            // 
            // butCancelar
            // 
            butCancelar.Font = new Font("Segoe UI", 9F);
            butCancelar.Location = new Point(369, 189);
            butCancelar.Name = "butCancelar";
            butCancelar.Size = new Size(75, 23);
            butCancelar.TabIndex = 24;
            butCancelar.Text = "Cancelar";
            butCancelar.UseVisualStyleBackColor = true;
            butCancelar.Click += butCancelar_Click;
            // 
            // butEliminar
            // 
            butEliminar.Font = new Font("Segoe UI", 9F);
            butEliminar.Location = new Point(288, 189);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(75, 23);
            butEliminar.TabIndex = 25;
            butEliminar.Text = "Eliminar";
            butEliminar.UseVisualStyleBackColor = true;
            butEliminar.Click += butEliminar_Click;
            // 
            // butActualizar
            // 
            butActualizar.Font = new Font("Segoe UI", 9F);
            butActualizar.Location = new Point(207, 189);
            butActualizar.Name = "butActualizar";
            butActualizar.Size = new Size(75, 23);
            butActualizar.TabIndex = 26;
            butActualizar.Text = "Actualizar";
            butActualizar.UseVisualStyleBackColor = true;
            butActualizar.Click += butActualizar_Click;
            // 
            // mtbTelefono
            // 
            mtbTelefono.Location = new Point(22, 146);
            mtbTelefono.Mask = "0000000000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(100, 23);
            mtbTelefono.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 189);
            label7.Name = "label7";
            label7.Size = new Size(136, 15);
            label7.TabIndex = 30;
            label7.Text = "* Campo OBLIGATORIO";
            // 
            // ActualizarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 224);
            Controls.Add(label7);
            Controls.Add(mtbTelefono);
            Controls.Add(butActualizar);
            Controls.Add(butEliminar);
            Controls.Add(butCancelar);
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
            Name = "ActualizarUsuario";
            Text = "Actualizar Usuario";
            Load += ActualizarUsuario_Load;
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
    }
}