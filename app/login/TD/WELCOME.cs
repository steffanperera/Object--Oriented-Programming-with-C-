using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TD
{
    public partial class WELCOME : Form
    {
        public WELCOME()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registraton frm = new Registraton();
            frm.ShowDialog();
        }
    }
}
