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

        private void SPUMenu_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            pnlSeleccionadorInicio.Visible = false;
        }

    }
}
