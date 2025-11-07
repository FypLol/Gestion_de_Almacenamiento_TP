using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_de_Almacenamiento_TP;

namespace Gestion_de_Almacenamiento_TP
{
   
    public class clsEstructuras
    {
        public class NodoPaquete
        {
            public clsPaquete Dato;
            public NodoPaquete Siguiente;
        }

        public class NodoMovimiento
        {
            public string Descripcion;
            public DateTime Fecha;
            public NodoMovimiento Siguiente;
        }

        public class NodoPedido
        {
            public clsPaquete Dato;
            public NodoPedido Siguiente;
        }

        public class ListaPaquetes
        {

            public NodoPaquete Primero;

            public void Agregar(clsPaquete p)
            {
                NodoPaquete nuevo = new NodoPaquete();
                nuevo.Dato = p;
                nuevo.Siguiente = null;

                if (Primero == null)
                    Primero = nuevo;
                else
                {
                    NodoPaquete aux = Primero;
                    while (aux.Siguiente != null)
                        aux = aux.Siguiente;
                    aux.Siguiente = nuevo;
                }
            }

            public bool Eliminar(string codigo)
            {
                if (Primero == null)
                    return false;

                if (Primero.Dato.Codigo == codigo)
                {
                    Primero = Primero.Siguiente;
                    return true;
                }

                NodoPaquete aux = Primero;
                while (aux.Siguiente != null)
                {
                    if (aux.Siguiente.Dato.Codigo == codigo)
                    {
                        aux.Siguiente = aux.Siguiente.Siguiente;
                        return true;
                    }
                    aux = aux.Siguiente;
                }
                return false;
            }

            public NodoPaquete Buscar(string codigo)
            {
                NodoPaquete aux = Primero;
                while (aux != null)
                {
                    if (aux.Dato.Codigo == codigo)
                        return aux;
                    aux = aux.Siguiente;
                }
                return null;
            }

            public int Contar()
            {
                int cont = 0;
                NodoPaquete aux = Primero;
                while (aux != null)
                {
                    cont++;
                    aux = aux.Siguiente;
                }
                return cont;
            }

            public NodoPaquete ObtenerPrimero()
            {
                return Primero;
            }

    
        }

        public class PilaMovimientos
        {
            public NodoMovimiento Tope;

            // ➕ Registrar un nuevo movimiento
            public void Apilar(string descripcion)
            {
                NodoMovimiento nuevo = new NodoMovimiento();
                nuevo.Descripcion = descripcion;
                nuevo.Fecha = DateTime.Now;
                nuevo.Siguiente = Tope;
                Tope = nuevo;
            }

            // ❌ Deshacer último movimiento
            public NodoMovimiento Desapilar()
            {
                if (Tope == null)
                    return null;

                NodoMovimiento aux = Tope;
                Tope = Tope.Siguiente;
                return aux;
            }

            // 👀 Ver el movimiento más reciente sin eliminarlo
            public NodoMovimiento VerTope()
            {
                return Tope;
            }

            // 🔢 Contar movimientos
            public int Contar()
            {
                int cont = 0;
                NodoMovimiento aux = Tope;
                while (aux != null)
                {
                    cont++;
                    aux = aux.Siguiente;
                }
                return cont;
            }

            // 📋 Obtener todos los movimientos (para mostrar en formulario)
            public NodoMovimiento ObtenerTope()
            {
                return Tope;
            }
        }

        // ============================================================
        // 🔹 COLA (Gestión de Pedidos Pendientes)
        // ============================================================

        public class ColaPedidos
        {
            public NodoPedido Frente;
            public NodoPedido Final;

            // ➕ Encolar un nuevo pedido
            public void Encolar(clsPaquete p)
            {
                NodoPedido nuevo = new NodoPedido();
                nuevo.Dato = p;
                nuevo.Siguiente = null;

                if (Frente == null)
                {
                    Frente = nuevo;
                    Final = nuevo;
                }
                else
                {
                    Final.Siguiente = nuevo;
                    Final = nuevo;
                }
            }

            // ❌ Desencolar (atender siguiente pedido)
            public clsPaquete Desencolar()
            {
                if (Frente == null)
                    return null;

                clsPaquete dato = Frente.Dato;
                Frente = Frente.Siguiente;

                if (Frente == null)
                    Final = null;

                return dato;
            }

            // 👀 Ver el siguiente pedido en la cola
            public clsPaquete VerFrente()
            {
                if (Frente != null)
                    return Frente.Dato;
                return null;
            }

            // 🔢 Contar pedidos pendientes
            public int Contar()
            {
                int cont = 0;
                NodoPedido aux = Frente;
                while (aux != null)
                {
                    cont++;
                    aux = aux.Siguiente;
                }
                return cont;
            }

            // 📋 Obtener todos los pedidos (para mostrar)
            public NodoPedido ObtenerFrente()
            {
                return Frente;
            }
        }

    }



    

}
