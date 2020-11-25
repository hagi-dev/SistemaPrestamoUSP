using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPrestamoUSP
{
    public partial class SPUMenu : Form
    {
        public SPUMenu()
        {
            InitializeComponent();
        }

        private void noVisiblePaneles(Panel panel1,Panel panel2, Panel panel3) 
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }
        private void noVisiblePanelSecleccion(Panel panel1, Panel panel2)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void SPUMenu_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            pnlSeleccionPrincipal1.Visible = false;
            panel2.Visible = false;
            pnlRegistroMaterialYTipo.Visible = false;
            pnlRegistroModuloYUnidad.Visible = false;
            pnlRegistroPrestamoYAlumno.Visible = false;


        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            posicionPanelSeleccionadorPrincipal(443, 35, 435, 39);
            noVisiblePaneles(pnlRegistroMaterialYTipo, pnlRegistroModuloYUnidad, pnlRegistroPrestamoYAlumno);
        }
        private void posicionPanelSeleccionadorPrincipal(int weight1,int height1,int weight2,int height2)
        {
            try
            {
                pnlSeleccionPrincipal1.Visible = false;
                panel2.Visible = false;
                if (pnlSeleccionPrincipal1.Visible == false )
                {
                    panel2.Location = new Point(weight2, height2);
                    pnlSeleccionPrincipal1.Location = new Point(weight1, height1);
                    pnlSeleccionPrincipal1.Visible = true;
                    panel2.Visible = true;
                }
         
           }
            catch (Exception)
            {

                throw;
            }
        }

        private void visibilidadDePaneles(Panel panelVisible,Panel panelNoVisible1,Panel panelNoVisible2) 
        {
            if (panelVisible.Visible == false)
            {
                panelVisible.Visible = true;
                panelNoVisible1.Visible = false;
                panelNoVisible2.Visible = false;
            }
            else
            {
                panelVisible.Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnInicio_MouseHover(object sender, EventArgs e)
        {
              //posicionPanelSeleccionadorPrincipal(443, 35, 435, 39);
            noVisiblePaneles(pnlRegistroMaterialYTipo,pnlRegistroModuloYUnidad,pnlRegistroPrestamoYAlumno);
        }

        private void btnMaterialTipo_Click(object sender, EventArgs e)
        {
            posicionPanelSeleccionadorPrincipal(832,37,828,40);
            visibilidadDePaneles(pnlRegistroMaterialYTipo,pnlRegistroModuloYUnidad,pnlRegistroPrestamoYAlumno);
            pnlRegistroMaterialYTipo.Visible = true;
        }

        private void btnPrestamoYAlumno_Click(object sender, EventArgs e)
        {
            posicionPanelSeleccionadorPrincipal(1028,36,1024,39);
            visibilidadDePaneles(pnlRegistroPrestamoYAlumno,pnlRegistroModuloYUnidad,pnlRegistroMaterialYTipo);
            pnlRegistroPrestamoYAlumno.Visible = true;
        }

        private void btnModuloYUnidad_MouseHover(object sender, EventArgs e)
        {

                //posicionPanelSeleccionadorPrincipal(634, 37, 630, 40);
                visibilidadDePaneles(pnlRegistroModuloYUnidad, pnlRegistroPrestamoYAlumno, pnlRegistroMaterialYTipo);
         
        }

        private void btnMaterialTipo_MouseHover(object sender, EventArgs e)
        {
            //posicionPanelSeleccionadorPrincipal(832, 37, 828, 40);
            visibilidadDePaneles(pnlRegistroMaterialYTipo, pnlRegistroModuloYUnidad, pnlRegistroPrestamoYAlumno);
            
        }

        private void btnPrestamoYAlumno_MouseHover(object sender, EventArgs e)
        {
            //posicionPanelSeleccionadorPrincipal(1028, 36, 1024, 39);
            visibilidadDePaneles(pnlRegistroPrestamoYAlumno, pnlRegistroModuloYUnidad, pnlRegistroMaterialYTipo);
        }


        private void SPUMenu_MouseHover(object sender, EventArgs e)
        {
            noVisiblePaneles(pnlRegistroMaterialYTipo,pnlRegistroModuloYUnidad,pnlRegistroPrestamoYAlumno);
            //noVisiblePanelSecleccion(pnlSeleccionPrincipal1,panel2);
            

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            noVisiblePaneles(pnlRegistroMaterialYTipo, pnlRegistroModuloYUnidad, pnlRegistroPrestamoYAlumno);
            noVisiblePanelSecleccion(pnlSeleccionPrincipal1, panel2);
        }

        private void btnModuloYUnidad_Click_1(object sender, EventArgs e)
        {
            posicionPanelSeleccionadorPrincipal(634, 37, 630, 40);
            visibilidadDePaneles(pnlRegistroModuloYUnidad, pnlRegistroPrestamoYAlumno, pnlRegistroMaterialYTipo);
            pnlRegistroModuloYUnidad.Visible = true;
            
        }

        private void pnlSeleccionPrincipal1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistroModulo_Click(object sender, EventArgs e)
        {
            posicionPanelSeleccionadorPrincipal(634, 37, 630, 40);
            pnlRegistroModuloYUnidad.Visible = false;
        }

        private void btnRegistroUnidadDidactica_Click(object sender, EventArgs e)
        {
            posicionPanelSeleccionadorPrincipal(634, 37, 630, 40);
            pnlRegistroModuloYUnidad.Visible = false;
        }

        private void btnRegistroTipoMaterial_Click(object sender, EventArgs e)
        {
            posicionPanelSeleccionadorPrincipal(832, 37, 828, 40);
            pnlRegistroMaterialYTipo.Visible = false;
        }

        private void btnRegistrarMaterial_Click(object sender, EventArgs e)
        {
            posicionPanelSeleccionadorPrincipal(832, 37, 828, 40);
            pnlRegistroMaterialYTipo.Visible = false;
        }

        private void btnRegistroAlumno_Click(object sender, EventArgs e)
        {
            posicionPanelSeleccionadorPrincipal(1028, 36, 1024, 39);
            pnlRegistroPrestamoYAlumno.Visible = false;
        }

        private void btnRegistroPrestamo_Click(object sender, EventArgs e)
        {
            posicionPanelSeleccionadorPrincipal(1028, 36, 1024, 39);
            pnlRegistroPrestamoYAlumno.Visible = false;
        }
    }
}
