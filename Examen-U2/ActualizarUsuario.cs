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
    public partial class ActualizarUsuario : Form
    {
        public ActualizarUsuario(string ID, string APATERNO, string AMATERNO,
                                 string NOMBRE, string TELEFONO, string CORREO)

        {
            InitializeComponent();
            txtID.Text = ID;
            txtApPaterno.Text = APATERNO;
            txtApMaterno.Text = AMATERNO;
            txtNombre.Text = NOMBRE;
            mtbTelefono.Text = TELEFONO;
            txtCorreo.Text = CORREO;

        }

        private void ActualizarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void butActualizar_Click(object sender, EventArgs e)
        {

            string correo = "";
            string telefono = "";

            if (txtCorreo.Text.Length == 0 )
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

            if ((mtbTelefono.Text.Length > 0 && mtbTelefono.Text.Length < 10) || mtbTelefono.Text.Contains(" "))
            {
                MessageBox.Show("Numero de telefono inconsistente, favor de revisar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNombre.Text.CompareTo("") == 0 || txtApMaterno.Text.CompareTo("") == 0 || txtApPaterno.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Datos datos = new Datos();
                bool f = datos.comando("UPDATE USUARIOS " +
                                        "SET APATERNO = '" + txtApPaterno.Text +
                                        "', AMATERNO = '" + txtApMaterno.Text +
                                        "', NOMBRE = '" + txtNombre.Text +
                                        "', TELEFONO = " + telefono +
                                        ", CORREO = " + correo +
                                        " WHERE ID = " + txtID.Text);

                if (f == true)
                {
                    MessageBox.Show("Datos actualizados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (res == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("DELETE FROM usuarios WHERE ID = '" + txtID.Text + "'");

                if (f == true)
                {
                    MessageBox.Show("Datos eliminados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
