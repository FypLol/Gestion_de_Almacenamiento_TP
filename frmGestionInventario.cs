using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Almacenamiento_TP
{
    public partial class frmGestionInventario : Form
    {
        clsEstructuras.ListaPaquetes listaPaquetes = new clsEstructuras.ListaPaquetes();    
        public frmGestionInventario()
        {
            InitializeComponent();
        }

        private void lbl_dni_Click(object sender, EventArgs e)
        {

        }

        private void frmGestionInventario_Load(object sender, EventArgs e)
        {
            configurarDataGridView();
        }

        private void configurarDataGridView()
        {
            dgv_GestionInventario.Columns.Clear();

            dgv_GestionInventario.Columns.Add("Codigo", "Código");
            dgv_GestionInventario.Columns.Add("Destinatario", "Destinatario");
            dgv_GestionInventario.Columns.Add("Dni", "DNI");
            dgv_GestionInventario.Columns.Add("Celular", "Celular");
            dgv_GestionInventario.Columns.Add("Tamaño", "Tamaño");
            dgv_GestionInventario.Columns.Add("Origen", "Origen de Envío");
            dgv_GestionInventario.Columns.Add("Fecha", "Fecha Recepción");

            dgv_GestionInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void actualizarTabla()
        {
            dgv_GestionInventario.Rows.Clear();

            clsEstructuras.NodoPaquete aux = listaPaquetes.Primero; 
            while(aux != null )
            {
                dgv_GestionInventario.Rows.Add(
                    aux.Dato.Codigo,
                    aux.Dato.NombreDestinatario,
                    aux.Dato.Dni,
                    aux.Dato.Celular,
                    aux.Dato.Tamaño,
                    aux.Dato.LugarOrigen,
                    aux.Dato.FechaRecepcion.ToString("dd/MM/yyyy HH:mm"));
                aux = aux.Siguiente;
            }
            

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (tbox_Codigo.Text=="" ||tbox_nombre.Text =="")
            {
                               MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }
            if(listaPaquetes.Buscar(tbox_Codigo.Text)!=null)
            {
                MessageBox.Show("El código ya existe. Ingrese un código único.");
                return;
            }

            clsPaquete nuevo = new clsPaquete();
            {
                nuevo.Codigo = tbox_Codigo.Text;

                nuevo.NombreDestinatario = tbox_nombre.Text;
                nuevo.Dni = tbox_dni.Text;
                nuevo.Celular = tbox_celular.Text;
                nuevo.Tamaño = tbox_tamaño.Text;
                nuevo.LugarOrigen = tbox_origen.Text;
                nuevo.FechaRecepcion = DateTime.Now;

            }

            listaPaquetes.Agregar(nuevo);
            clsDatosGlobales.pilaGeneral.Apilar("Se agrego el paquete con código: " + nuevo.Codigo + " y DNI: "+nuevo.Dni);
            actualizarTabla();
            limpiarCampos();
            MessageBox.Show("Paquete agregado exitosamente.");

        }
        private void limpiarCampos()
        {
            tbox_Codigo.Text = "";
            tbox_nombre.Text = "";
            tbox_dni.Text = "";
            tbox_celular.Text = "";
            tbox_tamaño.Text = "";
            tbox_origen.Text = "";
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if(tbox_Codigo.Text == "")
            {
                MessageBox.Show("Ingrese el código del paquete a editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nodo = listaPaquetes.Buscar(tbox_Codigo.Text);
            if (nodo == null)
            {
                MessageBox.Show("No se encontró el paquete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nodo.Dato.NombreDestinatario = tbox_nombre.Text;
            nodo.Dato.Dni = tbox_dni.Text;
            nodo.Dato.Celular = tbox_celular.Text;
            nodo.Dato.Tamaño = tbox_tamaño.Text;
            nodo.Dato.LugarOrigen = tbox_origen.Text;

            actualizarTabla();
            limpiarCampos();

            MessageBox.Show("Paquete editado correctamente.");
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (tbox_Codigo.Text == "")
            {
                MessageBox.Show("Ingrese el código del paquete a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool eliminado = listaPaquetes.Eliminar(tbox_Codigo.Text);

            if (eliminado)
            {
                actualizarTabla();
                limpiarCampos();
                MessageBox.Show("Paquete eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontró el paquete con ese código.");
            }
        }

        private void dgv_GestionInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv_GestionInventario.Rows[e.RowIndex];
                tbox_Codigo.Text = fila.Cells["Codigo"].Value.ToString();
                tbox_nombre.Text = fila.Cells["Destinatario"].Value.ToString();
                tbox_dni.Text = fila.Cells["Dni"].Value.ToString();
                tbox_celular.Text = fila.Cells["Celular"].Value.ToString();
                tbox_tamaño.Text = fila.Cells["Tamaño"].Value.ToString();
                tbox_origen.Text = fila.Cells["Origen"].Value.ToString();
            }
        }

        private void btn_buscarCodigo_Click(object sender, EventArgs e)
        {
            string dniBuscar = tbox_codigoBuscar.Text;

            if (dniBuscar == "")
            {
                MessageBox.Show("Por favor, ingrese un DNI para buscar.");
                return;
            }

            dgv_GestionInventario.Rows.Clear();

            // Recorremos la lista enlazada completa (por si hay más de un paquete del mismo DNI)
            clsEstructuras.NodoPaquete aux = listaPaquetes.Primero;
            bool encontrado = false;

            while (aux != null)
            {
                if (aux.Dato.Dni == dniBuscar)
                {
                    dgv_GestionInventario.Rows.Add(
                        aux.Dato.Codigo,
                        aux.Dato.NombreDestinatario,
                        aux.Dato.Dni,
                        aux.Dato.Celular,
                        aux.Dato.Tamaño,
                        aux.Dato.LugarOrigen,
                        aux.Dato.FechaRecepcion.ToString("dd/MM/yyyy HH:mm")
                    );
                    encontrado = true;
                }
                aux = aux.Siguiente;
            }

            if (!encontrado)
                MessageBox.Show("No se encontró ningún paquete con ese DNI.");
        }

        private void btn_mostrarTodo_Click(object sender, EventArgs e)
        {
            tbox_codigoBuscar.Text = "";
            actualizarTabla();
        }
    }
}
