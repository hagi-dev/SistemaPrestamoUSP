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
    public partial class RegistroPrestamoMaterial : Form
    {
        MySqlConnection conexion;
        public RegistroPrestamoMaterial()
        {
            InitializeComponent();
        }

        private void RegistroPrestamoMaterial_Load(object sender, EventArgs e)
        {
            try
            {
                conexion = new MySqlConnection("database = prestamo; data source= localhost; user id= root; password=120613");
                //conexion.Open();
                dtpFechaPrestamo.Format = DateTimePickerFormat.Custom;
                dtpFechaPrestamo.CustomFormat = "yyyy-MM-dd";
                dtpFechaDevolucion.Format = DateTimePickerFormat.Custom;
                dtpFechaDevolucion.CustomFormat = "yyyy-MM-dd";
                dtpFechaPrestamo.Value = DateTime.Now;
                dtpFechaDevolucion.Value = DateTime.Now;
                estado();
                modulo();
                CodigoDetalle11();
                VerificaionDeExistenciaCodigoPrestamo();
                lblVerificacionCodigoPrestamo.Text = " ";
            }
            catch (Exception)
            {

                
            }
        }

        private void modulo()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            //cmd.Connection.Open();
            cmd.CommandText = "SELECT MOD_codigo,MOD_nombre FROM modulo;";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            DataRow fila = dt.NewRow();
            fila["MOD_nombre"] = "Selecciona Modulo";
            dt.Rows.InsertAt(fila, 0);

            cbxModulo.ValueMember = "MOD_codigo";
            cbxModulo.DisplayMember = "MOD_nombre";
            cbxModulo.DataSource = dt;
            //cmd.Connection.Close();

        }

        private void unidadd(String modulo) 
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            //cmd.Connection.Open();
            cmd.CommandText= "SELECT UNI_nombre,UNI_codigo FROM unidad where MOD_codigo=@MOD_codigo;";
            cmd.Parameters.AddWithValue("MOD_codigo",modulo);
            DataTable tabla = new DataTable();
            MySqlDataAdapter datas = new MySqlDataAdapter(cmd);
            datas.Fill(tabla);
            DataRow Fila1 = tabla.NewRow();
            Fila1["UNI_nombre"] = "Seleccione unidad";
            tabla.Rows.InsertAt(Fila1,0);
            cbxUnidadD.DataSource = tabla;
            cbxUnidadD.ValueMember = "UNI_codigo";
            cbxUnidadD.DisplayMember = "UNI_nombre";
            //cmd.Connection.Close();
        }
        private void estado()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            //cmd.Connection.Open();
            cmd.CommandText = "SELECT MAT_codigo,MAT_estado FROM material;";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            DataRow filaunidadprimera = dt.NewRow();
            filaunidadprimera["MAT_estado"] = "Selecciona Estado";
            dt.Rows.InsertAt(filaunidadprimera, 0);

            cbxEstadoMaterialPrestado.ValueMember = "MAT_codigo";
            cbxEstadoMaterialPrestado.DisplayMember = "MAT_estado";
            cbxEstadoMaterialPrestado.DataSource = dt;
            //cmd.Connection.Close();
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.ShowDialog();
            txtCodigoAlumno.Text = alumno.Codigo;
            txtNombresAlumno.Text = alumno.Nombres;
        }

        private void txtCodigoPrestamo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigoPrestamo.Text == "" || txtCodigoPrestamo.Text.Length < 5)
            {
                errorProvider1.SetError(txtCodigoPrestamo, "el campo debe tener 5 caracteres una letra y 4 numeros");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCantidadDeMaterial_Validating(object sender, CancelEventArgs e)
        {
            if (txtCantidadDeMaterial.Text == "")
            {
                errorProvider1.SetError(txtCantidadDeMaterial,"Este campo no puede estar vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        //metodo para verificar si existe o  no el codigo del prestamo

        private void VerificaionDeExistenciaCodigoPrestamo() 
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "SELECT PRE_codigo FROM prestamo where PRE_codigo = '" + txtCodigoPrestamo.Text + "';";
            cmd.Connection.Open();
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.HasRows)
            {
                lblVerificacionCodigoPrestamo.ForeColor = Color.Red;
                lblVerificacionCodigoPrestamo.Text = "El codigo ya existe*";
                
            }
            else
            {
                lblVerificacionCodigoPrestamo.ForeColor = Color.Green;
                lblVerificacionCodigoPrestamo.Text = "Estabien el codigo :)*";
            }
            MessageBox.Show(leer.HasRows.ToString());
            cmd.Connection.Close();
        





        }

        private void txtCantidadDeMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCodigoAlumno_Validating(object sender, CancelEventArgs e)
        {
            if (txtCantidadDeMaterial.Text == "")
            {
                errorProvider1.SetError(txtCantidadDeMaterial, "Este campo no puede estar vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCodigoMaterial_Validating(object sender, CancelEventArgs e)
        {
            if (txtCantidadDeMaterial.Text == "")
            {
                errorProvider1.SetError(txtCantidadDeMaterial, "Este campo no puede estar vacio");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
       
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigoPrestamo.Text = "";
            txtObservacion.Text = "";
            txtNombresAlumno.Text = "";
            txtCodigoAlumno.Text = "";
            txtCodigoMaterial.Text = "";
            txtNombreMaterial.Text = "";
            txtCantidadDeMaterial.Text = "";
            cbxModulo.SelectedIndex = 0;
            cbxUnidadD.SelectedIndex = 0;
            cbxEstadoMaterialPrestado.SelectedIndex = 0;
        }
        //public static int CodigoDetalle = 1010;
        private int CodigoDetalle11() 
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "SELECT DET_codigo FROM detalle ORDER by DET_codigo DESC LIMIT 1 ";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            cbxSoloCodigo.ValueMember = "DET_codigo";
            cbxSoloCodigo.DisplayMember = "DET_codigo";
            cbxSoloCodigo.DataSource = dt;
            cmd.Connection.Close();
            cbxSoloCodigo.SelectedIndex = 0;
            return Convert.ToInt32(cbxSoloCodigo.SelectedValue.ToString());
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int TotalFilas = Convert.ToInt32(dgvDatosPrestamoMateriales.RowCount.ToString());
            int x = Convert.ToInt32(MessageBox.Show("Deseas grabar", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (x == 6)
            {
                MySqlCommand cmd = new MySqlCommand();
                MySqlCommand querys = new MySqlCommand();
                try
                {
                    int valorCodDetalle = CodigoDetalle11();
                    cmd.Connection = conexion;
                    querys.Connection = conexion;
                    //llenar();
                    querys.CommandText = "insert into prestamo.prestamo values('" + txtCodigoPrestamo.Text + "','" + dtpFechaPrestamo.Text + "','" + txtObservacion.Text + "','" + dtpFechaDevolucion.Text + "','" + txtCodigoAlumno.Text + "','" + cbxUnidadD.SelectedValue.ToString() + "');";
                    querys.Connection.Open();
                    querys.ExecuteNonQuery();
                    querys.Connection.Close();
                    MessageBox.Show("se ingreso correctamente los datos");
                    foreach (DataGridViewRow item in dgvDatosPrestamoMateriales.Rows)
                    {
                        valorCodDetalle++;
                        //String detalleCodigo = CodigoDetalle.ToString();
                        cmd.CommandText = "insert into prestamo.detalle values('" + valorCodDetalle + "','" +item.Cells[2].Value.ToString() +"','" + item.Cells[3].Value.ToString() + "','" + "bueno"+ "','" + txtCodigoPrestamo.Text + "','"+ item.Cells[0].Value.ToString() + "');";
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                    }
                    cmd.Connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error de transacción");
                    cmd.Connection.Close();
                }
            }
           
        }


        private void btnBuscarMaterial_Click(object sender, EventArgs e)
        {
            BuscarMaterial buscarMaterial = new BuscarMaterial();
            buscarMaterial.ShowDialog();
            txtCodigoMaterial.Text = buscarMaterial.Codigo;
            txtNombreMaterial.Text = buscarMaterial.Nombres;
        }

        private void cbxModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxModulo.SelectedValue.ToString() != null)
            {
                String MOD_codigo = cbxModulo.SelectedValue.ToString();
                unidadd(MOD_codigo);
            }
        }

        private bool VerificarSiExisteCodigoPrestamoEnBd(String codigo) 
        {


            MySqlCommand cmd = new MySqlCommand();
            bool verdad = false;
            cmd.Connection = conexion;
            cmd.Connection.Open();
            cmd.CommandText = "SELECT PRE_codigo FROM prestamo where PRE_codigo = '" + codigo + "';";
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                verdad = true;
            }
            else
            {
                verdad = false;
            }
            cmd.Connection.Close();

            return verdad;

        }
       
        private void btnAgregarDataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                //CodigoDetalle11();
                DateTime fechaPrestamo = dtpFechaPrestamo.Value;
                DateTime fechaDevolucion = dtpFechaDevolucion.Value;
                int resultado = DateTime.Compare(fechaPrestamo,fechaDevolucion);
                bool seRepite;
                seRepite = dgvDatosPrestamoMateriales.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells[0].Value) == txtCodigoMaterial.Text);
                if (resultado > 0 || seRepite || txtCodigoPrestamo.Text == "" || txtCantidadDeMaterial.Text == "" || txtCodigoAlumno.Text == "" || txtCodigoMaterial.Text == "" || cbxModulo.Text == "" || cbxUnidadD.Text == "")
                {
                    MessageBox.Show("falta campos por rellenar o ya se agrego el material  ","ERROR");
                }
                else
                {
                    if (VerificarSiExisteCodigoPrestamoEnBd(txtCodigoPrestamo.Text))
                    {
                        MessageBox.Show("el codigo del prestamo ya existe elige otro ", "ERROR");
                    }
                    else
                    {
                        //int ver = CodigoDetalle11();
                        dgvDatosPrestamoMateriales.Rows.Add(txtCodigoMaterial.Text,txtNombreMaterial.Text,txtCantidadDeMaterial.Text,cbxEstadoMaterialPrestado.Text);
                        //int totalFilas = Convert.ToInt32(dgvDatosPrestamoMateriales.RowCount.ToString());
                        //MessageBox.Show("ele codigo detalle"+ver);
                        txtCodigoMaterial.Text = "";
                        txtNombreMaterial.Text = "";
                        txtCantidadDeMaterial.Text = "";
                        cbxEstadoMaterialPrestado.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR");
                
            }
        }

        private void dtpFechaDevolucion_Validating(object sender, CancelEventArgs e)
        {
            DateTime fechaPrestamo = dtpFechaPrestamo.Value;
            DateTime fechaDevolucion = dtpFechaDevolucion.Value;
            int resultado = DateTime.Compare(fechaPrestamo, fechaDevolucion);
            if (resultado>0)
            {
                errorProvider1.SetError(dtpFechaDevolucion,"tiene que ser mayor a fecha de prestamo");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnEliminarDeDataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDatosPrestamoMateriales.RowCount.ToString() == "0")
                {
                    MessageBox.Show("no hay filas a eliminar");
                }
                else
                {
                    dgvDatosPrestamoMateriales.Rows.RemoveAt(dgvDatosPrestamoMateriales.CurrentRow.Index);
                    
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERROR") ;
            }
            finally
            {
                MessageBox.Show("no puedes eliminar algo que no as seleccionado", "ERROR");
            }
         
        }

        private void txtCodigoPrestamo_Enter(object sender, EventArgs e)
        {
            lblVerificacionCodigoPrestamo.Text = "Ejemplo: P0001*";

        }

        private void txtCodigoPrestamo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCodigoPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {

                VerificaionDeExistenciaCodigoPrestamo();
            }
        }
    }
}
