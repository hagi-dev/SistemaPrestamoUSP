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
    public partial class BuscarMaterial : Form
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
        public BuscarMaterial()
        {
            InitializeComponent();
        }

        private void cbxTipoMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoMaterial.SelectedValue.ToString() != null)
            {
                String tipo = cbxTipoMaterial.SelectedValue.ToString();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "select P.* From tipo T inner JOIN material P on T.TIP_codigo=P.TIP_codigo where T.Tip_codigo=@TIP_codigo ";

                cmd.Parameters.AddWithValue("TIP_codigo", tipo);
                DataTable tablaa = new DataTable();
                MySqlDataAdapter adaptar = new MySqlDataAdapter(cmd);
                adaptar.Fill(tablaa);
                dgvDatosBusquedaMaterial.DataSource = tablaa;


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

            cbxTipoMaterial.ValueMember = "TIP_codigo";
            cbxTipoMaterial.DisplayMember = "TIP_nombre";
            cbxTipoMaterial.DataSource = dt;

        }

        private void dgvDatosBusquedaMaterial_DoubleClick(object sender, EventArgs e)
        {
            Codigo = dgvDatosBusquedaMaterial.CurrentRow.Cells[0].Value.ToString();
            Nombres = dgvDatosBusquedaMaterial.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void BuscarMaterial_Load(object sender, EventArgs e)
        {
            try
            {
                conexion = new MySqlConnection("database=prestamo; data source= localhost; user id=root; password=120613");
                conexion.Open();
                tipo();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
