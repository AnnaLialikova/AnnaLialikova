using System;
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
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
            this.IsMdiContainer = true;
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(e.ClickedItem.Tag.ToString()){
                case "NewDoc":{
                    ChildForm newChild = new ChildForm();
                        newChild.MdiParent = this;

                        newChild.Text = newChild.Text + " " + ++openDocuments;
                        newChild.Show();
                        break;
                }
                case "Cascade":{
                        this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                        break;
                }
                case "Title":
                    {
                        this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                        break;
                    }
            }
        }

        private void spWin_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows are cascade";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windows are horizontal";
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
