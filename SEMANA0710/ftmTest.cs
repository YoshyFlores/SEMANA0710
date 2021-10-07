using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SEMANA0710
{
    public partial class ftmTest : Form
    {
        public ftmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "";
            MySqlConnection conn;
            try
            {
                connectionString = @"Server=localhost;Database=smis537818;Uid=root;Pwd=usbw; SSL Mode=None";
                conn = new MySqlConnection(connectionString);
                conn.Open();
                //MessageBox.Show("Se establecio conexion a la base de datos");
                MetroFramework.MetroMessageBox.Show(this,
                   "Se establecio conexión a la base de datos", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
           
            }
            catch (Exception Ex)
            {
               // MessageBox.Show(Ex.Message);
                MetroFramework.MetroMessageBox.Show(this,
                    Ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ftmTest_Load(object sender, EventArgs e)
        {

        }
    }
}
