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
    public partial class menu : Form
    {
        CRUDClinica crudmenu = new CRUDClinica();
        public menu()
        {
            InitializeComponent();
        }

        private void PACIENTES_Click(object sender, EventArgs e)
        {

            //ventana1.Visible = true;
            Paciente ventana1 = new Paciente();
            ventana1.Visible = true;

        }

        private void MEDICOS_Click(object sender, EventArgs e)
        {
            //ventana2.Visible = true;
            medico ventana2 = new medico();
            ventana2.Visible = true;

        }

        private void REGISTROS_Click(object sender, EventArgs e)
        {
            //ventana3.Visible = true;
            registro ventana3 = new registro();
            ventana3.Visible = true;

        }

        private void CERRAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
