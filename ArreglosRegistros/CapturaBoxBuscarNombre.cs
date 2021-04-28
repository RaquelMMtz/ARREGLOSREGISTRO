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
    public partial class CapturaBoxBuscarNombre : Form
    {
        public CapturaBoxBuscarNombre()
        {
            InitializeComponent();
        }

        //Declaracion de metetodo get
        public string nombreproducto
        {
            get { return (textBox1.Text); }
        }
        private void CapturaBoxBuscarNombre_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
