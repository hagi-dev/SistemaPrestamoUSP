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
    public partial class RegistroMaterial : Form
    {
        MySqlConnection conexion;
        public RegistroMaterial()
        {
            InitializeComponent();
        }

        private void txtCodigoMaterial_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigoMaterial.Text=="")
            {
                errorProvider1.SetError(txtCodigoMaterial,"este espacio no puede estar vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private void tipo()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "SELECT TIP_codigo,TIP_nombre FROM tipo;";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            DataRow fila = dt.NewRow();
            fila["TIP_nombre"] = "Selecciona Tipo";
            dt.Rows.InsertAt(fila, 0);

            cbxTipo.ValueMember = "TIP_codigo";
            cbxTipo.DisplayMember = "TIP_nombre";
            cbxTipo.DataSource = dt;

        }
        private void txtDescripcionMaterial_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigoMaterial.Text == "" || txtCodigoMaterial.Text.Length < 9)
            {
                errorProvider1.SetError(txtDescripcionMaterial, "este espacio no puede estar vacio y debe tener 9 caracteres ");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void RegistroMaterial_Load(object sender, EventArgs e)
        {
            try
            {
                conexion = new MySqlConnection("database= prestamo;data source= localhost;user id=root;password=120613");
                tipo();
                mostrarRegistrar();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(MessageBox.Show("Deseas grabar", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (x == 6)
            {
                MySqlCommand cmd = new MySqlCommand();
                try
                {
                    cmd.Connection = conexion;
                    //llenar();
                    cmd.CommandText = "insert into prestamo.material values('" + txtCodigoMaterial.Text + "','" + txtDescripcionMaterial.Text + "','" + cbxEstado.Text + "','" + cbxTipo.SelectedValue.ToString() + "')";
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
            cmd.CommandText = "select * from material";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvDatosMateriales.DataSource = dt;
        }

        private void VerificaionDeExistenciaCodigoMaterial()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "SELECT MAT_codigo FROM material where MAT_codigo = '" + txtCodigoMaterial.Text + "';";
            cmd.Connection.Open();
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.HasRows)
            {
                lblVerificacionCodigoMaterial.ForeColor = Color.Red;
                lblVerificacionCodigoMaterial.Text = "El codigo ya existe*";

            }
            else
            {
                lblVerificacionCodigoMaterial.ForeColor = Color.Green;
                lblVerificacionCodigoMaterial.Text = "Estabien el codigo :)*";
            }
            MessageBox.Show(leer.HasRows.ToString());
            cmd.Connection.Close();






        }

        private void txtCodigoMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                VerificaionDeExistenciaCodigoMaterial();
            }
          
        }

        private void txtCodigoMaterial_Enter(object sender, EventArgs e)
        {
            lblVerificacionCodigoMaterial.ForeColor = Color.Green;
            
            lblVerificacionCodigoMaterial.Text = "Ultimo codigo: "+ CodigoDetalle11();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(MessageBox.Show("Deseas eliminar", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (x == 6)
            {
                MySqlCommand cmd = new MySqlCommand();
                try
                {
                    cmd.Connection = conexion;
                    //llenar();
                    cmd.CommandText = "delete from material where MAT_codigo='" + dgvDatosMateriales.CurrentRow.Cells[0].Value.ToString() + "'";
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    mostrarRegistrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error de transacción");
                    cmd.Connection.Close();
                }
            }
        }
        private String CodigoDetalle11()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "SELECT MAT_codigo FROM material ORDER by MAT_codigo DESC LIMIT 1 ";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            cbxSoloCodigo.ValueMember = "MAT_codigo";
            cbxSoloCodigo.DisplayMember = "MAT_codigo";
            cbxSoloCodigo.DataSource = dt;
            cmd.Connection.Close();
            cbxSoloCodigo.SelectedIndex = 0;
            return cbxSoloCodigo.SelectedValue.ToString();
        }
    }
}
