using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezba2._1.c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Simple MessageBox");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poruka", "Naslov");
        }

        private void mbtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Poruka", "Naslov",MessageBoxButtons.OKCancel)
                == DialogResult.OK)
                label1.Text = "OK";
            else
                label1.Text = "Cancel";
        }

        private void messageBoxSaIkonicamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rez = 
                MessageBox.Show("Da li ste punoletni?",
                "Preko 18",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if (rez == DialogResult.Yes)
                label1.Text = "Da";
            else if (rez == DialogResult.No)
                label1.Text = "Ne";
            else
                label1.Text = "Cancel";
        }

        private void messageBoxSaDefaultDugmetomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rez =
                MessageBox.Show("Da li ste punoletni?",
                "Preko 18",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (rez == DialogResult.Yes)
                label1.Text = "Da";
            else if (rez == DialogResult.No)
                label1.Text = "Ne";
            else
                label1.Text = "Cancel";
        }

        private void messageBoxSaOpcijamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rez =
                MessageBox.Show("Da li ste punoletni?",
                "Preko 18",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign,
                true );
            if (rez == DialogResult.Yes)
                label1.Text = "Da";
            else if (rez == DialogResult.No)
                label1.Text = "Ne";
            else
                label1.Text = "Cancel";
        }
    }
}
