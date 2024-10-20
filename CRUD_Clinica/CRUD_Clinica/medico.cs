using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Clinica
{
    public partial class medico : Form
    {
        CRUDClinica ccM = new CRUDClinica();
        public medico()
        {
            InitializeComponent();
        }

        private void medico_Load(object sender, EventArgs e)
        {
            ccM.conectar();
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            ccM.llenarGrid("select * from medico", "medico");
            dgvMedico.DataSource = ccM.ds.Tables["medico"];
        }

        private void btnGuardarm_Click(object sender, EventArgs e)
        {
            if (txtIDmedico.Text == "" || txtNombreM.Text == "" || txtApellidoM.Text == "")
            {
                MessageBox.Show("No deje los campos vacíos");
            }
            else
            {
                string insertar = "insert into medico values('" + txtIDmedico.Text + "','" + txtNombreM.Text + "','" + txtApellidoM.Text + "','" + txtNumTelefonoM.Text + "','" + txtEspecialidad.Text + "')";
                if (ccM.gestion(insertar))
                {
                    MessageBox.Show("Registro almacenado correctamente");
                    mostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al almacenar el registro");
                }
            }
        }

        private void dgvMedico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvMedico.Rows[e.RowIndex];
            txtIDmedico.Text = dgv.Cells[0].Value.ToString();
            txtNombreM.Text = dgv.Cells[1].Value.ToString();
            txtApellidoM.Text = dgv.Cells[2].Value.ToString();
            txtNumTelefonoM.Text = dgv.Cells[3].Value.ToString();
            txtEspecialidad.Text = dgv.Cells[4].Value.ToString();
        }

        private void btnModificarm_Click(object sender, EventArgs e)
        {
            String modificar = "update medico set m_Nombre='" + txtNombreM.Text + "',m_Apellidos='" + txtApellidoM.Text + "',m_Telefono='" + txtNumTelefonoM.Text + "',Especialidad='" + txtEspecialidad.Text + "' where m_Codigo='" + txtIDmedico.Text + "'";
            if (ccM.gestion(modificar))
            {
                MessageBox.Show("Registro almacenado correctamente");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al almacenar el registro");
            }
        }

        private void txtEliminarm_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Realmente desea eliminar el registro?", "ESTA ACCION ES DELICADA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string eliminar = "delete from medico where m_Codigo='" + txtIDmedico.Text + "'";
                if (ccM.gestion(eliminar))
                {
                    MessageBox.Show("Registro eliminado correctamente");
                    mostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro");
                }
            }
        }

        private void txtBuscarm_Click(object sender, EventArgs e)
        {
            string consulta = "select * from medico where m_Codigo = '" + txtIDmedico.Text + "'";
            ccM.consultarText(consulta);
            if (ccM.dr.Read())
            {
                txtNombreM.Text = Convert.ToString(ccM.dr[1]);
                txtApellidoM.Text = Convert.ToString(ccM.dr[2]);
                txtNumTelefonoM.Text = Convert.ToString(ccM.dr[3]);
                txtEspecialidad.Text = Convert.ToString(ccM.dr[4]);
                ccM.dr.Close();
                ccM.cerrar();
            }
        }

        private void btnNuevom_Click(object sender, EventArgs e)
        {
            txtIDmedico.Clear();
            txtNombreM.Clear();
            txtApellidoM.Clear();
            txtNumTelefonoM.Clear();
            txtEspecialidad.Clear();
            txtIDmedico.Focus();
        }

        private void txtCerrarm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
