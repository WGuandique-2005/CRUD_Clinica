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
    public partial class registro : Form
    {
        CRUDClinica ccR = new CRUDClinica();
        public registro()
        {
            InitializeComponent();
        }

        private void registro_Load(object sender, EventArgs e)
        {
            ccR.conectar();
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            ccR.llenarGrid("select * from registro", "registro");
            dgvRegistro.DataSource = ccR.ds.Tables["registro"];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIDregistro.Text == "" || txtIDpaciente.Text == "" || txtIDmedico.Text == "")
            {
                MessageBox.Show("No deje los campos vacíos");
            }
            else
            {
                string insertar = "insert into registro values('" + txtIDregistro.Text + "','" + txtIDpaciente.Text + "','" + txtNumHabitacion.Text + "','" + txtFechaIngreso.Text + "','" + txtIDmedico.Text + "')";
                if (ccR.gestion(insertar))
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

        private void dgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvRegistro.Rows[e.RowIndex];
            txtIDregistro.Text = dgv.Cells[0].Value.ToString();
            txtIDpaciente.Text = dgv.Cells[1].Value.ToString();
            txtNumHabitacion.Text = dgv.Cells[2].Value.ToString();
            txtFechaIngreso.Text = dgv.Cells[3].Value.ToString();
            txtIDmedico.Text = dgv.Cells[4].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String modificar = "update registro set p_Codigo='" + txtIDpaciente.Text + "',Num_habitacion='" + txtNumHabitacion.Text + "',m_Codigo='" + txtIDmedico.Text + "' where ID_registro='" + txtIDregistro.Text + "'";
            if (ccR.gestion(modificar))
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
                string eliminar = "delete from registro where ID_registro='" + txtIDregistro.Text + "'";
                if (ccR.gestion(eliminar))
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
            string consulta = "select * from registro where ID_registro = '" + txtIDregistro.Text + "'";
            ccR.consultarText(consulta);
            if (ccR.dr.Read())
            {
                txtIDpaciente.Text = Convert.ToString(ccR.dr[1]);
                txtNumHabitacion.Text = Convert.ToString(ccR.dr[2]);
                txtFechaIngreso.Text = Convert.ToString(ccR.dr[3]);
                txtIDmedico.Text = Convert.ToString(ccR.dr[4]);
                ccR.dr.Close();
                ccR.cerrar();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIDregistro.Clear();
            txtIDpaciente.Clear();
            txtNumHabitacion.Clear();
            txtFechaIngreso.Clear();
            txtIDmedico.Clear();
            txtIDregistro.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
