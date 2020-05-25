using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greenpeace
{
    public partial class Form2Start : Form
    {
        public Form2Start()
        {
            InitializeComponent();
        }

        private void buttonOpenForm2_Click(object sender, EventArgs e)
        {
            Form1 newChild = new Form1();
            newChild.Show();
        }
    }
}
