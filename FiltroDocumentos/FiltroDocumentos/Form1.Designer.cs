
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
            this.teste = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_arquivos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // teste
            // 
            this.teste.Location = new System.Drawing.Point(12, 40);
            this.teste.Name = "teste";
            this.teste.Size = new System.Drawing.Size(94, 29);
            this.teste.TabIndex = 0;
            this.teste.Text = "teste";
            this.teste.UseVisualStyleBackColor = true;
            this.teste.Click += new System.EventHandler(this.teste_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(756, 114);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_arquivos
            // 
            this.btn_arquivos.Location = new System.Drawing.Point(12, 222);
            this.btn_arquivos.Name = "btn_arquivos";
            this.btn_arquivos.Size = new System.Drawing.Size(94, 29);
            this.btn_arquivos.TabIndex = 3;
            this.btn_arquivos.Text = "Arquivos";
            this.btn_arquivos.UseVisualStyleBackColor = true;
            this.btn_arquivos.Click += new System.EventHandler(this.btn_arquivos_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 258);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(755, 124);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 523);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_arquivos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.teste);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button teste;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_arquivos;
        private System.Windows.Forms.ListBox listBox1;
    }
}

