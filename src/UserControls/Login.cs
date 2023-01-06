using Rafael_Cartsys.Shared.Hash;
using Rafael_Cartsys.src.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Rafael_Cartsys.src.UserControls
{
  public partial class Login : UserControl
  {
    SqlConnection con = new SqlConnection(PersonController.ConnectionString);
    public event EventHandler ButtonClick;

    public Login()
    {
      InitializeComponent();
    }

    private void BtnSubmitLogin_Click(object sender, EventArgs e)
    {
      con.Open();
      SqlCommand cmd = new SqlCommand("Select Email, Senha From Usuarios Where Email = @Email", con);
      cmd.CommandType = CommandType.Text;
      cmd.CommandTimeout = 0;
      cmd.Parameters.AddWithValue("@Email", TbEmail.Text);
      SqlDataAdapter da;
      DataSet ds;

      da = new SqlDataAdapter(cmd);
      ds = new DataSet();

      try
      {
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
          Hash hash = new Hash(SHA512.Create());
          string senha = ds.Tables[0].Rows[0]["Senha"].ToString();
          if (hash.VerificarSenha(TbSenha.Text, senha))
          {
            HomePanel.isUserLoggedIn = true;
            this.Dock = DockStyle.Right;
            this.Dock = DockStyle.Fill;
          }
          else
          {
            MessageBox.Show("Usuario ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }

        }
        else
        {
          MessageBox.Show("Usuario ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show("Ocorreu um erro na conexão com o banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        con.Close();
      }
    }
  }
}
