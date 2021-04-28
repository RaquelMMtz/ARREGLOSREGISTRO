using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArreglosRegistros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Producto[] A;
        Producto x = new Producto();
        int cont = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            A = new Producto[50];
            for (int i = 0; i < 50; i++)
            {
                A[i] = new Producto();
            }
        }

        private void agregarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = x.AgregarDatos(A, cont);
            cont++;
        }

        private void todosLosDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarTodos(A, listView1);
        }

        private void porNombreDelProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarNombreProducto(A, listView1);
        }

        private void porPrecioDelProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarPrecioProducto(A, listView1);
        }

        private void porExistenciaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarExistenciaProducto(A, listView1);
        }
    }
}
