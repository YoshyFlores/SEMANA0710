using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMANA0710
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ftmTest ftm = new ftmTest();
          ftm.MdiParent = this; // diniendo el formulario padre
            ftm.Show(); //mostrando formulario
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContacto frmContact = new frmContacto();
            frmContact.Show();
        
        }
    }
    }

