﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;
        public ParentForm()
        {
            InitializeComponent();
        }

      

        private void mdiMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Text = newChild.Text + " " + ++openDocuments;
            newChild.Show();
        }
    }
}