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

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        //Conexión a la bade de datos
        string cadenaConexion = "DataSource=localhost;port=3306;username=root;password=hcpk8546;database=db_ironMountain;";

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            string consulta = "select * from dbo_empleados";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
