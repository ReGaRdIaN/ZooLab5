using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooLab5
{
    public partial class Main_Form_Admin : Form
    {
        public Main_Form_Admin()
        {
            InitializeComponent();
        }

        private void Main_Form_Admin_Load(object sender, EventArgs e)
        {

        }

        private void Main_Form_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
