using Rafael_Cartsys.src.Controller;
using Rafael_Cartsys.src.Models;
using Rafael_Cartsys.src.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rafael_Cartsys.src.UserControls
{
  public partial class Pessoas : UserControl
  {
    public Pessoas()
    {
      InitializeComponent();
    }

    public void Display()
    {
      PersonController.readPerson(dataGridView1, TbPesquisa.Text);
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void BtnNovo_Click(object sender, EventArgs e)
    {
      PersonPanel form = new PersonPanel(this);
      form.ShowDialog();
    }

    private void Pessoas_Load(object sender, EventArgs e)
    {
      Display();
      dataGridView1.Refresh();
    }

    private void TbPesquisa_TextChanged(object sender, EventArgs e)
    {
      Display();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 0)
      {
        PersonPanel form = new PersonPanel(this, dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
        form.ShowDialog();
      }
      else if (e.ColumnIndex == 1)
      {
        if(MessageBox.Show("Tem certeza que deseja apagar este registro?", "Atenção!", MessageBoxButtons.YesNoCancel, 
          MessageBoxIcon.Information) == DialogResult.Yes)
        {
          PersonController.deletePerson(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
          Display();
        }
      }
      else
        return;
    }
  }
}
