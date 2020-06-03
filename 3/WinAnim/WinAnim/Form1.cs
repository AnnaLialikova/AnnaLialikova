using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAnim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAW_BLEND_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinApiClass.AnimateWindow(this, 3000, WinApiClass.AnimateWindowFlags.AW_ACTIVATE | WinApiClass.AnimateWindowFlags.AW_BLEND);
            this.buttonAW_BLEND.Invalidate();
            this.buttonHOR_AW_SLIDE.Invalidate();
            this.buttonCenter_AW_SLIDE.Invalidate();
        }

        private void buttonHOR_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinApiClass.AnimateWindow(this, 3000, WinApiClass.AnimateWindowFlags.AW_ACTIVATE | WinApiClass.AnimateWindowFlags.AW_BLEND);
            this.buttonAW_BLEND.Invalidate();
            this.buttonHOR_AW_SLIDE.Invalidate();
            this.buttonCenter_AW_SLIDE.Invalidate();
        }

        private void buttonCenter_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();
            WinApiClass.AnimateWindow(this, 3000, WinApiClass.AnimateWindowFlags.AW_ACTIVATE | WinApiClass.AnimateWindowFlags.AW_BLEND);
            this.buttonAW_BLEND.Invalidate();
            this.buttonHOR_AW_SLIDE.Invalidate();
            this.buttonCenter_AW_SLIDE.Invalidate();
        }
    }
}
