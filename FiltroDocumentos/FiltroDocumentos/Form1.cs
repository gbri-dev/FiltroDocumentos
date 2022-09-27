using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiltroDocumentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void teste_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection cnbd = new SqlConnection(Conection.cbd))
                {
                    cnbd.Open();
                    var sqlQuery = "select * from t_elemento_upl";
                    using(SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cnbd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }

            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro ao conectar, verifique os dados!\n" + erro);
            }
        }

        private void btn_arquivos_Click(object sender, EventArgs e)
        {
            string rota = "";
            using (var OpenDlg = new FolderBrowserDialog())
            {
                OpenDlg.SelectedPath = rota;
                if(OpenDlg.ShowDialog() == DialogResult.OK)
                {
                    rota = OpenDlg.SelectedPath;
                }
                listBox1.Items.Clear();
                GetDir(rota);
                GetFile(rota);
            }
        }
        private void GetDir(string rota)
        {
            var diretorio = Directory.GetDirectories(rota);

            foreach (string dir in diretorio)
                listBox1.Items.Add(dir + "<dir>");
        }
        private void GetFile(string rota)
        {
            var arquivo = Directory.GetDirectories(rota);

            foreach (string dir in arquivo)
                listBox1.Items.Add(dir);
        }
    }
}
