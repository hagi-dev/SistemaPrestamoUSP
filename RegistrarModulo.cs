using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaPrestamoUSP
{
    public partial class RegistrarModulo : Form
    {
        MySqlConnection conexion;
        public RegistrarModulo()
        {
            InitializeComponent();
        }

        private void txtCodigoModulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreModulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarModulo_Load(object sender, EventArgs e)
        {
            conexion = new MySqlConnection("database= prestamo;data source= localhost;user id=root;password=120613");
            
        }

        private void txtCodigoModulo_Enter(object sender, EventArgs e)
        {
            lblVerificacionCodigoModulo.ForeColor = Color.Green;
            lblVerificacionCodigoModulo.Text = "Ultimo codigo Registrado:* "+ CodigoDetalle11()+" es secuencial";
        }

        private void VerificaionDeExistenciaCodigoPrestamo()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "SELECT MOD_codigo FROM modulo where MOD_codigo = '" + txtCodigoModulo.Text + "';";
            cmd.Connection.Open();
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.HasRows)
            {
                lblVerificacionCodigoModulo.ForeColor = Color.Red;
                lblVerificacionCodigoModulo.Text = "El codigo ya existe*";

            }
            else
            {
                lblVerificacionCodigoModulo.ForeColor = Color.Green;
                lblVerificacionCodigoModulo.Text = "Estabien el codigo :)*";
            }
            MessageBox.Show(leer.HasRows.ToString());
            cmd.Connection.Close();






        }

        private void txtCodigoModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== (char)13)
            {
                VerificaionDeExistenciaCodigoPrestamo();
            }
        }

        private void btnAgregarModulo_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(MessageBox.Show("Deseas grabar", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (x == 6)
            {
                MySqlCommand cmd = new MySqlCommand();
                try
                {
                    cmd.Connection = conexion;
                    //llenar();
                    cmd.CommandText = "insert into prestamo.modulo values('" + txtCodigoModulo.Text + "','" + txtNombreModulo.Text + "')";
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    mostrarRegistrar();
                    MessageBox.Show("datos ingresados", "confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error de transacción");
                    cmd.Connection.Close();
                }
            }
        }
        private void mostrarRegistrar()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "select * from modulo";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvDatosModulos.DataSource = dt;
        }
        private String CodigoDetalle11()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "SELECT MOD_codigo FROM modulo ORDER by MOD_codigo DESC LIMIT 1 ";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            cbxSoloCodigo.ValueMember = "MOD_codigo";
            cbxSoloCodigo.DisplayMember = "MOD_codigo";
            cbxSoloCodigo.DataSource = dt;
            cmd.Connection.Close();
            cbxSoloCodigo.SelectedIndex = 0;
            return cbxSoloCodigo.SelectedValue.ToString();
        }
    }
}
