using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArreglosRegistros
{
    class Producto
    {
        // declaracion de propiedades 
        public int Id;
        public string NombreProducto;
        public double PrecioProducto;
        public int ExistenciaProducto;

        // declaracion de metodo get-set
        public int id
        {
            set { value = Id; }
            get { return (Id); }
        }

        public string nombreproducto
        {
            set { value = NombreProducto; }
            get { return (NombreProducto); }
        }
        public double precioproducto
        {
            set { value = PrecioProducto; }
            get { return (PrecioProducto); }
        }
        public int existenciaproducto
        {
            set { value = ExistenciaProducto; }
            get { return (ExistenciaProducto); }
        }
        // declaracion del producto
        public Producto()
        {
            Id = 0;
            NombreProducto = "";
            PrecioProducto = 0;
            ExistenciaProducto = 0;
        }

        //DECLARACION DE METODOS DEFINIDOS POR EL USUARIO
        public Producto[] AgregarDatos(Producto[] A, int i)
        {
            DialogBoxCaptura captura = new DialogBoxCaptura();
            if (captura.ShowDialog() == DialogResult.OK)
            {
                A[i].Id = int.Parse(captura.id);
                A[i].NombreProducto = captura.nombreproducto;
                A[i].PrecioProducto = double.Parse(captura.precioproducto);
                A[i].ExistenciaProducto = int.Parse(captura.existenciaproducto);
                MessageBox.Show("Los datos se almacenaron en el arreglo", "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (A);
        }
        public void MostrarTodos(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            for (int i = 0; i < 50; i++)
            {
                if (A[i].Id != 0)

                {
                    ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                    lista.SubItems.Add(A[i].NombreProducto);
                    lista.SubItems.Add(A[i].PrecioProducto.ToString());
                    lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                    caja.Items.Add(lista);
                }
            }
        }

        public void MostrarNombreProducto(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = false;
            CapturaBoxBuscarNombre busca = new CapturaBoxBuscarNombre();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].NombreProducto.ToUpper() == busca.nombreproducto.ToUpper())
                    {
                        sw = true;
                        ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
                if (sw == false)
                {
                    MessageBox.Show("No se encontro el nombre del producto en el arreglo", "Arreglos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        public void MostrarPrecioProducto(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = false;
            CapturaBoxBuscarPrecio busca = new CapturaBoxBuscarPrecio();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].PrecioProducto == double.Parse(busca.precioproducto))
                    {
                        sw = true;
                        ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
                if (sw == false)
                {
                    MessageBox.Show("No se encontro el precio del producto en el arreglo", "Arreglos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void MostrarExistenciaProducto(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = false;
            CapturaBoxBuscarExistencia busca = new CapturaBoxBuscarExistencia();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    {
                        sw = true;
                        ListViewItem lista = new ListViewItem(A[i].Id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
                if (sw == false)
                {
                    MessageBox.Show("No se encontro la existencia  del producto en el arreglo", "Arreglos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
