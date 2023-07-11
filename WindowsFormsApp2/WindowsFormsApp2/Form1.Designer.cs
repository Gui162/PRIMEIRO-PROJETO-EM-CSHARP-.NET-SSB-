namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.id = new System.Windows.Forms.TextBox();
            this.forncedor = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.TextBox();
            this.observacao = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(23, 22);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(212, 20);
            this.id.TabIndex = 0;
            // 
            // forncedor
            // 
            this.forncedor.Location = new System.Drawing.Point(23, 65);
            this.forncedor.Name = "forncedor";
            this.forncedor.Size = new System.Drawing.Size(212, 20);
            this.forncedor.TabIndex = 1;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(23, 109);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(212, 20);
            this.data.TabIndex = 2;
            // 
            // observacao
            // 
            this.observacao.Location = new System.Drawing.Point(23, 147);
            this.observacao.Multiline = true;
            this.observacao.Name = "observacao";
            this.observacao.Size = new System.Drawing.Size(212, 74);
            this.observacao.TabIndex = 3;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(72, 227);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(105, 57);
            this.save.TabIndex = 4;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(72, 290);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(105, 57);
            this.remove.TabIndex = 5;
            this.remove.Text = "remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 446);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 20);
            this.button4.TabIndex = 7;
            this.button4.Text = "remove list";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(300, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 199);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FORNECEDOR";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DATA";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "OBS";
            this.Column4.Name = "Column4";
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(72, 353);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(105, 57);
            this.load.TabIndex = 9;
            this.load.Text = "load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.load);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.save);
            this.Controls.Add(this.observacao);
            this.Controls.Add(this.data);
            this.Controls.Add(this.forncedor);
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox forncedor;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.TextBox observacao;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button load;
    }
}

