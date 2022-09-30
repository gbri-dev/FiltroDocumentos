
namespace FiltroDocumentos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnColuna = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_arquivos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.bntConcatenar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtColuna = new System.Windows.Forms.TextBox();
            this.txtTabela = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColuna
            // 
            this.btnColuna.Location = new System.Drawing.Point(56, 72);
            this.btnColuna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColuna.Name = "btnColuna";
            this.btnColuna.Size = new System.Drawing.Size(82, 22);
            this.btnColuna.TabIndex = 0;
            this.btnColuna.Text = "Consulta";
            this.btnColuna.UseVisualStyleBackColor = true;
            this.btnColuna.Click += new System.EventHandler(this.teste_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 114);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(662, 208);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_arquivos
            // 
            this.btn_arquivos.Location = new System.Drawing.Point(10, 436);
            this.btn_arquivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_arquivos.Name = "btn_arquivos";
            this.btn_arquivos.Size = new System.Drawing.Size(82, 22);
            this.btn_arquivos.TabIndex = 3;
            this.btn_arquivos.Text = "Arquivos";
            this.btn_arquivos.UseVisualStyleBackColor = true;
            this.btn_arquivos.Click += new System.EventHandler(this.btn_arquivos_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(11, 338);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(661, 94);
            this.listBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(57, 472);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(38, 15);
            this.count.TabIndex = 6;
            this.count.Text = "count";
            // 
            // bntConcatenar
            // 
            this.bntConcatenar.Location = new System.Drawing.Point(10, 509);
            this.bntConcatenar.Name = "bntConcatenar";
            this.bntConcatenar.Size = new System.Drawing.Size(75, 23);
            this.bntConcatenar.TabIndex = 7;
            this.bntConcatenar.Text = "Concatenar";
            this.bntConcatenar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(91, 509);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(353, 487);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(286, 45);
            this.lblNote.TabIndex = 10;
            this.lblNote.Text = "Concatena nome da pasta com nome do arquivo\r\nFiltrar se existe o arquivo no banco" +
    " de dados e copiar\r\nos existentes para uma nova pasta.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Path";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(56, 487);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(23, 15);
            this.lblPath.TabIndex = 12;
            this.lblPath.Text = "C:/\r\n";
            // 
            // txtColuna
            // 
            this.txtColuna.Location = new System.Drawing.Point(57, 44);
            this.txtColuna.Name = "txtColuna";
            this.txtColuna.Size = new System.Drawing.Size(216, 23);
            this.txtColuna.TabIndex = 13;
            // 
            // txtTabela
            // 
            this.txtTabela.Location = new System.Drawing.Point(57, 15);
            this.txtTabela.Name = "txtTabela";
            this.txtTabela.Size = new System.Drawing.Size(216, 23);
            this.txtTabela.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tabela";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Coluna";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 550);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTabela);
            this.Controls.Add(this.txtColuna);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.bntConcatenar);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_arquivos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnColuna);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColuna;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_arquivos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Button bntConcatenar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtColuna;
        private System.Windows.Forms.TextBox txtTabela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

