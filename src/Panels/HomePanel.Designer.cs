namespace Rafael_Cartsys
{
  partial class HomePanel
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.BtnMenuCad = new System.Windows.Forms.Button();
      this.BtnMenuRel = new System.Windows.Forms.Button();
      this.BtnMenuPessoas = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.BtnMenuLogin = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.pessoas1 = new Rafael_Cartsys.src.UserControls.Pessoas();
      this.login2 = new Rafael_Cartsys.src.UserControls.Login();
      this.register1 = new Rafael_Cartsys.src.UserControls.Register();
      this.personsPerAge1 = new Rafael_Cartsys.src.UserControls.PersonsPerAge();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel2.SuspendLayout();
      this.panel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.panel1.Controls.Add(this.BtnMenuCad);
      this.panel1.Controls.Add(this.BtnMenuRel);
      this.panel1.Controls.Add(this.BtnMenuPessoas);
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Controls.Add(this.BtnMenuLogin);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(172, 589);
      this.panel1.TabIndex = 0;
      // 
      // BtnMenuCad
      // 
      this.BtnMenuCad.FlatAppearance.BorderSize = 0;
      this.BtnMenuCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnMenuCad.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.BtnMenuCad.ForeColor = System.Drawing.Color.White;
      this.BtnMenuCad.Image = global::Rafael_Cartsys.Properties.Resources.contorno_do_botao_de_seta_quadrado_de_login;
      this.BtnMenuCad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BtnMenuCad.Location = new System.Drawing.Point(0, 303);
      this.BtnMenuCad.Name = "BtnMenuCad";
      this.BtnMenuCad.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.BtnMenuCad.Size = new System.Drawing.Size(172, 35);
      this.BtnMenuCad.TabIndex = 5;
      this.BtnMenuCad.Text = "    Cadastro";
      this.BtnMenuCad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.BtnMenuCad.UseVisualStyleBackColor = true;
      this.BtnMenuCad.Click += new System.EventHandler(this.BtnRegistrar_Click);
      // 
      // BtnMenuRel
      // 
      this.BtnMenuRel.FlatAppearance.BorderSize = 0;
      this.BtnMenuRel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnMenuRel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.BtnMenuRel.ForeColor = System.Drawing.Color.White;
      this.BtnMenuRel.Image = global::Rafael_Cartsys.Properties.Resources.contorno_do_botao_de_seta_quadrado_de_login;
      this.BtnMenuRel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BtnMenuRel.Location = new System.Drawing.Point(0, 376);
      this.BtnMenuRel.Name = "BtnMenuRel";
      this.BtnMenuRel.Size = new System.Drawing.Size(172, 41);
      this.BtnMenuRel.TabIndex = 4;
      this.BtnMenuRel.Text = "   Relatórios";
      this.BtnMenuRel.UseVisualStyleBackColor = true;
      this.BtnMenuRel.Click += new System.EventHandler(this.BtnMenuRel_Click);
      // 
      // BtnMenuPessoas
      // 
      this.BtnMenuPessoas.FlatAppearance.BorderSize = 0;
      this.BtnMenuPessoas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnMenuPessoas.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.BtnMenuPessoas.ForeColor = System.Drawing.Color.White;
      this.BtnMenuPessoas.Image = global::Rafael_Cartsys.Properties.Resources.contorno_do_botao_de_seta_quadrado_de_login;
      this.BtnMenuPessoas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BtnMenuPessoas.Location = new System.Drawing.Point(0, 339);
      this.BtnMenuPessoas.Name = "BtnMenuPessoas";
      this.BtnMenuPessoas.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.BtnMenuPessoas.Size = new System.Drawing.Size(172, 41);
      this.BtnMenuPessoas.TabIndex = 2;
      this.BtnMenuPessoas.Text = "    Pessoas";
      this.BtnMenuPessoas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.BtnMenuPessoas.UseVisualStyleBackColor = true;
      this.BtnMenuPessoas.Click += new System.EventHandler(this.button1_Click_1);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Rafael_Cartsys.Properties.Resources.cartosysLogo;
      this.pictureBox1.Location = new System.Drawing.Point(-6, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(158, 88);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // BtnMenuLogin
      // 
      this.BtnMenuLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
      this.BtnMenuLogin.FlatAppearance.BorderSize = 0;
      this.BtnMenuLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
      this.BtnMenuLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.BtnMenuLogin.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.BtnMenuLogin.ForeColor = System.Drawing.Color.White;
      this.BtnMenuLogin.Image = global::Rafael_Cartsys.Properties.Resources.contorno_do_botao_de_seta_quadrado_de_login;
      this.BtnMenuLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.BtnMenuLogin.Location = new System.Drawing.Point(0, 265);
      this.BtnMenuLogin.Name = "BtnMenuLogin";
      this.BtnMenuLogin.Size = new System.Drawing.Size(172, 32);
      this.BtnMenuLogin.TabIndex = 0;
      this.BtnMenuLogin.Text = "    Login";
      this.BtnMenuLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.BtnMenuLogin.UseVisualStyleBackColor = true;
      this.BtnMenuLogin.Click += new System.EventHandler(this.BtnLogin_Click);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(65)))), ((int)(((byte)(46)))));
      this.panel2.Controls.Add(this.label1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(172, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(630, 47);
      this.panel2.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(6, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(304, 28);
      this.label1.TabIndex = 0;
      this.label1.Text = "CRUD Simples com relatórios e login";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.pessoas1);
      this.panel4.Controls.Add(this.login2);
      this.panel4.Controls.Add(this.register1);
      this.panel4.Controls.Add(this.personsPerAge1);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel4.Location = new System.Drawing.Point(172, 47);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(630, 542);
      this.panel4.TabIndex = 2;
      // 
      // pessoas1
      // 
      this.pessoas1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pessoas1.Location = new System.Drawing.Point(0, 0);
      this.pessoas1.Name = "pessoas1";
      this.pessoas1.Size = new System.Drawing.Size(630, 542);
      this.pessoas1.TabIndex = 3;
      // 
      // login2
      // 
      this.login2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.login2.Location = new System.Drawing.Point(0, 0);
      this.login2.Name = "login2";
      this.login2.Size = new System.Drawing.Size(630, 542);
      this.login2.TabIndex = 2;
      this.login2.DockChanged += new System.EventHandler(this.Form1_Load);
      // 
      // register1
      // 
      this.register1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.register1.Location = new System.Drawing.Point(0, 0);
      this.register1.Name = "register1";
      this.register1.Size = new System.Drawing.Size(630, 542);
      this.register1.TabIndex = 1;
      // 
      // personsPerAge1
      // 
      this.personsPerAge1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.personsPerAge1.Location = new System.Drawing.Point(0, 0);
      this.personsPerAge1.Name = "personsPerAge1";
      this.personsPerAge1.Size = new System.Drawing.Size(630, 542);
      this.personsPerAge1.TabIndex = 4;
      // 
      // HomePanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(802, 589);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "HomePanel";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button BtnMenuLogin;
        private Panel panel2;
        private Button BtnMenuPessoas;
        private Button BtnMenuRel;
        private Label label1;
        private Panel panel4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private src.UserControls.Register register1;
        private Button BtnMenuCad;
        private src.UserControls.Login login2;
        public src.UserControls.Pessoas pessoas1;
        private src.UserControls.PersonsPerAge personsPerAge1;
    }
}