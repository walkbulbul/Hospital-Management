using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace WindowsFormsApp3
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Home H = new Home();
            H.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
