using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace FiltroDocumentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            count.Visible = false;
        }

        private void teste_Click(object sender, EventArgs e)
        {
            //DialogResult OpDoUser = new DialogResult();
            //OpDoUser = MessageBox.Show("Qual o Nome da sua Tabela? ", "Table", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if(OpDoUser == DialogResult.OK)
            //{
            var nomeColuna = txtColuna.Text;
            var nomeTabela = txtTabela.Text;
                try
                {
                    using (SqlConnection cnbd = new SqlConnection(Conection.cbd))
                    {
                        cnbd.Open();
                        var sqlQuery = $"select {nomeColuna} from {nomeTabela}";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cnbd))
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
           // }
          
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
            lblPath.Text = rota;
            lblNote.Visible = false;
        }
        private void GetFile(string rota)
        {
            var arquivo = Directory.GetFiles(rota);

            foreach (string dir in arquivo)
                listBox1.Items.Add(dir);

            count.Text = arquivo.Length.ToString();
            count.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
                      
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
