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

            try
            {
                using (SqlConnection cnbd = new SqlConnection(Conection.cbd))
                {
                    cnbd.Open();
                    var sqlQuery = "select * from elemente_uplTeste";
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
            var arquivo = Directory.GetFiles(rota);
<<<<<<< HEAD
            
=======

>>>>>>> ec80f4d39463554c4b743574670d338eab930b95
            foreach (string dir in arquivo)
                listBox1.Items.Add(dir);

            count.Text = arquivo.Length.ToString();
<<<<<<< HEAD
=======
            count.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (SqlConnection cnbd = new SqlConnection(Conection.cbd))
            //    {
            //        cnbd.Open();
            //        var sqlQuery = "select EDARQUIVO from LICITACAOARQUIVO_TB";
            //        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cnbd))
            //        {
            //            using (DataTable dt = new DataTable())
            //            {
            //                da.Fill(dt);
            //                dataGridView1.DataSource = dt;
            //            }
            //        }
            //    }

            //}
            //catch (SqlException erro)
            //{
            //    MessageBox.Show("Erro ao conectar, verifique os dados!\n" + erro);
            //}

            FolderBrowserDialog fbd1 = new FolderBrowserDialog();
            fbd1.Description = "Selecione o diretório de destino";
            //define pasta inicial
            fbd1.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd1.ShowNewFolderButton = true;
            if (fbd1.ShowDialog() == DialogResult.OK)
            {
                // Exibe a pasta selecionada
                lblPath.Text = fbd1.SelectedPath;
                lblPath.Visible = true;
            }

            string origem = lblPath.Text;
            string arquivo = Path.GetFileName(origem);
            // string destino = Path.Combine(count.Text, arquivo);

            // File.Copy(origem, destino, true);
            // MessageBox.Show($"Arquivo {origem} Copiado com sucesso \npara {destino}");
            lblPath.Text = fbd1.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
>>>>>>> ec80f4d39463554c4b743574670d338eab930b95

        }

    }
}
