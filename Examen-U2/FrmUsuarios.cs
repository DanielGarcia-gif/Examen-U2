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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            dgvUsuarios.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select ID as [ID Usuario], " +
                                      "APATERNO as [Apellido Paterno], " +
                                      "AMATERNO as [Apellido Materno], " +
                                      "NOMBRE as [Nombre], " +
                                      "TELEFONO as [Telefono], " +
                                      "CORREO as [Correo] " +
                                      "FROM USUARIOS");

            if (ds != null)
            {
                dgvUsuarios.DataSource = ds.Tables[0];
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarUsuario actualiza = new ActualizarUsuario(dgvUsuarios[0, e.RowIndex].Value.ToString(),
                                                                dgvUsuarios[1, e.RowIndex].Value.ToString(),
                                                                dgvUsuarios[2, e.RowIndex].Value.ToString(),
                                                                dgvUsuarios[3, e.RowIndex].Value.ToString(),
                                                                dgvUsuarios[4, e.RowIndex].Value.ToString(),
                                                                dgvUsuarios[5, e.RowIndex].Value.ToString());

            actualiza.Show();
        }

        private void actualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select ID as [ID Usuario], " +
                                      "APATERNO as [Apellido Paterno], " +
                                      "AMATERNO as [Apellido Materno], " +
                                      "NOMBRE as [Nombre], " +
                                      "TELEFONO as [Telefono], " +
                                      "CORREO as [Correo] " +
                                      "FROM USUARIOS");

            if (ds != null)
            {
                dgvUsuarios.DataSource = ds.Tables[0];
            }
        }

        private void FrmUsuarios_Activated(object sender, EventArgs e)
        {
            actualizaGrid();
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            InsertarUsuario insertar = new InsertarUsuario();
            insertar.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
