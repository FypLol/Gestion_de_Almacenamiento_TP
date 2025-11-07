using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Almacenamiento_TP
{
    public partial class frmHistorialMovimientos : Form
    {
        public frmHistorialMovimientos()
        {
            InitializeComponent();
        }

        private void frmHistorialMovimientos_Load(object sender, EventArgs e)
        {
            dgvHistorialMovimiento.DataSource = clsDatosGlobales.pilaGeneral.ObtenerTope();
        }
    }
}
