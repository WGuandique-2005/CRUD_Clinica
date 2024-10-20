using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD_Clinica
{
    internal class CRUDClinica
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NFDMETJ;Initial Catalog=ClinicaPatras;Integrated Security=True");
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand cmd;
        public SqlDataReader dr;
        public void conectar()
        {
            try
            {
                con.Open();
                MessageBox.Show("Conexión exitosa");
            }
            catch
            {

                MessageBox.Show("Erro al establecer conexión");
            }
            finally
            {
                con.Close();
            }
        }
        
        public void llenarGrid(string sql, string table)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, con);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, table);
        }

        public bool gestion(string sql)
        {
            con.Open();
            cmd = new SqlCommand(sql, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void consultarText(string sql)
        {
            con.Open();
            cmd = new SqlCommand(sql,con);
            dr = cmd.ExecuteReader();

        }
        public void cerrar()
        {
            con.Close();
        }
    }
}
