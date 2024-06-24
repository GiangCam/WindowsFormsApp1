using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giaiPtbac2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giaiptbac2 giaiptbac2 = new Giaiptbac2();
            giaiptbac2.ShowDialog();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Đinhdang đinhdang = new Đinhdang(); 
            Đinhdang.sh
        }
    }
}
