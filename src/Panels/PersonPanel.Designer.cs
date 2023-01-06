namespace Rafael_Cartsys.src.Panels
{
  partial class PersonPanel
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.BtnApagar = new System.Windows.Forms.Button();
      this.BtnSalvar = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.TbCidade = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.TbNumero = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.TbBairro = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.TbRua = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.TbTel = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.TbCpf = new System.Windows.Forms.TextBox();
      this.LbEmail = new System.Windows.Forms.Label();
      this.TbEmail = new System.Windows.Forms.TextBox();
      this.LbSexo = new System.Windows.Forms.Label();
      this.TbSexo = new System.Windows.Forms.TextBox();
      this.LbIdade = new System.Windows.Forms.Label();
      this.TbIdade = new System.Windows.Forms.TextBox();
      this.LbNome = new System.Windows.Forms.Label();
      this.TbNome = new System.Windows.Forms.TextBox();
      this.LbId = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(690, 86);
      this.panel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(196, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(256, 39);
      this.label1.TabIndex = 3;
      this.label1.Text = "Cadastro de pessoas";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Rafael_Cartsys.Properties.Resources.cartosysLogo;
      this.pictureBox1.Location = new System.Drawing.Point(-12, -16);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(179, 120);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.LbId);
      this.panel2.Controls.Add(this.BtnApagar);
      this.panel2.Controls.Add(this.BtnSalvar);
      this.panel2.Controls.Add(this.label7);
      this.panel2.Controls.Add(this.TbCidade);
      this.panel2.Controls.Add(this.label8);
      this.panel2.Controls.Add(this.TbNumero);
      this.panel2.Controls.Add(this.label4);
      this.panel2.Controls.Add(this.TbBairro);
      this.panel2.Controls.Add(this.label5);
      this.panel2.Controls.Add(this.TbRua);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.TbTel);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Controls.Add(this.TbCpf);
      this.panel2.Controls.Add(this.LbEmail);
      this.panel2.Controls.Add(this.TbEmail);
      this.panel2.Controls.Add(this.LbSexo);
      this.panel2.Controls.Add(this.TbSexo);
      this.panel2.Controls.Add(this.LbIdade);
      this.panel2.Controls.Add(this.TbIdade);
      this.panel2.Controls.Add(this.LbNome);
      this.panel2.Controls.Add(this.TbNome);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 86);
      this.panel2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(690, 394);
      this.panel2.TabIndex = 1;
      // 
      // BtnApagar
      // 
      this.BtnApagar.BackColor = System.Drawing.Color.Brown;
      this.BtnApagar.ForeColor = System.Drawing.Color.White;
      this.BtnApagar.Location = new System.Drawing.Point(467, 318);
      this.BtnApagar.Name = "BtnApagar";
      this.BtnApagar.Size = new System.Drawing.Size(176, 31);
      this.BtnApagar.TabIndex = 42;
      this.BtnApagar.Text = "Apagar";
      this.BtnApagar.UseVisualStyleBackColor = false;
      // 
      // BtnSalvar
      // 
      this.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.BtnSalvar.ForeColor = System.Drawing.Color.White;
      this.BtnSalvar.Location = new System.Drawing.Point(32, 318);
      this.BtnSalvar.Name = "BtnSalvar";
      this.BtnSalvar.Size = new System.Drawing.Size(409, 31);
      this.BtnSalvar.TabIndex = 41;
      this.BtnSalvar.Text = "Salvar registro";
      this.BtnSalvar.UseVisualStyleBackColor = false;
      this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.label7.Location = new System.Drawing.Point(534, 202);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(63, 25);
      this.label7.TabIndex = 40;
      this.label7.Text = "Cidade";
      // 
      // TbCidade
      // 
      this.TbCidade.Location = new System.Drawing.Point(534, 230);
      this.TbCidade.Name = "TbCidade";
      this.TbCidade.Size = new System.Drawing.Size(109, 31);
      this.TbCidade.TabIndex = 39;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.label8.Location = new System.Drawing.Point(435, 202);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(70, 25);
      this.label8.TabIndex = 38;
      this.label8.Text = "Número";
      // 
      // TbNumero
      // 
      this.TbNumero.Location = new System.Drawing.Point(435, 230);
      this.TbNumero.Name = "TbNumero";
      this.TbNumero.Size = new System.Drawing.Size(70, 31);
      this.TbNumero.TabIndex = 37;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.label4.Location = new System.Drawing.Point(244, 202);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(55, 25);
      this.label4.TabIndex = 36;
      this.label4.Text = "Bairro";
      // 
      // TbBairro
      // 
      this.TbBairro.Location = new System.Drawing.Point(244, 230);
      this.TbBairro.Name = "TbBairro";
      this.TbBairro.Size = new System.Drawing.Size(142, 31);
      this.TbBairro.TabIndex = 35;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.label5.Location = new System.Drawing.Point(32, 202);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(39, 25);
      this.label5.TabIndex = 34;
      this.label5.Text = "Rua";
      // 
      // TbRua
      // 
      this.TbRua.Location = new System.Drawing.Point(32, 230);
      this.TbRua.Name = "TbRua";
      this.TbRua.Size = new System.Drawing.Size(193, 31);
      this.TbRua.TabIndex = 33;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.label3.Location = new System.Drawing.Point(244, 120);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(74, 25);
      this.label3.TabIndex = 32;
      this.label3.Text = "Telefone";
      // 
      // TbTel
      // 
      this.TbTel.Location = new System.Drawing.Point(244, 148);
      this.TbTel.Name = "TbTel";
      this.TbTel.Size = new System.Drawing.Size(142, 31);
      this.TbTel.TabIndex = 31;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.label2.Location = new System.Drawing.Point(443, 120);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 25);
      this.label2.TabIndex = 30;
      this.label2.Text = "Cpf";
      // 
      // TbCpf
      // 
      this.TbCpf.Location = new System.Drawing.Point(435, 148);
      this.TbCpf.Name = "TbCpf";
      this.TbCpf.Size = new System.Drawing.Size(208, 31);
      this.TbCpf.TabIndex = 29;
      // 
      // LbEmail
      // 
      this.LbEmail.AutoSize = true;
      this.LbEmail.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.LbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.LbEmail.Location = new System.Drawing.Point(32, 120);
      this.LbEmail.Name = "LbEmail";
      this.LbEmail.Size = new System.Drawing.Size(51, 25);
      this.LbEmail.TabIndex = 28;
      this.LbEmail.Text = "Email";
      // 
      // TbEmail
      // 
      this.TbEmail.Location = new System.Drawing.Point(32, 148);
      this.TbEmail.Name = "TbEmail";
      this.TbEmail.Size = new System.Drawing.Size(193, 31);
      this.TbEmail.TabIndex = 27;
      // 
      // LbSexo
      // 
      this.LbSexo.AutoSize = true;
      this.LbSexo.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.LbSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.LbSexo.Location = new System.Drawing.Point(568, 45);
      this.LbSexo.Name = "LbSexo";
      this.LbSexo.Size = new System.Drawing.Size(47, 25);
      this.LbSexo.TabIndex = 26;
      this.LbSexo.Text = "Sexo";
      // 
      // TbSexo
      // 
      this.TbSexo.Location = new System.Drawing.Point(568, 73);
      this.TbSexo.MaxLength = 1;
      this.TbSexo.Name = "TbSexo";
      this.TbSexo.Size = new System.Drawing.Size(75, 31);
      this.TbSexo.TabIndex = 25;
      this.TbSexo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // LbIdade
      // 
      this.LbIdade.AutoSize = true;
      this.LbIdade.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.LbIdade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.LbIdade.Location = new System.Drawing.Point(435, 45);
      this.LbIdade.Name = "LbIdade";
      this.LbIdade.Size = new System.Drawing.Size(52, 25);
      this.LbIdade.TabIndex = 24;
      this.LbIdade.Text = "Idade";
      // 
      // TbIdade
      // 
      this.TbIdade.Location = new System.Drawing.Point(435, 73);
      this.TbIdade.Name = "TbIdade";
      this.TbIdade.Size = new System.Drawing.Size(83, 31);
      this.TbIdade.TabIndex = 23;
      // 
      // LbNome
      // 
      this.LbNome.AutoSize = true;
      this.LbNome.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.LbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.LbNome.Location = new System.Drawing.Point(32, 45);
      this.LbNome.Name = "LbNome";
      this.LbNome.Size = new System.Drawing.Size(55, 25);
      this.LbNome.TabIndex = 22;
      this.LbNome.Text = "Nome";
      // 
      // TbNome
      // 
      this.TbNome.Location = new System.Drawing.Point(32, 73);
      this.TbNome.Name = "TbNome";
      this.TbNome.Size = new System.Drawing.Size(354, 31);
      this.TbNome.TabIndex = 0;
      // 
      // LbId
      // 
      this.LbId.AutoSize = true;
      this.LbId.Location = new System.Drawing.Point(34, 15);
      this.LbId.Name = "LbId";
      this.LbId.Size = new System.Drawing.Size(0, 28);
      this.LbId.TabIndex = 43;
      // 
      // PersonPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(690, 480);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PersonPanel";
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Label label1;
    private PictureBox pictureBox1;
        private Label LbNome;
        private TextBox TbNome;
        private Label LbSexo;
        private TextBox TbSexo;
        private Label LbIdade;
        private TextBox TbIdade;
        private Label LbEmail;
        private TextBox TbEmail;
        private Label label7;
        private TextBox TbCidade;
        private Label label8;
        private TextBox TbNumero;
        private Label label4;
        private TextBox TbBairro;
        private Label label5;
        private TextBox TbRua;
        private Label label3;
        private TextBox TbTel;
        private Label label2;
        private TextBox TbCpf;
        private Button BtnApagar;
        private Button BtnSalvar;
        private Label LbId;
    }
}