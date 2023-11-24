using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;


/*
 CADENA DE CONEXION LOCAL:
"Data Source=.\SQLEXPRESS;Initial Catalog=LAVADERO;Integrated Security=True;"
 */

namespace LavaderoAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarComboProductos();
            cboProductos.SelectedIndex = -1;
            lblProximo.Text += proximoNumero();
        }

        private string proximoNumero()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=LAVADERO;Integrated Security=True;");
            SqlCommand comando = new SqlCommand();
            cnn.Open();
            comando.Connection = cnn;
            comando.CommandText = "SP_PROXIMO_ID";
            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = "@next";
            parametro.DbType = DbType.Int32;
            parametro.Direction = ParameterDirection.Output;

            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();

            string proximoCodigo = parametro.Value.ToString();

            cnn.Close();

            return proximoCodigo;
        }


        private void CargarComboProductos()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=LAVADERO;Integrated Security=True;");
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SP_COMBO_PRODUCTOS";
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable tablaCombo = new DataTable();
            tablaCombo.Load(cmd.ExecuteReader());
            cboProductos.DataSource = tablaCombo;
            cboProductos.ValueMember = "id_producto";
            cboProductos.DisplayMember = "nombre_producto";
            cboProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductos.SelectedIndex = -1;

            cnn.Close();
        }


        private void btnProx_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=LAVADERO;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "SP_PROXIMO_ID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@next";
            param.DbType = DbType.Int32;
            param.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();

            int proximoCodigo = Convert.ToInt32(param.Value);

            cnn.Close();

            MessageBox.Show("PROXIMO CODIGO: " + proximoCodigo, "INFORMACION");
        }

        private void btnUlt_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = LAVADERO; Integrated Security = True;");
            SqlCommand cmd = new SqlCommand();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "SP_ULTIMO_ID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@last";
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();

            int ultimoCodigo;

            ultimoCodigo = (int)param.Value;
            
            cnn.Close();

            MessageBox.Show("ULTIMO CODIGO CARGADO: " +ultimoCodigo, "INFORMACION");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea salir?","SALIR",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
