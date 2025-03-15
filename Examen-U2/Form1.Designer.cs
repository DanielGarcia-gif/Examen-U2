namespace Examen_U2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            butAgenda = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // butAgenda
            // 
            butAgenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butAgenda.Location = new Point(117, 207);
            butAgenda.Name = "butAgenda";
            butAgenda.Size = new Size(75, 23);
            butAgenda.TabIndex = 0;
            butAgenda.Text = "Usuarios";
            butAgenda.UseVisualStyleBackColor = true;
            butAgenda.Click += butAgenda_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 72);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(278, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(92, 188);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(89, 22);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 0;
            label1.Text = "Tablas Disponibles";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(294, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(76, 188);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.klipartz_com__5_;
            pictureBox1.Location = new Point(101, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 258);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(butAgenda);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Tablas Disponibles";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button butAgenda;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}
