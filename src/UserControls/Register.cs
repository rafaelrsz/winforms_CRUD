using Rafael_Cartsys.Shared.Hash;
using Rafael_Cartsys.src.Shared;
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
  public partial class Register : UserControl
  {

    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-01BBK2K;Initial Catalog=CartsysCRUD;Integrated Security=True");
    public Register()
    {
      InitializeComponent();
    }

    private void BtnSubmitRegister_Click(object sender, EventArgs e)
    {
      if (!ValidaEmail.ValidarEmail(TbEmail.Text))
      {
        MessageBox.Show("Email invalido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      con.Open();
      SqlCommand cmd = new SqlCommand("Select Email From Usuarios Where Email = @Email", con);
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
          TbEmail.Focus();
          MessageBox.Show("Já existe um usuário cadastrado com esse email.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
          Hash hash = new Hash(SHA512.Create());
          string senhaEncr = hash.CriptografarSenha(TbSenha.Text);

          cmd = new SqlCommand("Insert Into Usuarios (Email, Senha, DataCriacao) Values (@Email, @Senha, @DataCriacao)", con);
          cmd.CommandType = CommandType.Text;
          cmd.CommandTimeout = 0;
          cmd.Parameters.AddWithValue("@Email", TbEmail.Text);
          cmd.Parameters.AddWithValue("@Senha", senhaEncr);
          cmd.Parameters.AddWithValue("@DataCriacao", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss:fff"));
          da = new SqlDataAdapter(cmd);
          ds = new DataSet();
          da.Fill(ds);

          MessageBox.Show("Usuario criado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
          TbEmail.Text = "";
          TbSenha.Text = "";
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
