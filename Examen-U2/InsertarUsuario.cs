using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_U2
{
    public partial class InsertarUsuario : Form
    {
        public InsertarUsuario()
        {
            InitializeComponent();
        }

        private void InsertarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            string correo = "";
            string telefono = "";

            if(txtCorreo.Text.Length == 0)
            {
                correo = "NULL";
            }
            else
            {
                correo = "'" + txtCorreo.Text + "'";
            }

            if (mtbTelefono.Text.Length == 0)
            {
                telefono = "NULL";
            }
            else
            {
                telefono = "'" + mtbTelefono.Text + "'";
            }

            if(mtbTelefono.Text.Length > 0 && mtbTelefono.Text.Length < 10)
            {
                MessageBox.Show("Numero de telefono inconsistente, favor de revisar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtNombre.Text.CompareTo("") == 0 || txtApMaterno.Text.CompareTo("") == 0 || txtApPaterno.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Datos datos = new Datos();
                bool f = datos.comando("INSERT INTO USUARIOS values " +
                                       "('" + txtApPaterno.Text.Replace("'", "''") +
                                       "','" + txtApMaterno.Text.Replace("'", "''") +
                                       "','" + txtNombre.Text.Replace("'", "''") +
                                       "'," + telefono +
                                       "," + correo +
                                       ")");

                if (f == true)
                {
                    MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
