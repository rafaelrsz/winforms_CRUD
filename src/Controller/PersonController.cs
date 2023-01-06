using Rafael_Cartsys.src.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rafael_Cartsys.src.Controller
{
  internal class PersonController
  {
    public static string ConnectionString = @"Data Source=DESKTOP-01BBK2K;Initial Catalog=CartsysCRUD;Integrated Security=True";

    public static void createPerson(Person person)
    {
      using (SqlConnection con = new SqlConnection(ConnectionString))
      {
        con.Open();
        SqlCommand cmd = new SqlCommand("Insert Into Pessoas " +
          "(Email, Nome, Cpf, Rua, Bairro, Numero, Cidade, Telefone, Idade, Sexo) " +
          "Values (@Email, @Nome, @Cpf, @Rua, @Bairro, @Numero, @Cidade, @Telefone, @Idade, @Sexo)", con);

        cmd.CommandType = CommandType.Text;
        cmd.CommandTimeout = 0;
        cmd.Parameters.AddWithValue("@Email", person.Email);
        cmd.Parameters.AddWithValue("@Nome", person.Nome);
        cmd.Parameters.AddWithValue("@Cpf", person.Cpf);
        cmd.Parameters.AddWithValue("@Rua", person.Rua);
        cmd.Parameters.AddWithValue("@Bairro", person.Bairro);
        cmd.Parameters.AddWithValue("@Numero", person.Numero);
        cmd.Parameters.AddWithValue("@Cidade", person.Cidade);
        cmd.Parameters.AddWithValue("@Telefone", person.Telefone);
        cmd.Parameters.AddWithValue("@Idade", person.Idade);
        cmd.Parameters.AddWithValue("@Sexo", person.Sexo);
        SqlDataAdapter da;
        DataSet ds;

        da = new SqlDataAdapter(cmd);
        ds = new DataSet();

        try
        {
          da.Fill(ds);
          MessageBox.Show("Registro criado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Ocorreu um erro na conexão com o banco de dados\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
          con.Close();
        }
      }
    }

    public static void updatePerson(Person person)
    {
      using (SqlConnection con = new SqlConnection(ConnectionString))
      {
        con.Open();
        SqlCommand cmd = new SqlCommand("Update Pessoas " +
          "Set Email = @Email, Nome = @Nome, Cpf = @Cpf, Rua = @Rua, Bairro = @Bairro, Numero = @Numero, " +
          "Cidade = @Cidade, Telefone = @Telefone, Idade = @Idade, Sexo = @Sexo " +
          "Where Id = @Id", con);

        cmd.CommandType = CommandType.Text;
        cmd.CommandTimeout = 0;
        cmd.Parameters.AddWithValue("@Email", person.Email);
        cmd.Parameters.AddWithValue("@Nome", person.Nome);
        cmd.Parameters.AddWithValue("@Cpf", person.Cpf);
        cmd.Parameters.AddWithValue("@Rua", person.Rua);
        cmd.Parameters.AddWithValue("@Bairro", person.Bairro);
        cmd.Parameters.AddWithValue("@Numero", person.Numero);  
        cmd.Parameters.AddWithValue("@Cidade", person.Cidade);
        cmd.Parameters.AddWithValue("@Telefone", person.Telefone);
        cmd.Parameters.AddWithValue("@Idade", person.Idade);
        cmd.Parameters.AddWithValue("@Sexo", person.Sexo);
        cmd.Parameters.AddWithValue("@Id", person.Id);
        SqlDataAdapter da;
        DataSet ds;

        da = new SqlDataAdapter(cmd);
        ds = new DataSet();

        try
        {
          da.Fill(ds);
          MessageBox.Show("Registro modificado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Ocorreu um erro na conexão com o banco de dados\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
          con.Close();
        }
      }
    }

    public static void deletePerson(string id)
    {
      using (SqlConnection con = new SqlConnection(ConnectionString))
      {
        con.Open();
        SqlCommand cmd = new SqlCommand("Delete Pessoas Where Id = @Id", con);

        cmd.CommandType = CommandType.Text;
        cmd.CommandTimeout = 0;
        cmd.Parameters.AddWithValue("@Id", id);
        SqlDataAdapter da;
        DataSet ds;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();

        try
        {
          da.Fill(ds);
          MessageBox.Show("Registro apagado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Ocorreu um erro na conexão com o banco de dados\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
          con.Close();
        }
      }
    }

    public static Person findPersonById(string id)
    {
      using (SqlConnection con = new SqlConnection(ConnectionString))
      {
        con.Open();
        SqlCommand cmd = new SqlCommand("Select * From Pessoas Where Id = @Id", con);

        cmd.CommandType = CommandType.Text;
        cmd.CommandTimeout = 0;
        cmd.Parameters.AddWithValue("@Id", id);
        SqlDataAdapter da;
        DataSet ds;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();

        Person person = null;

        try
        {
          da.Fill(ds);
          if (ds.Tables[0].Rows.Count > 0)
          {
            person = new Person(Int32.Parse(ds.Tables[0].Rows[0]["Id"].ToString()), ds.Tables[0].Rows[0]["Nome"].ToString(),
              ds.Tables[0].Rows[0]["Email"].ToString(), ds.Tables[0].Rows[0]["Cpf"].ToString(), ds.Tables[0].Rows[0]["Rua"].ToString(),
              ds.Tables[0].Rows[0]["Bairro"].ToString(), ds.Tables[0].Rows[0]["Numero"].ToString(), ds.Tables[0].Rows[0]["Cidade"].ToString(),
              ds.Tables[0].Rows[0]["Telefone"].ToString(), Int32.Parse(ds.Tables[0].Rows[0]["Idade"].ToString()), Char.Parse(ds.Tables[0].Rows[0]["Sexo"].ToString()));
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Ocorreu um erro na conexão com o banco de dados\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
          con.Close();
        }

        return person;
      }
    }

    public static Person findPersonByCpf(string cpf)
    {
      using (SqlConnection con = new SqlConnection(ConnectionString))
      {
        con.Open();
        SqlCommand cmd = new SqlCommand("Select * From Pessoas Where Cpf = @Cpf", con);

        cmd.CommandType = CommandType.Text;
        cmd.CommandTimeout = 0;
        cmd.Parameters.AddWithValue("@Cpf", cpf);
        SqlDataAdapter da;
        DataSet ds;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();

        Person person = null;

        try
        {
          da.Fill(ds);
          if (ds.Tables[0].Rows.Count > 0)
          {
            person = new Person(Int32.Parse(ds.Tables[0].Rows[0]["Id"].ToString()), ds.Tables[0].Rows[0]["Nome"].ToString(),
              ds.Tables[0].Rows[0]["Email"].ToString(), ds.Tables[0].Rows[0]["Cpf"].ToString(), ds.Tables[0].Rows[0]["Rua"].ToString(),
              ds.Tables[0].Rows[0]["Bairro"].ToString(), ds.Tables[0].Rows[0]["Numero"].ToString(), ds.Tables[0].Rows[0]["Cidade"].ToString(),
              ds.Tables[0].Rows[0]["Telefone"].ToString(), Int32.Parse(ds.Tables[0].Rows[0]["Idade"].ToString()), Char.Parse(ds.Tables[0].Rows[0]["Sexo"].ToString()));
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Ocorreu um erro na conexão com o banco de dados\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
          con.Close();
        }

        return person;
      }
    }

    public static void readPerson(DataGridView dgv, string nameSearch = "")
    {
      using (SqlConnection con = new SqlConnection(ConnectionString))
      {
        con.Open();
        SqlCommand cmd = new SqlCommand("Select * From Pessoas Where Nome Like '%' + @Nome + '%'", con);

        cmd.CommandType = CommandType.Text;
        cmd.CommandTimeout = 0;
        cmd.Parameters.AddWithValue("@Nome", nameSearch);
        SqlDataAdapter da;
        DataSet ds;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();

        try
        {
          da.Fill(ds);
          DataTable dtAll = ds.Tables[0].Copy();
          for (var i = 1; i < ds.Tables.Count; i++)
          {
            dtAll.Merge(ds.Tables[i]);
          }
          dgv.AutoGenerateColumns = true;
          dgv.DataSource = dtAll;
        }
        catch (Exception ex)
        {
          MessageBox.Show("Ocorreu um erro na conexão com o banco de dados\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
          con.Close();
        }
      }
    }
  }
}
