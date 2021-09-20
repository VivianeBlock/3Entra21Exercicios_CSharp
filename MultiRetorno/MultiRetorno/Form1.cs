using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiRetorno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            if (rbExec03.Checked)
            {
                new Exec03().Show();
                this.Hide();
            }
        }
    }
}
