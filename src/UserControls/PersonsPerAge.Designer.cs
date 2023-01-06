namespace Rafael_Cartsys.src.UserControls
{
  partial class PersonsPerAge
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
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.SuspendLayout();
      // 
      // reportViewer1
      // 
      this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.reportViewer1.Location = new System.Drawing.Point(0, 0);
      this.reportViewer1.Name = "ReportViewer";
      this.reportViewer1.ServerReport.BearerToken = null;
      this.reportViewer1.Size = new System.Drawing.Size(632, 542);
      this.reportViewer1.TabIndex = 0;
      // 
      // PersonsPerAge
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.reportViewer1);
      this.Name = "PersonsPerAge";
      this.Size = new System.Drawing.Size(632, 542);
      this.Load += new System.EventHandler(this.PersonsPerAge_Load);
      this.DockChanged += new System.EventHandler(this.PersonsPerAge_Load);
      this.ResumeLayout(false);

    }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
  }
}
