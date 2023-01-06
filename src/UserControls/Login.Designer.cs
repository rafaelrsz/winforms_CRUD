namespace Rafael_Cartsys.src.UserControls
{
  partial class Login
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
      this.BtnSubmitLogin = new System.Windows.Forms.Button();
      this.LbSenha = new System.Windows.Forms.Label();
      this.LbEmail = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.TbSenha = new System.Windows.Forms.TextBox();
      this.TbEmail = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // BtnSubmitLogin
      // 
      this.BtnSubmitLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.BtnSubmitLogin.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.BtnSubmitLogin.ForeColor = System.Drawing.Color.White;
      this.BtnSubmitLogin.Location = new System.Drawing.Point(173, 332);
      this.BtnSubmitLogin.Name = "BtnSubmitLogin";
      this.BtnSubmitLogin.Size = new System.Drawing.Size(285, 30);
      this.BtnSubmitLogin.TabIndex = 23;
      this.BtnSubmitLogin.Text = "Avançar";
      this.BtnSubmitLogin.UseVisualStyleBackColor = false;
      this.BtnSubmitLogin.Click += new System.EventHandler(this.BtnSubmitLogin_Click);
      // 
      // LbSenha
      // 
      this.LbSenha.AutoSize = true;
      this.LbSenha.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.LbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.LbSenha.Location = new System.Drawing.Point(173, 258);
      this.LbSenha.Name = "LbSenha";
      this.LbSenha.Size = new System.Drawing.Size(57, 25);
      this.LbSenha.TabIndex = 22;
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
      this.LbEmail.TabIndex = 21;
      this.LbEmail.Text = "Email";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.label2.Location = new System.Drawing.Point(277, 144);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(77, 39);
      this.label2.TabIndex = 20;
      this.label2.Text = "Login";
      // 
      // TbSenha
      // 
      this.TbSenha.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.TbSenha.Location = new System.Drawing.Point(173, 286);
      this.TbSenha.Name = "TbSenha";
      this.TbSenha.PasswordChar = '*';
      this.TbSenha.Size = new System.Drawing.Size(285, 31);
      this.TbSenha.TabIndex = 19;
      // 
      // TbEmail
      // 
      this.TbEmail.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.TbEmail.Location = new System.Drawing.Point(173, 218);
      this.TbEmail.Name = "TbEmail";
      this.TbEmail.Size = new System.Drawing.Size(285, 31);
      this.TbEmail.TabIndex = 18;
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.BtnSubmitLogin);
      this.Controls.Add(this.LbSenha);
      this.Controls.Add(this.LbEmail);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.TbSenha);
      this.Controls.Add(this.TbEmail);
      this.Name = "Login";
      this.Size = new System.Drawing.Size(630, 542);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Label label3;
        private Button BtnSubmitLogin;
        private Label LbSenha;
        private Label LbEmail;
        private Label label2;
        private TextBox TbSenha;
        private TextBox TbEmail;
    }
}
