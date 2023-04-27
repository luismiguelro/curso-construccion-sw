using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase24_abril
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            // crear la conexion a la bd
            string conexionSql = ("server=LAPTOP-813IK0E5;database=clase24_abril; integrated security=true");
            SqlConnection conexion = new SqlConnection(conexionSql);
            //abrir conexion
            conexion.Open();
            MessageBox.Show("Se abrió la conexion con el servidor SQL");
            conexion.Close();
            MessageBox.Show("Se cerró la conexion con el servidor SQL");

        }
    }
}
