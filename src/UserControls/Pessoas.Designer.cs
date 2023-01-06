namespace Rafael_Cartsys.src.UserControls
{
  partial class Pessoas
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

    #region Código gerado pelo Designer de Componentes

    /// <summary> 
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.label2 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.BtnNovo = new System.Windows.Forms.Button();
      this.TbPesquisa = new System.Windows.Forms.TextBox();
      this.LbEmail = new System.Windows.Forms.Label();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.label2.Location = new System.Drawing.Point(262, 74);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(109, 39);
      this.label2.TabIndex = 21;
      this.label2.Text = "Pessoas";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToResizeColumns = false;
      this.dataGridView1.AllowUserToResizeRows = false;
      this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Idade,
            this.Column1,
            this.Column2});
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
      this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
      this.dataGridView1.Location = new System.Drawing.Point(37, 217);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dataGridView1.RowTemplate.Height = 25;
      this.dataGridView1.ShowEditingIcon = false;
      this.dataGridView1.Size = new System.Drawing.Size(555, 284);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // BtnNovo
      // 
      this.BtnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.BtnNovo.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.BtnNovo.ForeColor = System.Drawing.Color.White;
      this.BtnNovo.Location = new System.Drawing.Point(37, 168);
      this.BtnNovo.Name = "BtnNovo";
      this.BtnNovo.Size = new System.Drawing.Size(91, 33);
      this.BtnNovo.TabIndex = 23;
      this.BtnNovo.Text = "Novo";
      this.BtnNovo.UseVisualStyleBackColor = false;
      this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
      // 
      // TbPesquisa
      // 
      this.TbPesquisa.Location = new System.Drawing.Point(262, 178);
      this.TbPesquisa.Name = "TbPesquisa";
      this.TbPesquisa.Size = new System.Drawing.Size(330, 23);
      this.TbPesquisa.TabIndex = 24;
      this.TbPesquisa.TextChanged += new System.EventHandler(this.TbPesquisa_TextChanged);
      // 
      // LbEmail
      // 
      this.LbEmail.AutoSize = true;
      this.LbEmail.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.LbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.LbEmail.Location = new System.Drawing.Point(443, 150);
      this.LbEmail.Name = "LbEmail";
      this.LbEmail.Size = new System.Drawing.Size(149, 25);
      this.LbEmail.TabIndex = 25;
      this.LbEmail.Text = "Pesquisa por nome";
      // 
      // Id
      // 
      this.Id.DataPropertyName = "Id";
      this.Id.HeaderText = "Id";
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      this.Id.Width = 30;
      // 
      // Nome
      // 
      this.Nome.DataPropertyName = "Nome";
      this.Nome.HeaderText = "Nome";
      this.Nome.Name = "Nome";
      this.Nome.ReadOnly = true;
      this.Nome.Width = 350;
      // 
      // Idade
      // 
      this.Idade.DataPropertyName = "Idade";
      this.Idade.HeaderText = "Idade";
      this.Idade.Name = "Idade";
      this.Idade.ReadOnly = true;
      this.Idade.Width = 51;
      // 
      // Column1
      // 
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.NullValue = "Editar";
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
      this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
      this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Column1.HeaderText = "";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.Text = "Editar";
      this.Column1.ToolTipText = "Editar";
      this.Column1.Width = 62;
      // 
      // Column2
      // 
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle3.NullValue = "Apagar";
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
      this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
      this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Column2.HeaderText = "";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Text = "Apagar";
      this.Column2.Width = 62;
      // 
      // Pessoas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.LbEmail);
      this.Controls.Add(this.TbPesquisa);
      this.Controls.Add(this.BtnNovo);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.label2);
      this.Name = "Pessoas";
      this.Size = new System.Drawing.Size(630, 542);
      this.Load += new System.EventHandler(this.Pessoas_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Button BtnNovo;
        private TextBox TbPesquisa;
        private Label LbEmail;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Idade;
        private DataGridViewButtonColumn Column1;
        private DataGridViewButtonColumn Column2;
    }
}
