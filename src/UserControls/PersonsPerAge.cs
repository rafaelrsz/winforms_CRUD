using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using Rafael_Cartsys.src.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rafael_Cartsys.src.UserControls
{
  public partial class PersonsPerAge : UserControl
  {
    SqlConnection con = new SqlConnection(PersonController.ConnectionString);
    public PersonsPerAge()
    {
      InitializeComponent();
    }
    private void PersonsPerAge_Load(object sender, EventArgs e)
    {
      reportViewer1.LocalReport.ReportEmbeddedResource = "Rafael_Cartsys.src.Reports.ReportPersonsPerAge.rdlc";
      reportViewer1.RefreshReport();

      con.Open();
      SqlCommand cmd = new SqlCommand("Select * From Pessoas", con);
      cmd.CommandType = CommandType.Text;
      cmd.CommandTimeout = 0;
      SqlDataAdapter da;
      CartsysCRUDDataSet ds = new CartsysCRUDDataSet();

      da = new SqlDataAdapter(cmd);

      try
      {
        da.Fill(ds, "Pessoas");

        if (ds.Tables[0].Rows.Count == 0)
        {
          MessageBox.Show("Nenhum registro encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        ReportDataSource rDataSource = new ReportDataSource("DbPessoas", ds.Tables[0]);
        this.reportViewer1.LocalReport.DataSources.Clear();
        this.reportViewer1.LocalReport.DataSources.Add(rDataSource);
        this.reportViewer1.RefreshReport();
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
