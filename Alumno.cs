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
    public partial class Alumno : Form
    {
        MySqlConnection conexion;
        String codigo, nombres;
        public String Codigo 
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public String Nombres 
        {
            get { return nombres; }
            set { nombres = value; }
        }
        int posx = 0;
        int posy = 0;
        public Alumno()
        {
            InitializeComponent();
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            try
            {
                conexion = new MySqlConnection("database=prestamo; data source= localhost; user id= root;password=120613  ");
                //conexion.Open();
                sCodigo.Checked = true;
                sApellido.Checked = false;
                sNombre.Checked = false;
                btnRegistrarAlumno.Visible = false;
                btnBuscarAlumno.Visible = false;
                PnlRegistro.Visible = false;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void borrarErrorProvide1(TextBox textbox,KeyPressEventArgs b) 
        {
            if (char.IsLetter(b.KeyChar))
            {
                errorProvider1.Clear();
            }
        }

        private void txtDniRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorProvider1.Clear();
            }
            else
            {
                e.Handled = true;
            }
        }


        private void txtNombreRegistro_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombreRegistro.Text == "")
            {
                errorProvider1.SetError(txtNombreRegistro, "este campo no puede estar vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtDniRegistro_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigoRegistro.Text == "" || txtCodigoRegistro.Text.Length<4)
            {
                errorProvider1.SetError(txtCodigoRegistro,"el campo debe tener 8 numeros");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtApellidoPaternoRegistroRegistro_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoPaternoRegistro.Text == "")
            {
                errorProvider1.SetError(txtApellidoPaternoRegistro, "este campo no puede estar vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void Alumno_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtNombreRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                errorProvider1.Clear();
            }
        }

        private void txtApellidoPaternoRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                errorProvider1.Clear();
            }
        }

        private void txtApellidoMaternoRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                errorProvider1.Clear();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                errorProvider1.Clear();
            }
        }

        private void txtApellidoMaternoRegistro_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoMaternoRegistro.Text == "")
            {
                errorProvider1.SetError(txtApellidoMaternoRegistro, "este campo no puede estar vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmailRegistro.Text == "")
            {
                errorProvider1.SetError(txtEmailRegistro, "este campo no puede estar vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtBuscarDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorProvider1.Clear();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void sNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (sNombre.Checked == true)
            {
                txtBuscarNombre.Enabled= true;
                txtBuscarApellido.Text = "";
                txtBuscarApellido.Enabled = false;
                txtBuscarCodigo.Text = "";
                txtBuscarCodigo.Enabled = false;
                sApellido.Checked = false;
                sCodigo.Checked = false;
                
            }
        }

        private void sApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (sApellido.Checked == true)
            {
                txtBuscarApellido.Enabled = true;
                txtBuscarNombre.Text = "";
                txtBuscarNombre.Enabled = false;
                txtBuscarCodigo.Text = "";
                txtBuscarCodigo.Enabled = false;
                sNombre.Checked = false;
                sCodigo.Checked = false;

            }
        }

        private void sDni_CheckedChanged(object sender, EventArgs e)
        {
            if (sCodigo.Checked == true)
            {
                txtBuscarCodigo.Enabled = true;
                txtBuscarNombre.Text = "";
                txtBuscarNombre.Enabled = false;
                txtBuscarApellido.Text = "";
                txtBuscarApellido.Enabled = false;
                sNombre.Checked = false;
                sApellido.Checked = false;

            }
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                if (sNombre.Checked == true)
                {
                    cmd.CommandText = "SELECT * FROM alumno WHERE ALU_nombre LIKE '"+txtBuscarNombre.Text+"%'";
                    DataTable dt = new DataTable();
                    MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                    data.Fill(dt);
                    dgvDatosBusquedaAlumno.DataSource = dt;
                    if (dgvDatosBusquedaAlumno.RowCount == 0)
                    {
                        int confirmacion = Convert.ToInt32(MessageBox.Show("el Alumno no se encuentra registrado \n ¿desea registrarlo?","ADVERTENCIA",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)) ;
                        if (confirmacion == 6)
                        {
                            PnlRegistro.Visible = true;
                            btnBuscarAlumno.Visible = true;
                            btnRegistrarAlumno.Visible = true;
                            btnRegistrarAlumno.BackColor = Color.SkyBlue;
                            btnBuscarAlumno.BackColor = Color.FromArgb(2, 91, 164);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public static int conteo = 0;
        private void txtBuscarApellido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                if (sApellido.Checked == true)
                {
                    cmd.CommandText = "SELECT * FROM alumno WHERE ALU_apellidoPaterno LIKE '" + txtBuscarApellido.Text + "%'";
                    DataTable dt = new DataTable();
                    MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                    data.Fill(dt);
                    dgvDatosBusquedaAlumno.DataSource = dt;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarDni_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                if (sCodigo.Checked == true)
                {
                    cmd.CommandText = "SELECT * FROM alumno WHERE ALU_codigo LIKE '" + txtBuscarCodigo.Text + "%'";
                    DataTable dt = new DataTable();
                    MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                    data.Fill(dt);
                    dgvDatosBusquedaAlumno.DataSource = dt;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDatosBusquedaAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnModificarBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //if (dgvDatosBusquedaAlumno.CurrentRow.Index >0)
                //{
                mostrarRegistrar();
                PnlRegistro.Visible = true;
                btnRegistrarAlumno.Visible = true;
                btnBuscarAlumno.Visible = true;
                btnRegistrarAlumno.BackColor = Color.SkyBlue;
                btnBuscarAlumno.BackColor = Color.FromArgb(2, 91, 164);
                txtNombreRegistro.Text = dgvDatosBusquedaAlumno.CurrentRow.Cells[1].Value.ToString();
                txtApellidoPaternoRegistro.Text = dgvDatosBusquedaAlumno.CurrentRow.Cells[2].Value.ToString();
                txtCodigoRegistro.Text = dgvDatosBusquedaAlumno.CurrentRow.Cells[0].Value.ToString();
                txtApellidoMaternoRegistro.Text = dgvDatosBusquedaAlumno.CurrentRow.Cells[3].Value.ToString();
                txtEmailRegistro.Text = dgvDatosBusquedaAlumno.CurrentRow.Cells[4].Value.ToString();
                txtCodigoRegistro.Enabled = false;
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"ERROR");
            }
        }

        private void btnRegistrarBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //if (dgvDatosBusquedaAlumno.CurrentRow.Index >0)
                //{
                mostrarRegistrar();
                PnlRegistro.Visible = true;
                btnRegistrarAlumno.Visible = true;
                btnBuscarAlumno.Visible = true;
                btnRegistrarAlumno.BackColor = Color.SkyBlue;
                btnBuscarAlumno.BackColor = Color.FromArgb(2, 91, 164);
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void btnAgregarRegistro_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(MessageBox.Show("Deseas grabar", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (x == 6)
            {
                MySqlCommand cmd = new MySqlCommand();
                try
                {
                    cmd.Connection = conexion;
                    //llenar();
                    cmd.CommandText = "insert into prestamo.alumno values('" + txtCodigoRegistro.Text + "','" + txtNombreRegistro.Text + "','" +txtApellidoPaternoRegistro.Text + "','" + txtApellidoMaternoRegistro.Text + "','" + txtEmailRegistro.Text + "')";
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
        private void mostrarRegistrar()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "select * from alumno";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvDatosRegistroAlumno.DataSource = dt;
        }

        private void MostrarBusqueda() 
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "select * from alumno";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgvDatosBusquedaAlumno.DataSource = dt;
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(MessageBox.Show("Deseas eliminar", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (x == 6)
            {
                MySqlCommand cmd = new MySqlCommand();
                try
                {
                    cmd.Connection = conexion;
                    //llenar();
                    cmd.CommandText = "delete from alumno where ALU_codigo='" + dgvDatosRegistroAlumno.CurrentRow.Cells[0].Value.ToString() + "'";
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posx = e.X;
                posy = e.Y;
            }
            else
            {
                Left = Left + (e.X - posx);
                Top = Top + (e.Y - posy);
            }
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(MessageBox.Show("Deseas modificar", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (x == 6)
            {
                MySqlCommand cmd = new MySqlCommand();
                try
                {
                    cmd.Connection = conexion;
                    //llenar();
                    cmd.CommandText = "update alumno set ALU_nombre='" + txtNombreRegistro.Text + "', ALU_apellidoPaterno='" + txtApellidoPaternoRegistro.Text + "',ALU_aprllidoMaterno='" + txtApellidoMaternoRegistro.Text + "',ALU_email='" + txtEmailRegistro.Text + "' where ALU_codigo='" + txtCodigoRegistro.Text + "'";
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

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                btnRegistrarAlumno.Visible = false;
                btnBuscarAlumno.Visible = false;
                PnlRegistro.Visible = false;
                btnRegistrarAlumno.BackColor = Color.FromArgb(2, 91, 164);
                btnBuscarAlumno.BackColor = Color.SkyBlue;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"ERROR"); ;
            }
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            PnlRegistro.Visible = true;
            btnRegistrarAlumno.BackColor = Color.SkyBlue;
            btnBuscarAlumno.BackColor = Color.FromArgb(2, 91, 164);

        }

        private void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(MessageBox.Show("Deseas eliminar", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (x == 6)
            {
                MySqlCommand cmd = new MySqlCommand();
                try
                {
                    cmd.Connection = conexion;
                    //llenar();
                    cmd.CommandText = "delete from alumno where ALU_codigo='" + dgvDatosBusquedaAlumno.CurrentRow.Cells[0].Value.ToString() + "'";
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    mostrarRegistrar();
                    MostrarBusqueda();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error de transacción");
                    cmd.Connection.Close();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigoRegistro.Enabled = true;
            txtApellidoMaternoRegistro.Text = "";
            txtApellidoPaternoRegistro.Text = "";
            txtCodigoRegistro.Text = "";
            txtNombreRegistro.Text = "";
            txtEmailRegistro.Text = "";
        }

        private void dgvDatosBusquedaAlumno_DoubleClick(object sender, EventArgs e)
        {
            Nombres = dgvDatosBusquedaAlumno.CurrentRow.Cells[1].Value.ToString() + " " + dgvDatosBusquedaAlumno.CurrentRow.Cells[2].Value.ToString() + " " + dgvDatosBusquedaAlumno.CurrentRow.Cells[3].Value.ToString();
            Codigo = dgvDatosBusquedaAlumno.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }
    }
}
