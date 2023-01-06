namespace Rafael_Cartsys.src.UserControls
{
  partial class Register
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
      this.BtnSubmitRegister = new System.Windows.Forms.Button();
      this.LbSenha = new System.Windows.Forms.Label();
      this.LbEmail = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.TbSenha = new System.Windows.Forms.TextBox();
      this.TbEmail = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // BtnSubmitRegister
      // 
      this.BtnSubmitRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.BtnSubmitRegister.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.BtnSubmitRegister.ForeColor = System.Drawing.Color.White;
      this.BtnSubmitRegister.Location = new System.Drawing.Point(173, 332);
      this.BtnSubmitRegister.Name = "BtnSubmitRegister";
      this.BtnSubmitRegister.Size = new System.Drawing.Size(285, 30);
      this.BtnSubmitRegister.TabIndex = 31;
      this.BtnSubmitRegister.Text = "Avançar";
      this.BtnSubmitRegister.UseVisualStyleBackColor = false;
      this.BtnSubmitRegister.Click += new System.EventHandler(this.BtnSubmitRegister_Click);
      // 
      // LbSenha
      // 
      this.LbSenha.AutoSize = true;
      this.LbSenha.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.LbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.LbSenha.Location = new System.Drawing.Point(173, 258);
      this.LbSenha.Name = "LbSenha";
      this.LbSenha.Size = new System.Drawing.Size(57, 25);
      this.LbSenha.TabIndex = 30;
      this.LbSenha.Text = "Senha";
      // 
      // LbEmail
      // 
      this.LbEmail.AutoSize = true;
      this.LbEmail.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.LbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.LbEmail.Location = new System.Drawing.Point(173, 190);
      this.LbEmail.Name = "LbEmail";
      this.LbEmail.Size = new System.Drawing.Size(51, 25);
      this.LbEmail.TabIndex = 29;
      this.LbEmail.Text = "Email";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.label2.Location = new System.Drawing.Point(260, 144);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(120, 39);
      this.label2.TabIndex = 28;
      this.label2.Text = "Registrar";
      // 
      // TbSenha
      // 
      this.TbSenha.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.TbSenha.Location = new System.Drawing.Point(173, 286);
      this.TbSenha.Name = "TbSenha";
      this.TbSenha.PasswordChar = '*';
      this.TbSenha.Size = new System.Drawing.Size(285, 31);
      this.TbSenha.TabIndex = 27;
      // 
      // TbEmail
      // 
      this.TbEmail.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.TbEmail.Location = new System.Drawing.Point(173, 218);
      this.TbEmail.Name = "TbEmail";
      this.TbEmail.Size = new System.Drawing.Size(285, 31);
      this.TbEmail.TabIndex = 26;
      // 
      // Register
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
      this.Controls.Add(this.BtnSubmitRegister);
      this.Controls.Add(this.LbSenha);
      this.Controls.Add(this.LbEmail);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.TbSenha);
      this.Controls.Add(this.TbEmail);
      this.Name = "Register";
      this.Size = new System.Drawing.Size(630, 542);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Button BtnSubmitRegister;
        private Label LbSenha;
        private Label LbEmail;
        private Label label2;
        private TextBox TbSenha;
        private TextBox TbEmail;
    }
}
