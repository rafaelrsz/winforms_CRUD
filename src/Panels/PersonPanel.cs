using CpfLibrary;
using Rafael_Cartsys.src.Controller;
using Rafael_Cartsys.src.Models;
using Rafael_Cartsys.src.Shared;
using Rafael_Cartsys.src.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rafael_Cartsys.src.Panels
{
  public partial class PersonPanel : Form
  {
    private readonly Pessoas _parent;
    private readonly string _id;
    public PersonPanel(Pessoas parent, string personId = "0")
    {
      InitializeComponent();
      this.CenterToScreen();
      _parent = parent;
      _id = personId;
      if(personId != "0")
      {
        fillFields(personId);
      }
    }
    
    public void clearFields()
    {
      TbNome.Clear();
      TbEmail.Clear();
      TbCpf.Clear();
      TbRua.Clear();
      TbNumero.Clear();
      TbBairro.Clear();
      TbCidade.Clear();
      TbTel.Clear();
      TbIdade.Clear();
      TbSexo.Clear();
    }

    public void fillFields(string id)
    {
      Person person = PersonController.findPersonById(id);
      TbNome.Text = person.Nome;
      TbEmail.Text = person.Email;
      TbCpf.Text = person.Cpf;
      TbRua.Text = person.Rua;
      TbTel.Text = person.Telefone;
      TbBairro.Text = person.Bairro;
      TbCidade.Text = person.Cidade;
      TbNumero.Text = person.Numero;
      TbIdade.Text = person.Idade.ToString();
      TbSexo.Text = person.Sexo.ToString();
      LbId.Visible = false;
    }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

    private void BtnSalvar_Click(object sender, EventArgs e)
    {
      if (!Cpf.Check(TbCpf.Text))
      {
        MessageBox.Show("Cpf invalido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        TbCpf.Focus();
        return;
      }

      if (!ValidaEmail.ValidarEmail(TbEmail.Text))
      {
        MessageBox.Show("Email invalido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (!Int32.TryParse(TbIdade.Text, out int idade))
      {
        MessageBox.Show("O campo idade deve conter apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if(TbSexo.Text != "M" && TbSexo.Text != "F")
      {
        MessageBox.Show("O campo sexo deve ser prenchido apenas com 'M' ou 'F'", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if(TbNome.Text.Trim().Length == 0)
      {
        MessageBox.Show("O campo nome está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (TbIdade.Text.Trim().Length == 0)
      {
        MessageBox.Show("O campo idade está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (TbSexo.Text.Trim().Length == 0)
      {
        MessageBox.Show("O campo sexo está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (TbEmail.Text.Trim().Length == 0)
      {
        MessageBox.Show("O campo email está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (TbTel.Text.Trim().Length == 0)
      {
        MessageBox.Show("O campo telefone está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (TbCpf.Text.Trim().Length == 0)
      {
        MessageBox.Show("O campo cpf está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (TbRua.Text.Trim().Length == 0)
      {
        MessageBox.Show("O campo rua está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (TbBairro.Text.Trim().Length == 0)
      {
        MessageBox.Show("O campo bairro está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (TbNumero.Text.Trim().Length == 0)
      {
        MessageBox.Show("O campo número está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (TbCidade.Text.Trim().Length == 0)
      {
        MessageBox.Show("O campo cidade está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      Person person = new Person(Int32.Parse(_id), TbNome.Text, TbEmail.Text, TbCpf.Text, TbRua.Text, TbBairro.Text, 
        TbNumero.Text, TbCidade.Text, TbTel.Text, idade, Char.Parse(TbSexo.Text));

      if (_id == "0")
      {
        if (PersonController.findPersonByCpf(TbCpf.Text) != null)
        {
          MessageBox.Show("Já existe uma pessoa cadastrada com esse Cpf!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        PersonController.createPerson(person);
      }
      else
      {
        PersonController.updatePerson(person);
      }

      clearFields();
      _parent.Display();
      this.Close();
    }
  }
}
