using System.Data;
using System.Data.SqlClient;

namespace Rafael_Cartsys
{
  public partial class HomePanel : Form
  {
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-01BBK2K;Initial Catalog=CartsysCRUD;Integrated Security=True");

    public static bool isUserLoggedIn = false;
    public HomePanel()
    {
      InitializeComponent();
      this.CenterToScreen();
      SetAtivePanel(login2);
    }

    public void Form1_Load(object sender, EventArgs e)
    {
      if (isUserLoggedIn)
        SetAtivePanel(pessoas1);
      else
        SetAtivePanel(login2);
    }

    private void BtnLogin_Click(object sender, EventArgs e)
    {
      SetAtivePanel(login2);
    }

    private void BtnRegistrar_Click(object sender, EventArgs e)
    {
      SetAtivePanel(register1);
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      SetAtivePanel(pessoas1);
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {
      con.Open();
      SqlCommand cmd = new SqlCommand("Select Email, Senha From Usuarios Where Email = @Usuario", con);
      cmd.CommandType = CommandType.Text;
      cmd.CommandTimeout = 0;
      SqlDataAdapter da;
      DataSet ds;

      string Email, Senha;

    }

    private void button4_Click_1(object sender, EventArgs e)
    {

    }

    public void SetAtivePanel(UserControl control)
    {
      login2.Visible = false;
      register1.Visible = false;
      pessoas1.Visible = false;
      personsPerAge1.Visible = false;

      if (isUserLoggedIn)
      {
        BtnMenuPessoas.Visible = true;
        BtnMenuRel.Visible = true;
        BtnMenuLogin.Visible = false;
        BtnMenuCad.Visible = false;
      }
      else
      {
        BtnMenuPessoas.Visible = false;
        BtnMenuRel.Visible = false;
        BtnMenuLogin.Visible = true;
        BtnMenuCad.Visible = true;
      }

      control.Visible = true;
    }

    private void button4_Click_2(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void BtnMenuRel_Click(object sender, EventArgs e)
    {
      personsPerAge1.Dock = System.Windows.Forms.DockStyle.Left;
      personsPerAge1.Dock = System.Windows.Forms.DockStyle.Fill;
      SetAtivePanel(personsPerAge1);
    }
  }
}