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
    public partial class DialogBoxCaptura : Form
    {
        public DialogBoxCaptura()
        {
            InitializeComponent();
        }

        // declaracionb de metodos get
        public string id
        {
            get { return (textBox1.Text); }
        }
        public string nombreproducto
        {
            get { return (textBox2.Text); }
        }
        public string precioproducto
        {
            get { return (textBox3.Text); }
        }
        public string existenciaproducto
        {
            get { return (textBox4.Text); }
        }
        private void DialogBoxCaptura_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }
    }
}
