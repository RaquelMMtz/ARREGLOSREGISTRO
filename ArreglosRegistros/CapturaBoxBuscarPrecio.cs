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
    public partial class CapturaBoxBuscarPrecio : Form
    {
        public CapturaBoxBuscarPrecio()
        {
            InitializeComponent();
        }

        //Declaracion de metetodo get
        public string precioproducto
        {
            get { return (textBox1.Text); }
        }
        private void CapturaBoxBuscarPrecio_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
