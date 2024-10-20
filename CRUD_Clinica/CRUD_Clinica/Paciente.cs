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
    public partial class Paciente : Form
    {
        CRUDClinica ccp = new CRUDClinica();
        public Paciente()
        {
            InitializeComponent();
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            ccp.conectar();
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            ccp.llenarGrid("select * from paciente", "paciente");
            dgvPaciente.DataSource = ccp.ds.Tables["paciente"];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIDpaciente.Text == "" || txtNombreP.Text == "" || txtApellidoP.Text == "")
            {
                MessageBox.Show("No deje los campos vacíos");
            }
            else
            {
                string insertar = "insert into paciente values('" + txtIDpaciente.Text + "','" + txtNombreP.Text + "','" + txtApellidoP.Text + "','" + txtDireccion.Text + "','" + txtPoblacion.Text + "','" + txtProvincia.Text + "','" + txtCodigoPostal.Text + "','" + txtTelefonoP.Text + "','" + txtFechaNacimienti.Text + "')";
                if (ccp.gestion(insertar))
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

        private void dgvPaciente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvPaciente.Rows[e.RowIndex];
            txtIDpaciente.Text = dgv.Cells[0].Value.ToString();
            txtNombreP.Text = dgv.Cells[1].Value.ToString();
            txtApellidoP.Text = dgv.Cells[2].Value.ToString();
            txtDireccion.Text = dgv.Cells[3].Value.ToString();
            txtPoblacion.Text = dgv.Cells[4].Value.ToString();
            txtProvincia.Text = dgv.Cells[5].Value.ToString();
            txtCodigoPostal.Text = dgv.Cells[6].Value.ToString();
            txtTelefonoP.Text = dgv.Cells[7].Value.ToString();
            txtFechaNacimienti.Text = dgv.Cells[8].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String modificar = "update paciente set p_Nombre='" + txtNombreP.Text + "',p_Apellidos='" + txtApellidoP.Text + "',Direccion='" + txtDireccion.Text + "',Poblacion='" + txtPoblacion.Text + "',Provincia='" + txtProvincia.Text + "',Codigo_postal='" + txtCodigoPostal.Text + "',p_Telefono='" + txtTelefonoP.Text + "' where p_Codigo='" + txtIDpaciente.Text + "'";
            if (ccp.gestion(modificar))
            {
                MessageBox.Show("Registro almacenado correctamente");
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Error al almacenar el registro");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Realmente desea eliminar el registro?", "ESTA ACCION ES DELICADA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string eliminar = "delete from paciente where p_Codigo='" + txtIDpaciente.Text + "'";
                if (ccp.gestion(eliminar))
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string consulta = "select * from paciente where p_Codigo = '" + txtIDpaciente.Text + "'";
            ccp.consultarText(consulta);
            if (ccp.dr.Read())
            {
                txtNombreP.Text = Convert.ToString(ccp.dr[1]);
                txtApellidoP.Text = Convert.ToString(ccp.dr[2]);
                txtDireccion.Text = Convert.ToString(ccp.dr[3]);
                txtPoblacion.Text = Convert.ToString(ccp.dr[4]);
                txtProvincia.Text = Convert.ToString(ccp.dr[5]);
                txtCodigoPostal.Text = Convert.ToString(ccp.dr[6]);
                txtTelefonoP.Text = Convert.ToString(ccp.dr[7]);
                txtFechaNacimienti.Text = Convert.ToString(ccp.dr[8]);
                ccp.dr.Close();
                ccp.cerrar();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIDpaciente.Clear();
            txtNombreP.Clear();
            txtApellidoP.Clear();
            txtDireccion.Clear();
            txtPoblacion.Clear();
            txtProvincia.Clear();
            txtProvincia.Clear();
            txtCodigoPostal.Clear();
            txtTelefonoP.Clear();
            txtFechaNacimienti.Clear();
            txtIDpaciente.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
