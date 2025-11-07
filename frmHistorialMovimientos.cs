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
            mostrarHistorial();
        }

        private void mostrarHistorial()
        {
            // No permitir fila vacía al final
            dgvHistorialMovimiento.AllowUserToAddRows = false;

            // Limpiamos la tabla antes de cargar
            dgvHistorialMovimiento.Rows.Clear();
            dgvHistorialMovimiento.Columns.Clear();

            // Creamos las columnas
            dgvHistorialMovimiento.Columns.Add("Descripcion", "Descripción");
            dgvHistorialMovimiento.Columns.Add("Fecha", "Fecha y Hora");

            // Recorremos manualmente la pila SIN usar List ni array
            clsEstructuras.NodoMovimiento aux = clsDatosGlobales.pilaGeneral.Tope;

            while (aux != null)
            {
                dgvHistorialMovimiento.Rows.Add(aux.Descripcion, aux.Fecha.ToString("dd/MM/yyyy HH:mm:ss"));
                aux = aux.Siguiente;
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            var mov = clsDatosGlobales.pilaGeneral.Desapilar();

            if (mov != null)
                MessageBox.Show("Se deshizo el último movimiento:\n" + mov.Descripcion);
            else
                MessageBox.Show("No hay movimientos para deshacer.");

            mostrarHistorial(); // Refrescamos la tabla
        }
    }
}
